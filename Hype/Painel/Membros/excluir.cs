using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hype.script;
using MySql.Data.MySqlClient;

namespace Hype.Painel
{
    public partial class conta_excluir : UserControl
    {
        string id_membro = membros.Instance.id_membro;
        string id_recrutamento = membros.Instance.id_recrutamento;
        string nick_alt = string.Empty;

        public conta_excluir()
        {
            InitializeComponent();
            CampoDesabilitado(pl_conteudo_01.Controls);

            lb_data_saida.Text = DateTime.Now.ToShortDateString();
        }

        #region TABELA MEMBROS E ALT
        private void TabelaMembrosALT()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select ID_ALT, DATA_ALT, NICK_ALT, LEVEL_ALT, CLASSE_ALT, CLA_ALT, ID_MEMBROS from hypedb.cadastro_alt where ID_MEMBROS = '" + id_membro + "' ", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            
            database.closeConnection();

            // VERIFICA SE A TABELA NÀO TEM NENHUM REGISTRO
            if (dataGridView1.Rows.Count == 0)
            {
                txt_sem_dados.Visible = true;
                txt_clique_aqui.Visible = true;
                lb_conta_alt.Visible = false;

                dataGridView1.Visible = false;
            }
            else
            {
                txt_sem_dados.Visible = false;
                txt_clique_aqui.Visible = false;

                lb_conta_alt.Visible = true;
                dataGridView1.Visible = true;
            }

            Tabela();
        }

        private void Tabela()
        {         
            dataGridView1.Columns[0].Visible = false; // ID_ALT
            dataGridView1.Columns[1].Visible = false; // DATA_ENTRADA
            dataGridView1.Columns[2].HeaderText = "NICK";
            dataGridView1.Columns[3].HeaderText = "LEVEL";
            dataGridView1.Columns[4].HeaderText = "CLASSE";
            dataGridView1.Columns[5].HeaderText = "CLÃ";
            dataGridView1.Columns[6].Visible = false; // ID_MEMBROS

            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;

            // ADICIONA A CAIXA DE SELEÇÃO NA TABELA 
            DataGridViewCheckBoxColumn selecionar = new DataGridViewCheckBoxColumn();
            selecionar.Name = "SELECIONAR";
            selecionar.DataPropertyName = "SELECIONAR";
            selecionar.HeaderText = "";

            dataGridView1.Columns.Insert(0, selecionar);            

            dataGridView1.Columns["DATA_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                //INTERROMPE A EDIÇÃO NO dataGridView1
                dataGridView1.EndEdit();

                //DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                //nick_alt = dr["NICK_ALT"].ToString();                
            }
        }

        public void DadosMembros()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.DATA_RECRUTAMENTO, c.NICK, c.LEVEL, c.PODER, c.CLASSE, c.PATENTE, alt.ID_ALT, alt.DATA_ALT, alt.NICK_ALT, alt.LEVEL_ALT, alt.CLASSE_ALT, alt.CLA_ALT, pro.ID_PROGRESSAO, pro.DATA_PROGRESSAO, pro.ANTIGO_LEVEL, pro.ANTIGO_PODER, pro.NOVO_LEVEL, pro.NOVO_PODER, re.ID_RECRUTAMENTO, re.VEM_DO_CLA, re.FOI_PARA_CLA from hypedb.cadastro_membro c left join hypedb.cadastro_alt alt on c.ID_MEMBROS = alt.ID_ALT left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS left join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_MEMBROS where c.id_membros = '" + id_membro + "' ", database.getConnection());

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txt_nick.Texts = dr["NICK"].ToString();
                txt_level.Texts = dr["LEVEL"].ToString();
                txt_poder.Texts = dr["PODER"].ToString();
                txt_classe.Texts = dr["CLASSE"].ToString();
                txt_patente.Texts = dr["PATENTE"].ToString();
                txt_esta_cla.Texts = dr["FOI_PARA_CLA"].ToString();
            }

            database.closeConnection();
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
                MySqlCommand objCmdRecrutamento = new MySqlCommand("delete from hypedb.recrutamento where (id_recrutamento=@id_recrutamento) ", database.getConnection());
                objCmdRecrutamento.Parameters.AddWithValue("@id_recrutamento", id_recrutamento);

                objCmdRecrutamento.ExecuteNonQuery();            

                // QUANDO TIVER ALT CADASTRADA 
                if(dataGridView1.Visible == true)
                {
                    // VERIFICA SE O CHECKBOX ESTA SELECIONADO COMO VERDADEIRO, NA CELL ZERO 
                    if (bool.Parse(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString()) == true)
                    {
                        foreach (DataGridViewRow check in dataGridView1.Rows)
                        {
                            // PEGA TODOS OS VALORES SELECIONADOS NA CELLS, O ZERO QUE REPRESENTA O CHECKBOX
                            if (bool.Parse(check.Cells[0].EditedFormattedValue.ToString()))
                            {
                                // EXCLUIR ALT
                                MySqlCommand objCmdCadastroAlt = new MySqlCommand("delete from hypedb.cadastro_alt where id_alt=@id_alt", database.getConnection());
                                objCmdCadastroAlt.Parameters.AddWithValue("@id_alt", check.Cells[1].Value.ToString()); // TODOS OS ID`S SELECIONADOS

                                objCmdCadastroAlt.ExecuteNonQuery();
                            }
                        }
                    }
                }

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

        private void txt_clique_aqui_Click(object sender, EventArgs e)
        {
            cadastro_alt uc = new cadastro_alt();
            cla.Instance.addControl(uc);
        }

        private void CampoDesabilitado(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)(c)).Enabled = false;
                    ((RJTextBox)(c)).BackColor = Color.LightGray;
                }
            }

        }
        #endregion

        private void conta_excluir_Load(object sender, EventArgs e)
        {

            DadosMembros();
            TabelaMembrosALT();            

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;            
        }
    }
}
