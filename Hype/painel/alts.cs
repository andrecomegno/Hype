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

        public string nickMain = "";

        public string id_alt = "";
        public string data_entrada = "";
        public string nick = "";
        public string level = "";
        public string poder = "";
        public string classe = "";
        public string esta_no_cla = "";

        public alts()
        {
            InitializeComponent();
            Instance = this;
        }

        public void ListaAlts()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select al.ID, al.DATA, al.NICK_ALT, al.LEVEL_ALT, al.PODER_ALT, al.CLASSE_ALT, al.CLA, c.NICK from hypedb.cadastro_membro c join hypedb.pergunta_alt p on p.ID = c.PERGUNTA_ALT_ID join hypedb.alt al on al.PERGUNTA_ALT_ID = p.ID", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

            }

            database.closeConnection();

            Tabela();
        }

        public void Tabela()
        {
            dataGridView1.Columns[0].Visible = false; // al.id ID Membros
            dataGridView1.Columns[1].HeaderText = "DATA ENTRADA";
            dataGridView1.Columns[2].HeaderText = "NICK";
            dataGridView1.Columns[3].HeaderText = "LEVEL";
            dataGridView1.Columns[4].HeaderText = "PODER";
            dataGridView1.Columns[5].HeaderText = "CLASSE";
            dataGridView1.Columns[6].HeaderText = "CLÃ";
            dataGridView1.Columns[7].Visible = false; // al.CLA Clã

            dataGridView1.Columns["DATA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LEVEL_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["PODER_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "DATA_ENTRADA")
                    column.Width = 200;
                else if (column.DataPropertyName == "NICK")
                    column.Width = 220;
                else if (column.DataPropertyName == "LEVEL")
                    column.Width = 130;
                else if (column.DataPropertyName == "PODER")
                    column.Width = 130;
                else if (column.DataPropertyName == "CLASSE")
                    column.Width = 150;
                else if (column.DataPropertyName == "CLÃ")
                    column.Width = 200;
            }

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarDadosTabela();
        }

        public void MostrarDadosTabela()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

                    id_alt = dr["ID"].ToString();

                    data_entrada = ((DateTime)dr["DATA"]).ToShortDateString();
                    nick = dr["NICK"].ToString();
                    level = dr["LEVEL"].ToString();
                    poder = dr["PODER"].ToString();
                    classe = dr["CLASSE"].ToString();
                    esta_no_cla = dr["CLA"].ToString();
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
            progressao uc = new progressao();
            cla.Instance.addControl(uc);
        }

        private void bt_ouro_Click(object sender, EventArgs e)
        {
            ouro uc = new ouro();
            cla.Instance.addControl(uc);
        }

        private void alts_Load(object sender, EventArgs e)
        {
            ListaAlts();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }

    }
}
