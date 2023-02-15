using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hype.painel
{
    public partial class cadastro_alt : UserControl
    {
        public cadastro_alt()
        {
            InitializeComponent();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            alts uc = new alts();
            cla.Instance.addControl(uc);
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
