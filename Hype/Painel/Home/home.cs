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

        // ID`S
        private string id_login = login.Instance.id_login;

        // NOVO CLA 
        public bool _novoCla;

        public home()
        {
            InitializeComponent();
            Instance = this;

            ClasHome();
        }

        #region TABELA
        // COMPARAR OS ID`S PARA CADA CONTA DE LOGIN CRIADA 
        private void TabelaCla()
        {
            configdb database = new configdb();
            database.openConnection();

            // TABELA CADASTRO CLA
            MySqlCommand cmd = new MySqlCommand("select id_cla, nick_lider, nome_cla, id_login from hypedb.cadastro_cla where id_login = '" + id_login + "' ", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();
        }
        #endregion

        #region BOTÃO CLÃ
        private void bt_novo_cla_Click(object sender, EventArgs e)
        {
            NovoCla();
        }

        public void NovoCla()
        {
            if (dataGridView1.Rows.Count < 20)
            {
                cadastro_cla uc = new cadastro_cla();
                cla.Instance.addControl(uc);
                _novoCla = true;
            }
            else
            {
                MessageBox.Show("Limite De Clã Máximo !", "LIMITE DE CLÃ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }
        #endregion

        private void ClasHome()
        {
            lista_clas uc = new lista_clas();
            addControl(uc);
        }

        public void addControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_conteudo.Controls.Clear();
            pl_conteudo.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void home_Load(object sender, EventArgs e)
        {
            //Dados();
            TabelaCla();
        }


    }
}
