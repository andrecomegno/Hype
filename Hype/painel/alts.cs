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

        public string id_conta = "";
        public string nickMain = "";

        public string id_alt = "";
        public string data_entrada = "";
        public string nick_alt = "";
        public string level_alt = "";
        public string poder_alt = "";
        public string classe_alt = "";
        public string cla_alt = "";

        public string nick_alt_02 = "";

        public alts()
        {
            InitializeComponent();
            Instance = this;
        }

        private void ListaAlts()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select al.ID, c.ID, c.NICK, al.DATA_ENTRADA, al.NICK_ALT, al.LEVEL_ALT, al.PODER_ALT, al.CLASSE_ALT, al.CLA_ALT from hypedb.cadastro_membro c join hypedb.pergunta_alt p on p.ID = c.PERGUNTA_ALT_ID join hypedb.cadastro_alt al on al.PERGUNTA_ALT_ID = p.ID", database.getConnection());

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

            dataGridView1.Columns[0].Visible = false; // c.id ID Membros
            dataGridView1.Columns[1].Visible = false; // re.di ID Remanejamento
            dataGridView1.Columns[2].Visible = false; // p.id ID Pergunta Alt

            dataGridView1.Columns[3].HeaderText = "DATA ENTRADA";
            dataGridView1.Columns[4].HeaderText = "NICK";
            dataGridView1.Columns[5].HeaderText = "LEVEL";
            dataGridView1.Columns[6].HeaderText = "PODER";
            dataGridView1.Columns[7].HeaderText = "CLASSE";
            dataGridView1.Columns[8].HeaderText = "CLÃ";

            dataGridView1.Columns["DATA_ENTRADA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LEVEL_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["PODER_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "DATA_ENTRADA")
                    column.Width = 200;
                else if (column.DataPropertyName == "NICK_ALT")
                    column.Width = 220;
                else if (column.DataPropertyName == "LEVEL_ALT")
                    column.Width = 130;
                else if (column.DataPropertyName == "PODER_ALT")
                    column.Width = 130;
                else if (column.DataPropertyName == "CLASSE_ALT")
                    column.Width = 150;
                else if (column.DataPropertyName == "CLA_ALT")
                    column.Width = 200;
            }

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

                    id_alt = dr["ID"].ToString();
                    id_conta = dr["ID"].ToString();
                    nickMain = dr["NICK"].ToString();

                    data_entrada = ((DateTime)dr["DATA_ENTRADA"]).ToShortDateString();
                    nick_alt = dr["NICK_ALT"].ToString();
                    level_alt = dr["LEVEL_ALT"].ToString();
                    poder_alt = dr["PODER_ALT"].ToString();
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

        private void alts_Load(object sender, EventArgs e)
        {
            ListaAlts();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }
    }
}
