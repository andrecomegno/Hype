using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hype.Painel;

namespace Hype.Painel
{
    public partial class configuracao : UserControl
    {
        public configuracao()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            cla.Instance.btPainel();
        }
    }
}
