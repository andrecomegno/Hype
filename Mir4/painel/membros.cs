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
        public string patente = "";

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

            MySqlCommand cmd = new MySqlCommand("select * from cadastro_membro", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }

            database.closeConnection();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

                    nick = dr["NICK"].ToString();
                    patente = dr["PATENTE"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
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
