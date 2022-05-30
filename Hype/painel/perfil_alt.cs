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
    public partial class perfil_alt : UserControl
    {
        string id = string.Empty;
        public string cla_rema = string.Empty;

        public perfil_alt()
        {
            InitializeComponent();
        }

        public void DadosAlts()
        {
            lb_data_entrada.Text = alts.Instance.data_entrada;
            id = alts.Instance.id;
            txt_nick.Texts = alts.Instance.nick;
            txt_level.Texts = alts.Instance.level;
            txt_poder.Texts = alts.Instance.poder;
            txt_classe.Text = alts.Instance.classe;
            lb_nick_main.Text = alts.Instance.nickMain;
            txt_esta_cla.Texts = alts.Instance.esta_no_cla;

            // REMANEJAMENTO
            txt_esta_cla_rema.Texts = alts.Instance.esta_no_cla;
            txt_vai_cla_rema.Texts = cla_rema;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            informacao.Instance.FecharJanela();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            membro_excluir uc = new membro_excluir();
            informacao.Instance.addControl(uc);
        }

        private void perfil_alt_Load(object sender, EventArgs e)
        {
            DadosAlts();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

        }

        private void rd_sim_CheckedChanged(object sender, EventArgs e)
        {
            pl_remanejamento.Visible = true;
            txt_data_rema.Texts = DateTime.Now.Date.ToShortDateString();
        }

        private void rd_nao_CheckedChanged(object sender, EventArgs e)
        {
            pl_remanejamento.Visible = false;
            txt_data_rema.Texts = string.Empty;
        }
    }
}
