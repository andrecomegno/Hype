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
                    Cla_01(nome_cla);
                    break;
                case 2:
                    Cla_02(nome_cla);
                    break;
            }
        }

        private void Cla_01(string nome)
        {
            /*
            bt_cla_01.Text = dataGridView1[1, 0].Value.ToString();

            bt_cla_01.Enabled = true;
            bt_cla_01.IconChar = IconChar.Edit;
            bt_cla_01.BackColor = Color.DarkGoldenrod;  
            */

            bt_cla_01.Text = nome;
            bt_cla_01.Enabled = true;
            bt_cla_01.IconChar = IconChar.Edit;
            bt_cla_01.BackColor = Color.DarkGoldenrod;
        }



        private void Cla_02(string nome)
        {
            //bt_cla_01.Text = dataGridView1[1, 0].Value.ToString();
            //bt_cla_02.Text = dataGridView1[1, 1].Value.ToString();

            bt_cla_02.Text = nome;
            bt_cla_02.Enabled = true;
            bt_cla_02.IconChar = IconChar.Edit;
            bt_cla_02.BackColor = Color.DarkGoldenrod;
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
                nome_cla = dr["nome_cla"].ToString();
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

        // MENU BOTÖES
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // EDITAR CLA
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Tem Certeza Que Deseja Sair ?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (dr)
            {
                case DialogResult.Yes:
                    DeletarCla();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void DeletarCla()
        {
            // EXCLUIR CLA
            try
            {                
                configdb database = new configdb();
                database.openConnection();

                MySqlCommand objCmdCla = new MySqlCommand("delete from hypedb.cadastro_cla where (id_login=@id_login) and (id_cla=@id_cla)", database.getConnection());
                objCmdCla.Parameters.AddWithValue("@id_login", id_login);
                objCmdCla.Parameters.AddWithValue("@id_cla", id_cla);

                objCmdCla.ExecuteNonQuery();

                database.closeConnection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                // LIMPAR O BOTAO CLA
            }
        }
        #endregion

        private void home_Load(object sender, EventArgs e)
        {
            Dados();
            TabelaCla();            
        }


    }
}
