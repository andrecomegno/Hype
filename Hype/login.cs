using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hype
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }

        private void bt_entrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                new cla().Show();
            }
            catch
            {

            }
            finally
            {
                
            }            
        }

        private void lb_novo_cad_Click(object sender, EventArgs e)
        {
            new criar_login().ShowDialog();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
