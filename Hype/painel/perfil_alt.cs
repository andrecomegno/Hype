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
        public perfil_alt()
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
            txt_vai_cla_rema.Texts = membros.Instance.foi_para_cla;
        }
    }
}
