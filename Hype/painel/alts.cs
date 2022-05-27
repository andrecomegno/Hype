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
        public bool perfilAlt = false;

        public string id = "";
        public string data_entrada = "";
        public string nick = "";
        public string level = "";
        public string poder = "";
        public string classe = "";
        public string foi_para_cla = "";

        public alts()
        {
            InitializeComponent();
            Instance = this;
        }

        public void ListaAlts()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select al.id, al.DATA, al.NICK, al.LEVEL, al.PODER, al.CLASSE, al.CLA, c.NICK from hypedb.cadastro_membro c join hypedb.expedicao e on e.ID = c.EXPEDICAO_ID join hypedb.pergunta_alt p on p.ID = c.PERGUNTA_ALT_ID join hypedb.alt al on al.PERGUNTA_ALT_ID = p.ID", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();

            Tabela();
        }

        public void Tabela()
        {
            dataGridView1.Columns[0].Visible = false; // ID
            dataGridView1.Columns[1].Visible = false; // DATA ENTRADA

            dataGridView1.Columns[2].HeaderText = "NICK";
            dataGridView1.Columns[3].HeaderText = "LEVEL";
            dataGridView1.Columns[4].HeaderText = "PODER";
            dataGridView1.Columns[5].HeaderText = "CLASSE";
            dataGridView1.Columns[6].HeaderText = "CLA";
            dataGridView1.Columns[7].HeaderText = "NICK MAIN";

            dataGridView1.Columns["LEVEL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["PODER"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "DATA")
                    column.Width = 200;
                else if (column.DataPropertyName == "NICK")
                    column.Width = 220;
                else if (column.DataPropertyName == "LEVEL")
                    column.Width = 130;
                else if (column.DataPropertyName == "PODER")
                    column.Width = 130;
                else if (column.DataPropertyName == "CLASSE")
                    column.Width = 150;
                else if (column.DataPropertyName == "CLA")
                    column.Width = 150;
                else if (column.DataPropertyName == "NICK1") // NICK DA ALT
                    column.Width = 220;
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

                    id = dr["ID"].ToString();
                    data_entrada = ((DateTime)dr["DATA_ENTRADA"]).ToShortDateString();
                    nick = dr["NICK"].ToString();
                    level = dr["LEVEL"].ToString();
                    poder = dr["PODER"].ToString();
                    classe = dr["CLASSE"].ToString();
                    foi_para_cla = dr["FOI_PARA_CLA"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Erro Interno", "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                perfilAlt = true;

                informacao mb = new informacao();
                mb.ShowDialog();
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
