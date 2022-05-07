using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mir4
{
    public partial class login : Form
    {

        bool mouseDown;
        private Point offset;

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

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point po = PointToScreen(e.Location);
                Location = new Point(po.X - offset.X, po.Y - offset.Y);
            }
        }

        private void login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
