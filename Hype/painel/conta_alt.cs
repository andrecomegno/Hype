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
    public partial class conta_alt : UserControl
    {
        string id_alt = "";

        string[] id_01;

        string teste = "";

        string nick_principal = "";
        private string verificar = "";

        public conta_alt()
        {
            InitializeComponent();

            nick_principal = alts.Instance.nick_principal;
        }

        #region TABELAS
        private void TabelaAlt()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand objCmdCadastroAlt = new MySqlCommand("select DATA_ENTRADA, ID_ALT, NICK_ALT, LEVEL_ALT, CLASSE_ALT, CLA_ALT, NICK_PRINCIPAL from hypedb.cadastro_alt where NICK_PRINCIPAL like @NICK_PRINCIPAL '%' ", database.getConnection());

            objCmdCadastroAlt.Parameters.AddWithValue("@NICK_PRINCIPAL", nick_principal);

            using (MySqlDataAdapter da = new MySqlDataAdapter(objCmdCadastroAlt))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }            

            objCmdCadastroAlt.ExecuteNonQuery();

            database.closeConnection();

            Tabela();
        }

        private void Tabela()
        {

            dataGridView1.Columns[0].Visible = false; // DATA_ENTRADA
            dataGridView1.Columns[1].Visible = false; // ID_ALT
            dataGridView1.Columns[2].HeaderText = "NICK";
            dataGridView1.Columns[3].HeaderText = "LEVEL";
            dataGridView1.Columns[4].HeaderText = "CLASSE";
            dataGridView1.Columns[5].HeaderText = "CLÃ";
            dataGridView1.Columns[6].HeaderText = "CONTA PRINCIPAL";

            dataGridView1.Columns[2].ReadOnly = true;
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

            dataGridView1.Columns["LEVEL_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "NICK_ALT")
                    column.Width = 220;
                else if (column.DataPropertyName == "LEVEL_ALT")
                    column.Width = 80;
                else if (column.DataPropertyName == "CLASSE_ALT")
                    column.Width = 100;
                else if (column.DataPropertyName == "CLA_ALT")
                    column.Width = 185;
                else if (column.DataPropertyName == "NICK_PRINCIPAL")
                    column.Width = 220;
                else if (column.DataPropertyName == "SELECIONAR")
                    column.Width = 30;
            }
        }

        private void AtualizarTabela()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand objCmdCadastroAlt = new MySqlCommand("select DATA_ENTRADA, ID_ALT, NICK_ALT, LEVEL_ALT, CLASSE_ALT, CLA_ALT, NICK_PRINCIPAL from hypedb.cadastro_alt where NICK_PRINCIPAL like @NICK_PRINCIPAL '%' ", database.getConnection());

            objCmdCadastroAlt.Parameters.AddWithValue("@NICK_PRINCIPAL", nick_principal);

            using (MySqlDataAdapter da = new MySqlDataAdapter(objCmdCadastroAlt))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            objCmdCadastroAlt.ExecuteNonQuery();

            database.closeConnection();
        }

        private void SelecionarDadosTabela()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                    // CONTA PRINCIPAL
                    nick_principal = dr["NICK_PRINCIPAL"].ToString();

                    // ALT
                    id_alt = dr["ID_ALT"].ToString();
                    txt_nick.Texts = dr["NICK_ALT"].ToString();
                    txt_level.Texts = dr["LEVEL_ALT"].ToString();
                    txt_classe.Texts = dr["CLASSE_ALT"].ToString();
                    txt_cla.Texts = dr["CLA_ALT"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        public void DadosMembros()
        {
            // ALT SELECIONADA - ALT.CS
            id_alt = alts.Instance.id_alt;
            txt_nick.Texts = alts.Instance.nick_alt;
            txt_level.Texts = alts.Instance.level_alt;
            txt_classe.Texts = alts.Instance.classe_alt;
            txt_cla.Texts = alts.Instance.cla_alt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["SELECIONAR"].Index)
            {
                //INTERROMPE A EDICAO NO dataGridView1
                dataGridView1.EndEdit();

                // EXIBE OS VALORES DA CELULA VERDADEIRO OU FASO
                verificar = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


                if (verificar == "True")
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {

                        DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                        id_alt = dr["ID_ALT"].ToString();

                    }
                }



                //MessageBox.Show("" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SelecionarDadosTabela();
            }
        }

        #endregion

        #region BOTOES 
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Alertas();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                TabelaAlt();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                Voltar();
            }
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Voltar();
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
                AtualizarTabela();
                //LimparCampos();
            }
        }

        private void LimparCampos(Control.ControlCollection control)
        {

        }

        private void ExcluirConta()
        {
            configdb database = new configdb();
            database.openConnection();

            try
            {
                /*
                // SAIDA DO CLA
                MySqlCommand objCmdSaidaCla = new MySqlCommand("insert into hypedb.saida_do_cla (id_saida_do_cla, data_saida, nick, level, poder, classe, patente, anotacao, nick_alt) values (null, ?, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

                objCmdSaidaCla.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;

                objCmdSaidaCla.ExecuteNonQuery();
                */

                /*
                // VERIFICA SE A CAIXA DE SELEÇÃO FOI SELECIONADA
                if (verificar == "True")
                {      
                    if (dataGridView1.SelectedRows.Count > 0)
                    {

                        // EXCLUIR ALT
                        MySqlCommand objCmdCadastroAlt = new MySqlCommand("delete from hypedb.cadastro_alt where ID_ALT in (@ID)", database.getConnection());
                        objCmdCadastroAlt.Parameters.AddWithValue("@ID", id);

                        objCmdCadastroAlt.ExecuteNonQuery();

                        DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                        id += dr["ID_ALT"].ToString().Replace("null", ",");

                    }
                }
               */

                if (verificar == "True")
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {

                        // EXCLUIR ALT
                        MySqlCommand objCmdCadastroAlt = new MySqlCommand("delete from hypedb.cadastro_alt where ID_ALT in (@ID)", database.getConnection());
                        objCmdCadastroAlt.Parameters.AddWithValue("@ID", teste);

                        objCmdCadastroAlt.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }

            database.closeConnection();
        }

        private void Voltar()
        {
            alts uc = new alts();
            cla.Instance.addControl(uc);
        }

        private void Salvar()
        {
            try
            {
                // BANCO DE DADOS
                configdb database = new configdb();
                database.openConnection();


                // CADASTRO DE MEMBROS
                MySqlCommand objCmdCadastroAlt = new MySqlCommand("update hypedb.cadastro_alt set nick_alt=@nick_alt, level_alt=@level_alt, classe_alt=@classe_alt, cla_alt=@cla_alt where (ID_ALT=@ID_ALT)", database.getConnection());

                objCmdCadastroAlt.Parameters.AddWithValue("@ID_ALT", id_alt);
                objCmdCadastroAlt.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
                objCmdCadastroAlt.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level.Texts;
                objCmdCadastroAlt.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
                objCmdCadastroAlt.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_cla.Texts;

                objCmdCadastroAlt.ExecuteNonQuery();

                DialogResult dr = MessageBox.Show("Editado Sucesso !", "Conta Alt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.closeConnection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        private void Alertas()
        {
            if (String.IsNullOrEmpty(txt_nick.Texts))
            {
                txt_nick.BorderColor = Color.Red;
                txt_nick.BorderSize = 1;
            }
            else if (String.IsNullOrEmpty(txt_level.Texts))
            {
                txt_level.BorderColor = Color.Red;
                txt_level.BorderSize = 1;
            }
            else if (String.IsNullOrEmpty(txt_cla.Texts))
            {
                txt_cla.BorderColor = Color.Red;
                txt_cla.BorderSize = 1;
            }
            else
            {
                try
                {
                    Salvar();
                }
                finally
                {
                    TabelaAlt();
                }
            }
        }

        #endregion

        private void conta_alt_Load(object sender, EventArgs e)
        {
            TabelaAlt();
            DadosMembros();

            dataGridView1.EnableHeadersVisualStyles = false;
        }


    }
}
