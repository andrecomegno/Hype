using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mir4.script;
using MySql.Data.MySqlClient;

namespace Mir4.painel
{
    public partial class membros : UserControl
    {
        public static membros Instance;

        public string id = "";
        public string nick = "";
        public string level = "";
        public string poder = "";
        public string classe = "";
        public string patente = "";
        public string data_entrada = "";
        public string data_saida = "";
        public string vem_do_cla = "";
        public string foi_para_cla = "";

        public membros()
        {
            InitializeComponent();

            Instance = this;
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

        private void bt_alts_Click(object sender, EventArgs e)
        {
            alts uc = new alts();
            cla.Instance.addControl(uc);
        }


        public void ListaMembros()
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select r.DATA_ENTRADA, r.DATA_SAIDA, c.NICK, c.LEVEL, c.PODER, c.CLASSE, c.PATENTE, r.VEM_DO_CLA, r.FOI_PARA_CLA from hypedb.cadastro_membro c join hypedb.remanejamento r on c.id = r.id", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();

            NomeDasTabelas();
        }

        public void NomeDasTabelas()
        {
            dataGridView1.Columns["DATA_ENTRADA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderText = "DATA ENTRADA";

            dataGridView1.Columns["DATA_SAIDA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "DATA SAIDA";

            dataGridView1.Columns[2].HeaderText = "NICK";

            dataGridView1.Columns["LEVEL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "LEVEL";

            dataGridView1.Columns["PODER"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "PODER";

            dataGridView1.Columns[5].HeaderText = "CLASSE";

            dataGridView1.Columns[6].HeaderText = "PATENTE";

            dataGridView1.Columns[7].HeaderText = "VEM DO CLA";

            dataGridView1.Columns[8].HeaderText = "FOI PARA CLA";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "DATA_ENTRADA")
                    column.Width = 120;
                else if (column.DataPropertyName == "FOI_PARA_CLA")
                    column.Width = 120;
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

                    data_entrada = ((DateTime)dr["DATA_ENTRADA"]).ToShortDateString();
                    //data_saida = dr["DATA_SAIDA"].ToString();
                    // data_remanejamento = dr["DATA_ENTRADA"].ToString();
                    nick = dr["NICK"].ToString();
                    level = dr["LEVEL"].ToString();
                    poder = dr["PODER"].ToString();
                    patente = dr["PATENTE"].ToString();
                    classe = dr["CLASSE"].ToString();
                    vem_do_cla = dr["VEM_DO_CLA"].ToString();
                    foi_para_cla = dr["FOI_PARA_CLA"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Código =/ de Erro Interno ", "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                membros_info mb = new membros_info();
                mb.ShowDialog();
            }

        }

        private void membros_Load(object sender, EventArgs e)
        {
            ListaMembros();
        }

        private void bt_add_membro_Click(object sender, EventArgs e)
        {
            add_membros uc = new add_membros();
            cla.Instance.addControl(uc);
        }
    }
}
