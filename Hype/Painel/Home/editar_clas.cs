using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hype.Painel.Home
{
    public partial class editar_clas : UserControl
    {
        public editar_clas()
        {
            InitializeComponent();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            //SALVAR
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            lista_clas uc = new lista_clas();
            home.Instance.addControl(uc);
        }

        private void editar_clas_Load(object sender, EventArgs e)
        {
            //CARREGAR DADOS
        }
    }
}
