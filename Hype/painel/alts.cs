using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hype.script;

namespace Hype.painel
{
    public partial class alts : UserControl
    {
        public static alts Instance;

        public string id_alt = "";
        public string data_entrada = "";
        public string nick_principal = "";
        public string nick_alt = "";
        public string level_alt = "";
        public string poder_alt = "";
        public string classe_alt = "";
        public string cla_alt = "";

        public alts()
        {
            InitializeComponent();
            Instance = this;

            txt_sem_dados.Visible = false;
            txt_clique_aqui.Visible = false;
        }

        #region TABELAS
        private void TabelaAlt()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select ID_ALT, DATA_ENTRADA, NICK_PRINCIPAL, NICK_ALT, LEVEL_ALT, CLASSE_ALT, CLA_ALT from hypedb.cadastro_alt", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                txt_sem_dados.Visible = true;
                txt_clique_aqui.Visible = true;

                dataGridView1.Visible = false;
            }
            else
            {
                txt_sem_dados.Visible = false;
                txt_clique_aqui.Visible = false;

                dataGridView1.Visible = true;
            }

            database.closeConnection();

            Tabela();
        }

        private void Tabela()
        {

            dataGridView1.Columns[0].Visible = false; // ID_ALT
            dataGridView1.Columns[1].HeaderText = "DATA ENTRADA";
            dataGridView1.Columns[2].Visible = false; // NICK_PRINCIPAL
            dataGridView1.Columns[3].HeaderText = "NICK";
            dataGridView1.Columns[4].HeaderText = "LEVEL";
            dataGridView1.Columns[5].HeaderText = "CLASSE";
            dataGridView1.Columns[6].HeaderText = "CLÃ";

            dataGridView1.Columns["DATA_ENTRADA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LEVEL_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "DATA_ENTRADA")
                    column.Width = 200;
                else if (column.DataPropertyName == "NICK_ALT")
                    column.Width = 350;
                else if (column.DataPropertyName == "LEVEL_ALT")
                    column.Width = 130;
                else if (column.DataPropertyName == "CLASSE_ALT")
                    column.Width = 150;
                else if (column.DataPropertyName == "CLA_ALT")
                    column.Width = 200;
            }

        }

        private void MostrarDadosTabela()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

                    id_alt = dr["ID_ALT"].ToString();
                    data_entrada = ((DateTime)dr["DATA_ENTRADA"]).ToShortDateString();
                    nick_principal = dr["NICK_PRINCIPAL"].ToString();
                    nick_alt = dr["NICK_ALT"].ToString();
                    level_alt = dr["LEVEL_ALT"].ToString();
                    classe_alt = dr["CLASSE_ALT"].ToString();
                    cla_alt = dr["CLA_ALT"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Interno" + erro + "ERRO FATAL");
            }
            finally
            {
                conta_alt uc = new conta_alt();
                cla.Instance.addControl(uc);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                MostrarDadosTabela();
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Cursor = Cursors.Hand;
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Cursor = Cursors.Default;
        }
        #endregion

        #region MENU TOP
        private void bt_membros_Click(object sender, EventArgs e)
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void bt_progressao_Click(object sender, EventArgs e)
        {

        }

        private void bt_ouro_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region CAMPO DE BUSCA
        private void bt_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txt_buscar__TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_buscar.Texts))
            {
                Buscar();
            }
        }       

        private void Buscar()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select DATA_ENTRADA, ID_ALT, NICK_PRINCIPAL, NICK_ALT, LEVEL_ALT, CLASSE_ALT, CLA_ALT from hypedb.cadastro_alt where nick_alt like @nick '%' ", database.getConnection());
            cmd.Parameters.AddWithValue("@nick", txt_buscar.Texts);

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();
        }
        #endregion

        #region BOTOES
        private void txt_clique_aqui_Click(object sender, EventArgs e)
        {
            cadastro_alt uc = new cadastro_alt();
            cla.Instance.addControl(uc);
        }

        private void bt_add_membro_Click(object sender, EventArgs e)
        {
            cadastro_alt uc = new cadastro_alt();
            cla.Instance.addControl(uc);
        }

        private void bt_add_membro_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bt_add_membro_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        #endregion

        private void alts_Load(object sender, EventArgs e)
        {
            TabelaAlt();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;

        }
    }
}
