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
using Hype.painel;

namespace Hype
{
    public partial class cla : Form
    {
        public static cla Instance;

        public cla()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            Instance = this;
        }

        // MENU RECOLHER
        private void bt_menu_Click(object sender, EventArgs e)
        {
            MenuPrincipal();
        }

        private void MenuPrincipal()
        {
            if (this.pl_menu.Width > 200)
            {
                pl_menu.Width = 60;
                lb_nick.Visible = false;

                bt_inicio.Visible = false;
                bt_menu.Dock = DockStyle.Left;
                bt_menu.Width = 60;

                bt_menu.IconChar = IconChar.AngleRight;

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
                bt_menu.Dock = DockStyle.None;
                bt_menu.Width = 44;

                bt_menu.IconChar = IconChar.AngleLeft;

                foreach (Button menuButton in pl_menu.Controls.OfType<Button>())
                {
                    menuButton.Text = "" + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        // BOTÃO DO INICIO DO PAINEL MOVER
        private void bt_configurar_Click(object sender, EventArgs e)
        {
            configuracao uc = new configuracao();
            addControl(uc);
        }

        private void bt_inicio_Click(object sender, EventArgs e)
        {
            
        }

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

        private void bt_painel_Click(object sender, EventArgs e)
        {
            bt_painel.BackColor = Color.CornflowerBlue;
            bt_membros.BackColor = Color.LightSlateGray;

            inicio uc = new inicio();
            addControl(uc);
        }

        private void bt_membros_Click(object sender, EventArgs e)
        {
            bt_membros.BackColor = Color.CornflowerBlue;
            bt_painel.BackColor = Color.LightSlateGray;

            membros uc = new membros();
            addControl(uc);
        }

        public void addControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_conteudo.Controls.Clear();
            pl_conteudo.Controls.Add(userControl);
            userControl.BringToFront();
        }

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
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
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

        //PAINEL CONTA MENU
        private void foto_perfil_Click(object sender, EventArgs e)
        {
            pl_conta.Visible = false;

            configuracao uc = new configuracao();
            addControl(uc);
        }

        private void bt_config_Click(object sender, EventArgs e)
        {
            pl_conta.Visible = false;

            configuracao uc = new configuracao();
            addControl(uc);
        }

    }
}
