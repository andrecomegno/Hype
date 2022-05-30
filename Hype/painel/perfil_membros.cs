using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Hype.Properties;
using Hype.painel;
using Hype.script;

namespace Hype.painel
{
    public partial class perfil_membros : UserControl
    {
        string id = string.Empty;
        public string cla_rema = string.Empty;

        public perfil_membros()
        {
            InitializeComponent();           
        }

        public void DadosMembros()
        {
            id = membros.Instance.id;
            lb_data_entrada.Text = membros.Instance.data_entrada;
            txt_nick.Texts = membros.Instance.nick;
            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Text = membros.Instance.patente;
            txt_classe.Text = membros.Instance.classe;
            txt_veio_cla.Texts = membros.Instance.vem_do_cla;
            txt_esta_cla.Texts = membros.Instance.foi_para_cla;

            // REMANEJAMENTO
            txt_esta_cla_rema.Texts = membros.Instance.foi_para_cla;
            txt_vai_cla_rema.Texts = cla_rema;
        }

        private void txt_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe.SelectedIndex == 0)
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
        
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            EditarCadastroMembro();

            //ATUALIZAR A LISTA DE MEMBROS
            membros.Instance.ListaMembros();
        }

        private void EditarCadastroMembro()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();



            database.closeConnection();

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

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            membro_excluir uc = new membro_excluir();
            informacao.Instance.addControl(uc);
        }

        private void perfil_membros_Load(object sender, EventArgs e)
        {
            DadosMembros();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            informacao.Instance.FecharJanela();
        }
    }
}
