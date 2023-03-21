using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hype
{
    public partial class login : Form
    {
        public static login Instance;

        public bool _novoCad;

        public login()
        {
            InitializeComponent();

            Instance = this;
        }

        #region BOTÕES
        private void bt_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                new cla().Show();
            }
            catch
            {
                // BANCO DE DADOS 
            }
            finally
            {
                
            }            
        }

        // NOVO CADASTRO
        private void lb_novo_cad_Click(object sender, EventArgs e)
        {
            _novoCad = true;

            new cla().Show();
        }

        private void lb_novo_cad_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lb_novo_cad_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        // FECHAR JANELA
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

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
