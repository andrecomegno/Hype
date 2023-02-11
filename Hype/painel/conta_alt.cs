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


        public conta_alt()
        {
            InitializeComponent();

            txt_nick_principal.Texts = alts.Instance.nick_principal;
        }

        public void DadosMembros()
        {
            // ALT SELECIONADA - ALT.CS
            lb_data_entrada.Text = alts.Instance.data_entrada;   
            id_alt = alts.Instance.id_alt;
            txt_nick.Texts = alts.Instance.nick_alt;
            txt_level.Texts = alts.Instance.level_alt;
            txt_classe.Text = alts.Instance.classe_alt;
            txt_cla.Texts = alts.Instance.cla_alt;
        }

        private void TabelaCadastroAlt()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand objCmdCadastroAlt = new MySqlCommand("select DATA_ENTRADA, ID_ALT, NICK_PRINCIPAL, NICK_ALT, LEVEL_ALT, CLASSE_ALT, CLA_ALT from hypedb.cadastro_alt where NICK_PRINCIPAL like @NICK_PRINCIPAL '%' ", database.getConnection());

            objCmdCadastroAlt.Parameters.AddWithValue("@NICK_PRINCIPAL", txt_nick_principal.Texts);

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
            dataGridView1.Columns[2].HeaderText = "CONTA PRINCIPAL";
            dataGridView1.Columns[3].HeaderText = "NICK";
            dataGridView1.Columns[4].HeaderText = "LEVEL";
            dataGridView1.Columns[5].HeaderText = "CLASSE";
            dataGridView1.Columns[6].HeaderText = "CLÃ";

            dataGridView1.Columns["LEVEL_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "NICK_PRINCIPAL")
                    column.Width = 220;
                else if (column.DataPropertyName == "NICK_ALT")
                    column.Width = 220;
                else if (column.DataPropertyName == "LEVEL_ALT")
                    column.Width = 80;
                else if (column.DataPropertyName == "CLASSE_ALT")
                    column.Width = 100;
                else if (column.DataPropertyName == "CLA_ALT")
                    column.Width = 185;
            }
        }

        private void conta_alt_Load(object sender, EventArgs e)
        {
            TabelaCadastroAlt();
            DadosMembros();

            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarDadosTabela();
        }

        private void MostrarDadosTabela()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                    // CONTA PRINCIPAL
                    txt_nick_principal.Texts = dr["NICK_PRINCIPAL"].ToString();

                    // ALT
                    id_alt = dr["ID_ALT"].ToString();
                    txt_nick.Texts = dr["NICK_ALT"].ToString();
                    txt_level.Texts = dr["LEVEL_ALT"].ToString();
                    txt_classe.Text = dr["CLASSE_ALT"].ToString();
                    txt_cla.Texts = dr["CLA_ALT"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
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
                objCmdCadastroAlt.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe.Text;
                objCmdCadastroAlt.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_cla.Texts;

                objCmdCadastroAlt.ExecuteNonQuery();

                DialogResult dr = MessageBox.Show("Editado Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.closeConnection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                TabelaCadastroAlt();
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                TabelaCadastroAlt();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                BotaoVoltar();
            }
        }

        private void BotaoVoltar()
        {
            alts uc = new alts();
            cla.Instance.addControl(uc);
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            BotaoVoltar();
        }
    }
}
