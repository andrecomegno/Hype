using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mir4
{
    public partial class Membros : Form
    {
        public Membros()
        {
            InitializeComponent();
        }

        private void bt_procurar_Click(object sender, EventArgs e)
        {
            detalhes_membros dm = new detalhes_membros();
            dm.Show();

        }
    }
}
