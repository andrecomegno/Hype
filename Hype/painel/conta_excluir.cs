using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hype.painel;
using Hype.script;
using MySql.Data.MySqlClient;

namespace Hype.painel
{
    public partial class conta_excluir : UserControl
    {
        public string id_membro = "";
        public string id_progressao = "";
        public string id_recrutamento = "";

        public string id_alt = "";
        public string data_saida = "";
        public string nick_alt = "";
        public string level_alt = "";
        public string classe_alt = "";
        public string cla_alt = "";

        private string verificar = "";

        public conta_excluir()
        {
            InitializeComponent();
            CampoDesabilitado(pl_conteudo_01.Controls);

            // PALAVRA CHAVE PARA BUSCAR ALT
            txt_nick.Texts = membros.Instance.nick;

            lb_data_saida.Text = DateTime.Now.ToShortDateString();
        }

        #region TABELA MEMBROS ALT
        private void TabelaMembrosAlt()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select ID_ALT, DATA_ENTRADA, NICK_PRINCIPAL, NICK_ALT, LEVEL_ALT, CLASSE_ALT, CLA_ALT from hypedb.cadastro_alt where NICK_PRINCIPAL like @nick_alt '%' ", database.getConnection());

            cmd.Parameters.AddWithValue("@nick_alt", txt_nick.Texts);

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            
            database.closeConnection();

            Tabela();
        }

        private void Tabela()
        {         
            dataGridView1.Columns[0].Visible = false; // ID_ALT
            dataGridView1.Columns[1].Visible = false; // DATA_ENTRADA
            dataGridView1.Columns[2].Visible = false; // NICK_PRINCIPAL
            dataGridView1.Columns[3].HeaderText = "NICK";
            dataGridView1.Columns[4].HeaderText = "LEVEL";
            dataGridView1.Columns[5].HeaderText = "CLASSE";
            dataGridView1.Columns[6].HeaderText = "CLÃ";

            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;

            // ADICIONA A CAIXA DE SELECAO NA TABELA 
            DataGridViewCheckBoxColumn selecionar = new DataGridViewCheckBoxColumn();
            selecionar.Name = "SELECIONAR";
            selecionar.DataPropertyName = "SELECIONAR";
            selecionar.HeaderText = "";

            dataGridView1.Columns.Insert(0, selecionar);            

            dataGridView1.Columns["DATA_ENTRADA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LEVEL_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "NICK_ALT")
                    column.Width = 220;
                else if (column.DataPropertyName == "LEVEL_ALT")
                    column.Width = 100;
                else if (column.DataPropertyName == "CLASSE_ALT")
                    column.Width = 150;
                else if (column.DataPropertyName == "CLA_ALT")
                    column.Width = 200;
                else if (column.DataPropertyName == "SELECIONAR")
                    column.Width = 30;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["SELECIONAR"].Index)
            {
                //INTERROMPE A EDICAO NO dataGridView1
                dataGridView1.EndEdit();

                // EXIBE OS VALORES DA CELULA VERDADEIRO OU FASO
                verificar = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                // VERIFICA SE A CAIXA DE SELEÇÃO FOI SELECIONADA
                if (verificar == "True")
                {
                    MostrarDadosTabela();
                }

                //MessageBox.Show("" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        // SETA O ID DA ALT 
        private void MostrarDadosTabela()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

                    id_alt += dr["ID_ALT"].ToString();
                    nick_alt += dr["NICK_ALT"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        public void DadosMembros()
        {
            // CADASTRO              
            id_membro = membros.Instance.id_membro;
            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Texts = membros.Instance.patente;
            txt_classe.Texts = membros.Instance.classe;
            txt_cla.Texts = membros.Instance.foi_para_cla;
            id_progressao = membros.Instance.id_progressao;
            id_recrutamento = membros.Instance.id_recrutamento;
        }
        #endregion

        #region BOTOES
        private void BotaoVoltar()
        {
            conta_principal uc = new conta_principal();
            cla.Instance.addControl(uc);
        }

        private void BotaoCancelar()
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Tem Certeza Que Deseja Excluir ?", "AVISO !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        ExcluirConta();
                        break;
                    case DialogResult.No:
                        
                        break;
                    default:
                        break;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                BotaoCancelar();                
            }
        }

        private void ExcluirConta()
        {
            configdb database = new configdb();
            database.openConnection();

            try
            {
                // EXCLUIR CONTA PRINCIPAL
                MySqlCommand objCmdRecrutamento = new MySqlCommand("delete from hypedb.recrutamento where ID_RECRUTAMENTO=@ID_RECRUTAMENTO", database.getConnection());
                objCmdRecrutamento.Parameters.AddWithValue("@ID_RECRUTAMENTO", id_recrutamento);

                objCmdRecrutamento.ExecuteNonQuery();

                MySqlCommand objCmdProgressao = new MySqlCommand("delete from hypedb.progressao where ID_PROGRESSAO=@ID_PROGRESSAO", database.getConnection());
                objCmdProgressao.Parameters.AddWithValue("@ID_PROGRESSAO", id_progressao);

                objCmdProgressao.ExecuteNonQuery();

                // SAIDA DO CLA
                MySqlCommand objCmdSaidaCla = new MySqlCommand("insert into hypedb.saida_do_cla (id_saida_do_cla, data_saida, nick, level, poder, classe, patente, anotacao, nick_alt) values (null, ?, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());
                objCmdSaidaCla.Parameters.Add("@data_saida", MySqlDbType.Date).Value = DateTime.Now;
                objCmdSaidaCla.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
                objCmdSaidaCla.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_level.Texts;
                objCmdSaidaCla.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
                objCmdSaidaCla.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
                objCmdSaidaCla.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;
                objCmdSaidaCla.Parameters.Add("@anotacao", MySqlDbType.VarChar, 256).Value = txt_motivo.Text;
                objCmdSaidaCla.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = nick_alt;

                objCmdSaidaCla.ExecuteNonQuery();

                // VERIFICA SE A CAIXA DE SELEÇÃO FOI SELECIONADA
                if (verificar == "True")
                {
                    // EXCLUIR ALT
                    MySqlCommand objCmdCadastroAlt = new MySqlCommand("delete from hypedb.cadastro_alt where ID_ALT=@ID_ALT", database.getConnection());
                    objCmdCadastroAlt.Parameters.AddWithValue("@ID_ALT", id_alt);

                    objCmdCadastroAlt.ExecuteNonQuery();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }            


            database.closeConnection();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            BotaoVoltar();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            BotaoCancelar();
        }

        private void CampoDesabilitado(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)(c)).Enabled = false;
                    ((RJTextBox)(c)).BackColor = Color.FromArgb(235, 235, 235);
                }
            }

        }
        #endregion

        private void conta_excluir_Load(object sender, EventArgs e)
        {
            TabelaMembrosAlt();
            DadosMembros();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;            
        }

    }
}
