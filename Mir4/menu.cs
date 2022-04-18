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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bt_cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                cadastro ca = new cadastro();
                ca.Show();
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void bt_membros_Click(object sender, EventArgs e)
        {
            try
            {
                membros me = new membros();
                me.Show();
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void bt_controle_Click(object sender, EventArgs e)
        {
            try
            {
                controle co = new controle();
                co.Show();
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void bt_relatorio_Click(object sender, EventArgs e)
        {
            try
            {
                relatorio re = new relatorio();
                re.Show();
            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}
