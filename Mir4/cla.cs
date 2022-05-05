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
using Mir4.painel;

namespace Mir4
{
    public partial class cla : Form
    {
        public cla()
        {
            InitializeComponent();

            //RecolherMenu();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void bt_painel_Click(object sender, EventArgs e)
        {
            home uc = new home();
            addControl(uc);
        }

        private void bt_membros_Click(object sender, EventArgs e)
        {
            membros uc = new membros();
            addControl(uc);
        }

        private void bt_cadastro_Click(object sender, EventArgs e)
        {
            cadastro_membro uc = new cadastro_membro();
            addControl(uc);
        }

        private void bt_gold_Click(object sender, EventArgs e)
        {
            doacoes uc = new doacoes();
            addControl(uc);
        }

        public void addControl(UserControl userControl)
        {
            //if (this.pl_conteudo.Controls.Count > 0)
            //    this.pl_conteudo.Controls.RemoveAt(0);

            userControl.Dock = DockStyle.Fill;
            pl_conteudo.Controls.Clear();
            pl_conteudo.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void lb_add_Click(object sender, EventArgs e)
        {
            novo_cla uc = new novo_cla();
            addControl(uc);
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

        private void bt_configurar_Click(object sender, EventArgs e)
        {

        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            RecolherMenu();
        }

        private void RecolherMenu()
        {
            if (this.pl_menu.Width > 200)
            {
                pl_menu.Width = 60;
                foto_perfil.Visible = false;

                lb_patente.Visible = false;
                lb_nick.Visible = false;

                bt_deslogar.Visible = false;
                bt_menu.Dock = DockStyle.Left;
                bt_menu.Width = 60;

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
                foto_perfil.Visible = true;
                lb_patente.Visible = false;
                lb_nick.Visible = true;
                bt_deslogar.Visible = true;
                bt_menu.Dock = DockStyle.None;
                bt_menu.Width = 44;

                foreach (Button menuButton in pl_menu.Controls.OfType<Button>())
                {
                    menuButton.Text = "" + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }


    }
}
