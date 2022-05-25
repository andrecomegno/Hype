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
        public alts()
        {
            InitializeComponent();
        }

        public void ListaAlts()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select al.ID, al.DATA, al.NICK, al.LEVEL, al.PODER, al.CLASSE, al.CLA, c.NICK from cadastro_membro c join remanejamento r on c.REMANEJAMENTO_ID = r.ID join pergunta_alt p on p.ID = c.PERGUNTA_ALT_ID join alt al on al.PERGUNTA_ALT_ID = p.ID", database.getConnection());

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
