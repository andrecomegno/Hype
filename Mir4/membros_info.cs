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
using Mir4.painel;

namespace Mir4
{
    public partial class membros_info : Form
    {

        public membros_info()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;            
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
            Close();
        }

        public void DadosMembros()
        {
            lb_nick.Text = Mir4.painel.membros.nick;
            lb_patente.Text = Mir4.painel.membros.patente;
        }

        private void membros_info_Load(object sender, EventArgs e)
        {
            DadosMembros();
        }
    }
}
