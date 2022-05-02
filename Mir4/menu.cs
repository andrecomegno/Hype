using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mir4.painel;

namespace Mir4
{
    public partial class menu : Form
    {
        bool mouseDown;
        private Point offset;

        public menu()
        {
            InitializeComponent();

            aviso uc = new aviso();
            addControl(uc);
        }

        public void addControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            gp_zero.Controls.Clear();
            gp_zero.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {

        }

        private void lb_add_Click(object sender, EventArgs e)
        {
            novo_cla uc = new novo_cla();
            addControl(uc);
        }

        private void pl_top_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point po = PointToScreen(e.Location);
                Location = new Point(po.X - offset.X, po.Y - offset.Y);
            }
        }

        private void pl_top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
