using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mir4.painel
{
    public partial class membros_detalhes : UserControl
    {
        public membros_detalhes()
        {
            InitializeComponent();
        }

        public void addControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_conteudo.Controls.Clear();
            pl_conteudo.Controls.Add(userControl);
            userControl.BringToFront();
            
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            doacoes uc = new doacoes();
            addControl(uc);
        }
    }
}
