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

        // BOTÃO CLÃ
        private IconButton bt_cla;

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
            }
        }

        private void Cla_01()
        {
            bt_cla_01.Text = dataGridView1[2, 0].Value.ToString();
            Clas(bt_cla_01);
        }

        private void Cla_02()
        {
            bt_cla_02.Text = dataGridView1[2, 1].Value.ToString();
            Clas(bt_cla_02);

            Cla_01();
        }

        private void Cla_03()
        {
            bt_cla_03.Text = dataGridView1[2, 2].Value.ToString();
            Clas(bt_cla_03);

            Cla_01();
            Cla_02();
        }

        private void Cla_04()
        {
            bt_cla_04.Text = dataGridView1[2, 3].Value.ToString();
            Clas(bt_cla_04);

            Cla_01();
            Cla_02();
            Cla_03();
        }

        private void Cla_05()
        {
            bt_cla_05.Text = dataGridView1[2, 4].Value.ToString();
            Clas(bt_cla_05);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
        }

        private void Cla_06()
        {
            bt_cla_06.Text = dataGridView1[2, 5].Value.ToString();
            Clas(bt_cla_06);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
        }

        private void Cla_07()
        {
            bt_cla_07.Text = dataGridView1[2, 6].Value.ToString();
            Clas(bt_cla_07);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
        }

        private void Cla_08()
        {
            bt_cla_08.Text = dataGridView1[2, 7].Value.ToString();
            Clas(bt_cla_08);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
        }

        private void Cla_09()
        {
            bt_cla_09.Text = dataGridView1[2, 8].Value.ToString();
            Clas(bt_cla_09);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
        }

        private void Cla_10()
        {
            bt_cla_10.Text = dataGridView1[2, 9].Value.ToString();
            Clas(bt_cla_10);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
            Cla_09();
        }

        private void Cla_11()
        {
            bt_cla_11.Text = dataGridView1[2, 10].Value.ToString();
            Clas(bt_cla_11);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
            Cla_09();
            Cla_10();
        }

        private void Cla_12()
        {
            bt_cla_12.Text = dataGridView1[2, 11].Value.ToString();
            Clas(bt_cla_12);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
            Cla_09();
            Cla_10();
            Cla_11();
        }

        private void Cla_13()
        {
            bt_cla_13.Text = dataGridView1[2, 12].Value.ToString();
            Clas(bt_cla_13);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
            Cla_09();
            Cla_10();
            Cla_11();
            Cla_12();
        }

        private void Cla_14()
        {
            bt_cla_14.Text = dataGridView1[2, 13].Value.ToString();
            Clas(bt_cla_14);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
            Cla_09();
            Cla_10();
            Cla_11();
            Cla_12();
            Cla_13();
        }

        private void Cla_15()
        {
            bt_cla_15.Text = dataGridView1[2, 14].Value.ToString();
            Clas(bt_cla_15);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
            Cla_09();
            Cla_10();
            Cla_11();
            Cla_12();
            Cla_13();
            Cla_14();
        }

        private void Cla_16()
        {
            bt_cla_16.Text = dataGridView1[2, 15].Value.ToString();
            Clas(bt_cla_16);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
            Cla_09();
            Cla_10();
            Cla_11();
            Cla_12();
            Cla_13();
            Cla_14();
            Cla_15();
        }

        private void Cla_17()
        {
            bt_cla_17.Text = dataGridView1[2, 16].Value.ToString();
            Clas(bt_cla_17);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
            Cla_09();
            Cla_10();
            Cla_11();
            Cla_12();
            Cla_13();
            Cla_14();
            Cla_15();
            Cla_16();
        }

        private void Cla_18()
        {
            bt_cla_18.Text = dataGridView1[2, 17].Value.ToString();
            Clas(bt_cla_18);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
            Cla_09();
            Cla_10();
            Cla_11();
            Cla_12();
            Cla_13();
            Cla_14();
            Cla_15();
            Cla_16();
            Cla_17();
        }

        private void Cla_19()
        {
            bt_cla_19.Text = dataGridView1[2, 18].Value.ToString();
            Clas(bt_cla_19);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
            Cla_09();
            Cla_10();
            Cla_11();
            Cla_12();
            Cla_13();
            Cla_14();
            Cla_15();
            Cla_16();
            Cla_17();
            Cla_18();
        }

        private void Cla_20()
        {
            bt_cla_20.Text = dataGridView1[2, 19].Value.ToString();
            Clas(bt_cla_20);

            Cla_01();
            Cla_02();
            Cla_03();
            Cla_04();
            Cla_05();
            Cla_06();
            Cla_07();
            Cla_08();
            Cla_09();
            Cla_10();
            Cla_11();
            Cla_12();
            Cla_13();
            Cla_14();
            Cla_15();
            Cla_16();
            Cla_17();
            Cla_18();
            Cla_19();
        }
        #endregion

        #region TABELA
        // COMPARAR OS ID`S PARA CADA CONTA DE LOGIN CRIADA 
        private void TabelaCla()
        {
            configdb database = new configdb();
            database.openConnection();

            // TABELA CADASTRO CLA
            MySqlCommand cmd = new MySqlCommand("select id_cla, nick_lider, nome_cla, id_login from hypedb.cadastro_cla where id_login = '"+ id_login +"' ", database.getConnection());
            
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
            MySqlCommand objCmdLogin = new MySqlCommand("select id_cla, nick_lider, nome_cla, id_login from hypedb.cadastro_cla where id_login = '" + id_login + "' ", database.getConnection());            

            // COLETA O ID_CLA DA TABELA CADASTRO_CLA
            MySqlDataReader dr = objCmdLogin.ExecuteReader();
            while (dr.Read())
            {
                id_cla = dr["id_cla"].ToString();
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

        private void bt_cla_01_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                // MOUSE ESQUERDO
                case MouseButtons.Left:
                    nome_cla = bt_cla_01.Text; // NOME DO CLÃ
                    cla.Instance.btDashboard(); // VAI PARA O DASHBOARD
                    break;
                // MOUSE DIREITO
                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 0].Value.ToString(); // ID DO CLÃ
                    bt_cla = bt_cla_01; // PASSA O ID_CLA PARA O BT_CLA
                    break;
            }
        }

        private void bt_cla_02_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_02.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 1].Value.ToString();
                    bt_cla = bt_cla_02;
                    break;
            }
        }

        private void bt_cla_03_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_03.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 2].Value.ToString();
                    bt_cla = bt_cla_03;
                    break;
            }
        }

        private void bt_cla_04_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_04.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 3].Value.ToString();
                    bt_cla = bt_cla_04;
                    break;
            }
        }

        private void bt_cla_05_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_05.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 4].Value.ToString();
                    bt_cla = bt_cla_05;
                    break;
            }
        }

        private void bt_cla_06_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_06.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 5].Value.ToString();
                    bt_cla = bt_cla_06;
                    break;
            }
        }

        private void bt_cla_07_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_07.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 6].Value.ToString();
                    bt_cla = bt_cla_07;
                    break;
            }
        }

        private void bt_cla_08_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_08.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 7].Value.ToString();
                    bt_cla = bt_cla_08;
                    break;
            }
        }

        private void bt_cla_09_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_09.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 8].Value.ToString();
                    bt_cla = bt_cla_09;
                    break;
            }
        }

        private void bt_cla_10_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_10.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 9].Value.ToString();
                    bt_cla = bt_cla_10;
                    break;
            }
        }

        private void bt_cla_11_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_11.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 10].Value.ToString();
                    bt_cla = bt_cla_11;
                    break;
            }
        }

        private void bt_cla_12_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_12.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 11].Value.ToString();
                    bt_cla = bt_cla_12;
                    break;
            }
        }

        private void bt_cla_13_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_13.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 12].Value.ToString();
                    bt_cla = bt_cla_13;
                    break;
            }
        }

        private void bt_cla_14_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_14.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 13].Value.ToString();
                    bt_cla = bt_cla_14;
                    break;
            }
        }

        private void bt_cla_15_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_15.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 14].Value.ToString();
                    bt_cla = bt_cla_15;
                    break;
            }
        }

        private void bt_cla_16_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_16.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 15].Value.ToString();
                    bt_cla = bt_cla_16;
                    break;
            }
        }

        private void bt_cla_17_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_17.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 16].Value.ToString();
                    bt_cla = bt_cla_17;
                    break;
            }
        }

        private void bt_cla_18_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_18.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 17].Value.ToString();
                    bt_cla = bt_cla_18;
                    break;
            }
        }

        private void bt_cla_19_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_19.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 18].Value.ToString();
                    bt_cla = bt_cla_19;
                    break;
            }
        }

        private void bt_cla_20_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nome_cla = bt_cla_20.Text;
                    cla.Instance.btDashboard();
                    break;

                case MouseButtons.Right:
                    id_cla = dataGridView1[0, 19].Value.ToString();
                    bt_cla = bt_cla_20;
                    break;
            }
        }
        #endregion

        #region EDITAR
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // EDITAR CLA
        }
        #endregion

        #region DELETAR
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem Certeza Que Deseja Excluir ?", "EXCLUIR CLÃ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
            // EXCLUIR CLÃ
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
                DeletarBotao(bt_cla);
            }
        }
        #endregion

        // HABILITAR BOTÃO CLÃ
        private void Clas(IconButton bt)
        {
            bt.Enabled = true;
            bt.IconChar = IconChar.Edit;
            bt.BackColor = Color.DarkGoldenrod;
        }

        // DESABILITAR BOTÃO DELETADO
        private void DeletarBotao(IconButton bt)
        {            
            bt.IconChar = IconChar.AccessibleIcon;
            bt.BackColor = Color.FromArgb(24, 25, 28);
            bt.Text = string.Empty;
            bt.Enabled = false;
        }

        // BOTÕES CLÃ INICIAR DESABILITADOS
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

        private void home_Load(object sender, EventArgs e)
        {
            Dados();
            TabelaCla();            
        }


    }
}
