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
using Mir4.painel;

namespace Mir4.painel
{
    public partial class membros : UserControl
    {

        public static string id = "";
        public static string nick = "";
        public static string patente = "";

        public static membros Instance;

        public membros()
        {
            InitializeComponent();

            Instance = this;
        }

        public void addControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_membros.Controls.Clear();
            pl_membros.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void bt_progressao_Click(object sender, EventArgs e)
        {
            co_progressao uc = new co_progressao();
            addControl(uc);
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


        private void bt_procurar_Click(object sender, EventArgs e)
        {

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
    }
}
