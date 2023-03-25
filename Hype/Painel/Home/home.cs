using Hype.Painel.Cadastro;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hype.script;
using System.Data;

namespace Hype.Painel.Home
{
    public partial class home : UserControl
    {
        public static home Instance;

        public bool _novoCla;

        public home()
        {
            InitializeComponent();

            Instance = this;
        }

        private void bt_novo_cla_Click(object sender, EventArgs e)
        {
            NovoCla();
        }

        public void NovoCla()
        {
            cadastro_cla uc = new cadastro_cla();
            cla.Instance.addControl(uc);

            _novoCla = true;
        }

        public void AtivarClas()
        {
            switch (dataGridView1.Rows.Count)
            {
                case 0:
                    break;
                case 1:
                    Cla_01();
                    break;
                case 2:
                    Cla_02();
                    break;
                case 3:
                    Cla_03();
                    break;

                default:
                    break;
            }
        }

        private void Cla_01()
        {
            txt_cla_01.Text = dataGridView1[0, 0].Value.ToString();

            bt_cla_01.Enabled = true;
        }

        private void Cla_02()
        {
            txt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            txt_cla_02.Text = dataGridView1[0, 1].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
        }

        private void Cla_03()
        {
            txt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            txt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            txt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void TabelaRecrutamento()
        {
            configdb database = new configdb();
            database.openConnection();

            // TABELA RECRUTAMENTO
            MySqlCommand cmd = new MySqlCommand("select foi_para_cla from hypedb.recrutamento", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            cmd.ExecuteNonQuery();
            database.closeConnection();

            AtivarClas();
        }

        private void home_Load(object sender, EventArgs e)
        {
            TabelaRecrutamento();
        }
    }
}
