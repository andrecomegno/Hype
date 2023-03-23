using System;
using System.Windows.Forms;

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
            if (dataGridView1.Rows.Count == 0)
            {
                cla.Instance.Home();
            }
            else
            {
                cla.Instance.btPainel();
            }
                
        }
    }
}
