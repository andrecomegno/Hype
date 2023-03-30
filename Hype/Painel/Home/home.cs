using Hype.Painel.Cadastro;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hype.script;
using System.Data;
using System.Drawing;
using FontAwesome.Sharp;

namespace Hype.Painel.Home
{
    public partial class home : UserControl
    {
        public static home Instance;

        // ID`S
        private string id_login = login.Instance.id_login;

        // COLETAR DADOS
        public string id_cla;
        public string nick_lider;
        public string nome_cla;        

        // NOVO CLA 
        public bool _novoCla;

        public home()
        {
            InitializeComponent();

            Instance = this;

            BotoesCla(pl_nome_clas.Controls);            
        }

        #region LISTA CLÃ
        public void HabilitarClas()
        {
            switch (dataGridView1.Rows.Count)
            {
                case 1:
                    Cla_01();
                    break;
                case 2:
                    Cla_02();
                    break;
                case 3:
                    Cla_03();
                    break;
                case 4:
                    Cla_04();
                    break;
                case 5:
                    Cla_05();
                    break;
                case 6:
                    Cla_06();
                    break;
                case 7:
                    Cla_07();
                    break;
                case 8:
                    Cla_08();
                    break;
                case 9:
                    Cla_09();
                    break;
                case 10:
                    Cla_10();
                    break;
                case 11:
                    Cla_11();
                    break;
                case 12:
                    Cla_12();
                    break;
                case 13:
                    Cla_13();
                    break;
                case 14:
                    Cla_14();
                    break;
                case 15:
                    Cla_15();
                    break;
                case 16:
                    Cla_16();
                    break;
                case 17:
                    Cla_17();
                    break;
                case 18:
                    Cla_18();
                    break;
                case 19:
                    Cla_19();
                    break;
                case 20:
                    Cla_20();
                    break;

                default:
                    break;
            }
        }

        private void Cla_01()
        {
            bt_cla_01.Text = dataGridView1[1, 0].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_01.IconChar = IconChar.Edit;
            bt_cla_01.BackColor = Color.DarkGoldenrod;            
        }

        private void Cla_02()
        {
            bt_cla_01.Text = dataGridView1[1, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[1, 1].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_01.IconChar = IconChar.Edit;
            bt_cla_01.BackColor = Color.DarkGoldenrod;

            bt_cla_02.Enabled = true;
            bt_cla_02.IconChar = IconChar.Edit;
            bt_cla_02.BackColor = Color.DarkGoldenrod;
        }

        private void Cla_03()
        {
            bt_cla_01.Text = dataGridView1[1, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[1, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[1, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_01.IconChar = IconChar.Edit;
            bt_cla_01.BackColor = Color.DarkGoldenrod;

            bt_cla_02.Enabled = true;
            bt_cla_02.IconChar = IconChar.Edit;
            bt_cla_02.BackColor = Color.DarkGoldenrod;

            bt_cla_03.Enabled = true;
            bt_cla_03.IconChar = IconChar.Edit;
            bt_cla_03.BackColor = Color.DarkGoldenrod;
        }

        private void Cla_04()
        {
            bt_cla_01.Text = dataGridView1[1, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[1, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[1, 2].Value.ToString();
            bt_cla_04.Text = dataGridView1[1, 3].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_01.IconChar = IconChar.Edit;
            bt_cla_01.BackColor = Color.DarkGoldenrod;

            bt_cla_02.Enabled = true;
            bt_cla_02.IconChar = IconChar.Edit;
            bt_cla_02.BackColor = Color.DarkGoldenrod;

            bt_cla_03.Enabled = true;
            bt_cla_03.IconChar = IconChar.Edit;
            bt_cla_03.BackColor = Color.DarkGoldenrod;

            bt_cla_04.Enabled = true;
            bt_cla_04.IconChar = IconChar.Edit;
            bt_cla_04.BackColor = Color.DarkGoldenrod;
        }

        private void Cla_05()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_06()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_07()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_08()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_09()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_10()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_11()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_12()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_13()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_14()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_15()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_16()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_17()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_18()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_19()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }

        private void Cla_20()
        {
            bt_cla_01.Text = dataGridView1[0, 0].Value.ToString();
            bt_cla_02.Text = dataGridView1[0, 1].Value.ToString();
            bt_cla_03.Text = dataGridView1[0, 2].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_02.Enabled = true;
            bt_cla_03.Enabled = true;
        }
        #endregion

        #region TABELA
        // COMPARAR OS ID`S PARA CADA CONTA DE LOGIN CRIADA 
        private void TabelaCla()
        {
            configdb database = new configdb();
            database.openConnection();

            // TABELA CADASTRO CLA
            MySqlCommand cmd = new MySqlCommand("select nick_lider, nome_cla, id_login from hypedb.cadastro_cla where id_login = '"+ id_login +"' ", database.getConnection());
            
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();

            HabilitarClas();
        }

        private void Dados()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            // TABELA CADASTRO CLA
            MySqlCommand objCmdLogin = new MySqlCommand("select id_cla, nick_lider, nome_cla, id_login from hypedb.cadastro_cla  where id_login = '" + id_login + "' ", database.getConnection());            

            // COLETA O ID_CLA DA TABELA CADASTRO_CLA
            MySqlDataReader dr = objCmdLogin.ExecuteReader();
            while (dr.Read())
            {
                id_cla = dr["id_cla"].ToString();
            }

            database.closeConnection();
        }
        #endregion

        #region BOTÕES
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
        
        private void bt_cla_01_Click(object sender, EventArgs e)
        {
            nome_cla = bt_cla_01.Text;
            cla.Instance.btDashboard();
        }

        private void bt_cla_02_Click(object sender, EventArgs e)
        {
            nome_cla = bt_cla_02.Text;
            cla.Instance.btDashboard();
        }

        private void BotoesCla(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is IconButton)
                {
                    ((IconButton)(c)).Enabled = false;
                    ((IconButton)(c)).IconChar = IconChar.AccessibleIcon;
                }
            }
        }
        #endregion

        private void home_Load(object sender, EventArgs e)
        {
            TabelaCla();

            Dados();
        }
    }
}
