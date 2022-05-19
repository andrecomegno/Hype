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
    public partial class ouro : UserControl
    {
        public ouro()
        {
            InitializeComponent();
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

        private void bt_alts_Click(object sender, EventArgs e)
        {
            alts uc = new alts();
            cla.Instance.addControl(uc);
        }

        public void ListaMembros()
        {
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID, c.REMANEJAMENTO_ID, r.DATA_ENTRADA, r.DATA_SAIDA, c.NICK, c.LEVEL, c.PODER, c.CLASSE, c.PATENTE, r.VEM_DO_CLA, r.FOI_PARA_CLA from hypedb.cadastro_membro c join hypedb.remanejamento r on c.id = r.id", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();
        }

        private void ouro_Load(object sender, EventArgs e)
        {
            ListaMembros();
        }
    }
}
