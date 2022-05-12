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
    public partial class Teste : Form
    {
        public static string nick = "";

        public Teste()
        {
            InitializeComponent();
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

        private void Teste_Load(object sender, EventArgs e)
        {
            ListaMembros();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

                //id = dr["ID"].ToString();
                //txt_produto.Text = dr["NOME"].ToString();

                nick = dr["NICK"].ToString();

                MessageBox.Show(nick);

                membros_info mb = new membros_info();
                mb.Show();

            }
        }
    }
}
