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
    public partial class ouro : UserControl
    {
        public ouro()
        {
            InitializeComponent();
        }

        private void bt_membros_Click(object sender, EventArgs e)
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void bt_progressao_Click(object sender, EventArgs e)
        {
            progressao uc = new progressao();
            cla.Instance.addControl(uc);
        }

        private void bt_alts_Click(object sender, EventArgs e)
        {
            alts uc = new alts();
            cla.Instance.addControl(uc);
        }
    }
}
