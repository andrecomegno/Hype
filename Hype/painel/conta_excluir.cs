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

        string id_membro = string.Empty;

        public string id_alt = "";

        public string id_pergunta_alt = "";

        public string data_saida = "";
        public string nick_alt = "";
        public string level_alt = "";
        public string classe_alt = "";
        public string cla_alt = "";

        public conta_excluir()
        {
            InitializeComponent();

            txt_nick.Texts = "andy";
        }

        public void DadosMembros()
        {
            // CADASTRO
            id_membro = membros.Instance.id_membro;
            id_pergunta_alt = membros.Instance.id_pergunta_alt;

            //lb_data_saida.Text = DateTime.Now;  

            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Text = membros.Instance.patente;
            txt_classe.Text = membros.Instance.classe;
            txt_cla.Texts = membros.Instance.foi_para_cla;
        }

        private void ListaAlts()
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

        private void MostrarDadosTabela()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {                    
                    bool _selecionar = Convert.ToBoolean(row.Cells["SELECIONAR"].Value);
                    if (_selecionar)
                    {
                        id_alt += row.Cells["ID_ALT"].Value.ToString();
                        nick_alt += row.Cells["NICK_ALT"].Value.ToString();
                        level_alt += row.Cells["LEVEL_ALT"].Value.ToString();
                        classe_alt += row.Cells["CLASSE_ALT"].Value.ToString();
                        cla_alt += row.Cells["CLA_ALT"].Value.ToString();
                    }                    
                }

                MessageBox.Show(id_alt);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }


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
            try
            {
                configdb database = new configdb();
                database.openConnection();

                MySqlCommand objCmdRemanejamento = new MySqlCommand("delete from hypedb.remanejamento where ID_REMANEJAMENTO=@ID_REMANEJAMENTO", database.getConnection());
                objCmdRemanejamento.Parameters.AddWithValue("@ID_REMANEJAMENTO", id_membro);

                objCmdRemanejamento.ExecuteNonQuery();

                MySqlCommand objCmdContaAlt = new MySqlCommand("delete from hypedb.pergunta_alt where ID_ALT=@ID_ALT", database.getConnection());
                objCmdContaAlt.Parameters.AddWithValue("@ID_ALT", id_alt);

                objCmdContaAlt.ExecuteNonQuery();

                database.closeConnection();

                MostrarDadosTabela();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            BotaoVoltar();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            BotaoCancelar();
        }

        private void conta_excluir_Load(object sender, EventArgs e)
        {
            ListaAlts();
            DadosMembros();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;            
        }
    }
}
