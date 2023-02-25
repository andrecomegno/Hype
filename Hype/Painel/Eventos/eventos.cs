using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hype.Painel.Eventos
{
    public partial class eventos : UserControl
    {
        public static eventos Instance;

        public eventos()
        {
            InitializeComponent();
            Instance = this;
        }

        #region MENU TOPO
        private void bt_membros_Click(object sender, EventArgs e)
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void bt_alts_Click(object sender, EventArgs e)
        {
            alts uc = new alts();
            cla.Instance.addControl(uc);
        }
        #endregion
    }
}
