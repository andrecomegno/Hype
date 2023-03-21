using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Hype.Painel;
using Hype.Painel.Eventos;
using Hype.Painel.Cadastro;
using MySql.Data.MySqlClient;
using Hype.script;
using Hype.Painel.Home;

namespace Hype
{
    public partial class cla : Form
    {
        public static cla Instance;

        public bool _novoCad = login.Instance._novoCad;

        public cla()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            Instance = this;

            NovoCla();

            CadastroLogin(_novoCad);
        }

        private void NovoCla()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select id_membros from hypedb.cadastro_membro", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();

            if (dataGridView1.Rows.Count == 0)
            {
                bt_home.Visible = true;
                bt_home.Location = new Point(0, 40);
                bt_configuracao.Location = new Point(0, 92);

                bt_dashboard.Visible = false;
                bt_membros.Visible = false;
                bt_eventos.Visible = false;

                Home();
            }
            else
            {
                bt_home.Visible = false;
                bt_home.Location = new Point(0, 267);
                bt_configuracao.Location = new Point(0, 196);

                btPainel();
            }

        }

        public void Home()
        {
            home uc = new home();
            addControl(uc);
        }

        public void CadastroLogin(bool _novo)
        {
            if(_novo)
            {
                pl_menu.Visible = false;
                bt_menu_conta.Visible = false;

                cadastro_login uc = new cadastro_login();
                addControl(uc);                               
            }
            else
            {
                pl_menu.Visible = true;
                bt_menu_conta.Visible = true;

                home uc = new home();
                addControl(uc);
            }
        }

        #region MENU LATERAL
        //BOTÃO PAINEL
        private void bt_home_Click(object sender, EventArgs e)
        {
            btHome();
        }

        public void btHome()
        {
            bt_home.BackColor = Color.CornflowerBlue;
            bt_configuracao.BackColor = Color.LightSlateGray;

            home uc = new home();
            addControl(uc);
        }

        private void bt_dashboard_Click(object sender, EventArgs e)
        {
            btPainel();
        }

        public void btPainel()
        {
            bt_dashboard.BackColor = Color.CornflowerBlue;

            bt_membros.BackColor = Color.LightSlateGray;
            bt_eventos.BackColor = Color.LightSlateGray;
            bt_configuracao.BackColor = Color.LightSlateGray;

            dashboard uc = new dashboard();
            addControl(uc);
        }

        //BOTÃO MEMBROS
        private void bt_membros_Click(object sender, EventArgs e)
        {
            btMembros();
        }

        public void btMembros()
        {
            bt_membros.BackColor = Color.CornflowerBlue;

            bt_eventos.BackColor = Color.LightSlateGray;
            bt_configuracao.BackColor = Color.LightSlateGray;
            bt_dashboard.BackColor = Color.LightSlateGray;

            membros uc = new membros();
            addControl(uc);
        }

        //BOTÃO EVENTOS
        private void bt_eventos_Click(object sender, EventArgs e)
        {
            btEventos();
        }

        public void btEventos()
        {
            bt_eventos.BackColor = Color.CornflowerBlue;

            bt_membros.BackColor = Color.LightSlateGray;
            bt_configuracao.BackColor = Color.LightSlateGray;
            bt_dashboard.BackColor = Color.LightSlateGray;

            eventos uc = new eventos();
            addControl(uc);
        }

        //BOTÃO CONFIGURAÇÕES
        private void bt_configuracao_Click(object sender, EventArgs e)
        {
            btConfiguracao();
        }

        public void btConfiguracao()
        {
            bt_configuracao.BackColor = Color.CornflowerBlue;

            bt_home.BackColor = Color.LightSlateGray;
            bt_membros.BackColor = Color.LightSlateGray;
            bt_eventos.BackColor = Color.LightSlateGray;
            bt_dashboard.BackColor = Color.LightSlateGray;            

            configuracao uc = new configuracao();
            addControl(uc);
        }

        // BOTÃO RECOLHER
        private void bt_menu_recolher_Click(object sender, EventArgs e)
        {
            MenuPrincipal();
        }

        // BOTÃO CONFIGURAÇÃO
        private void bt_configurar_Click(object sender, EventArgs e)
        {
            btConfiguracao();
        }

        //  BOTÃO HOME
        private void bt_inicio_Click(object sender, EventArgs e)
        {

        }

        // RECOLHER MENU LATERAL
        private void MenuPrincipal()
        {
            if (this.pl_menu.Width > 200)
            {
                pl_menu.Width = 60;
                lb_nick.Visible = false;

                bt_inicio.Visible = false;
                bt_menu_recolher.Dock = DockStyle.Left;
                bt_menu_recolher.Width = 60;

                bt_menu_recolher.IconChar = IconChar.AngleRight;

                foreach (Button menuButton in pl_menu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
            else
            {
                pl_menu.Width = 210;
                bt_inicio.Visible = true;
                bt_menu_recolher.Dock = DockStyle.None;
                bt_menu_recolher.Width = 44;

                bt_menu_recolher.IconChar = IconChar.AngleLeft;

                foreach (Button menuButton in pl_menu.Controls.OfType<Button>())
                {
                    menuButton.Text = "" + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        #endregion

        #region MENU FLUTUANTE
        private void bt_menu_conta_Click(object sender, EventArgs e)
        {
            MenuConta();
        }

        private void MenuConta()
        {
            this.pl_conta.BringToFront();

            if (pl_conta.Visible == true)
            {
                pl_conta.Visible = false;
            }
            else
            {
                pl_conta.Visible = true;
            }
        }

        private void foto_perfil_Click(object sender, EventArgs e)
        {
            pl_conta.Visible = false;

            configuracao uc = new configuracao();
            addControl(uc);
        }

        private void bt_config_Click(object sender, EventArgs e)
        {
            pl_conta.Visible = false;

            btConfiguracao();
        }
        #endregion

        #region MENU JANELA
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;                
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }                
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        public void addControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_conteudo.Controls.Clear();
            pl_conteudo.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void cla_Load(object sender, EventArgs e)
        {
            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }
    }
}
