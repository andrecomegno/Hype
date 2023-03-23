using Hype.Painel.Cadastro;
using System;
using System.Windows.Forms;

namespace Hype.Painel.Home
{
    public partial class home : UserControl
    {
        public static home Instance;

        public bool _novoCla;

        public home()
        {
            InitializeComponent();

            Instance = this;
        }

        private void bt_novo_cla_Click(object sender, EventArgs e)
        {
            NovoCla();
        }

        public void NovoCla()
        {
            cadastro_cla uc = new cadastro_cla();
            cla.Instance.addControl(uc);

            _novoCla = true;
        }

    }
}
