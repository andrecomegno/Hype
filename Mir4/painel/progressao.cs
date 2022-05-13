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

namespace Mir4.painel
{
    public partial class co_progressao : UserControl
    {
        public co_progressao()
        {
            InitializeComponent();
        }

        public void addControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_progressao.Controls.Clear();
            pl_progressao.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void bt_membros_Click(object sender, EventArgs e)
        {
            membros uc = new membros();
            membros.Instance.addControl(uc);
        }

        private void bt_ouro_Click(object sender, EventArgs e)
        {

        }

        private void bt_alts_Click(object sender, EventArgs e)
        {

        }
    }
}
