using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mir4.Properties;

namespace Mir4.painel
{
    public partial class add_membros : UserControl
    {
        public add_membros()
        {
            InitializeComponent();
        }

        public void RadioSelecao()
        {
            if (rd_nao.Checked == true)
                txt_quantidade_alt.SelectedIndex = 0;
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void rd_sim_CheckedChanged(object sender, EventArgs e)
        {
            txt_quantidade_alt.Enabled = true;

            txt_quantidade_alt.SelectedIndex = 1;
        }

        private void rd_nao_CheckedChanged(object sender, EventArgs e)
        {
            txt_quantidade_alt.Enabled = false;

            pl_alt_0.Visible = false;
            pl_alt_1.Visible = false;

            txt_quantidade_alt.SelectedIndex = 0;
        }

        private void txt_quantidade_alt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_quantidade_alt.SelectedIndex == 1)
            {
                pl_alt_0.Visible = true;
                pl_alt_1.Visible = false;
            }
            else if (txt_quantidade_alt.SelectedIndex == 2)
            {
                pl_alt_0.Visible = true;
                pl_alt_1.Visible = true;
            }
            else
            {
                pl_alt_0.Visible = false;
                pl_alt_1.Visible = false;

                txt_quantidade_alt.SelectedIndex = 0;
            }
        }

        private void add_membros_Load(object sender, EventArgs e)
        {
            RadioSelecao();
            pl_botao.Dock = DockStyle.Top;
        }

        private void txt_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe.SelectedIndex == 0 )
            {
                foto_classe.Image = Resources.Arbalista;

            }
            else if (txt_classe.SelectedIndex == 1)
            {
                foto_classe.Image = Resources.Mago;
            }
            else if (txt_classe.SelectedIndex == 2)
            {
                foto_classe.Image = Resources.Guerreiro;
            }
            else if (txt_classe.SelectedIndex == 3)
            {
                foto_classe.Image = Resources.Lanceiro;
            }
            else if (txt_classe.SelectedIndex == 4)
            {
                foto_classe.Image = Resources.Taoista;
            }
        }

        private void txt_classe_alt_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe_alt_0.SelectedIndex == 0)
            {
                foto_classe_alt_0.Image = Resources.Arbalista;
            }
            else if (txt_classe_alt_0.SelectedIndex == 1)
            {
                foto_classe_alt_0.Image = Resources.Mago;
            }
            else if (txt_classe_alt_0.SelectedIndex == 2)
            {
                foto_classe_alt_0.Image = Resources.Guerreiro;
            }
            else if (txt_classe_alt_0.SelectedIndex == 3)
            {
                foto_classe_alt_0.Image = Resources.Lanceiro;
            }
            else if (txt_classe_alt_0.SelectedIndex == 4)
            {
                foto_classe_alt_0.Image = Resources.Taoista;
            }
        }

        private void txt_classe_alt_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe_alt_1.SelectedIndex == 0)
            {
                foto_classe_alt_1.Image = Resources.Arbalista;
            }
            else if (txt_classe_alt_1.SelectedIndex == 1)
            {
                foto_classe_alt_1.Image = Resources.Mago;
            }
            else if (txt_classe_alt_1.SelectedIndex == 2)
            {
                foto_classe_alt_1.Image = Resources.Guerreiro;
            }
            else if (txt_classe_alt_1.SelectedIndex == 3)
            {
                foto_classe_alt_1.Image = Resources.Lanceiro;
            }
            else if (txt_classe_alt_1.SelectedIndex == 4)
            {
                foto_classe_alt_1.Image = Resources.Taoista;
            }
        }


    }
}
