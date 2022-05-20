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
using Mir4.painel;
using Mir4.script;
using MySql.Data.MySqlClient;

namespace Mir4.painel
{
    public partial class membro_excluir : UserControl
    {
        public membro_excluir()
        {
            InitializeComponent();
        }

        public void DadosMembros()
        {
            txt_nick.Texts = membros.Instance.nick;
            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Texts = membros.Instance.patente;
            txt_classe.Texts = membros.Instance.classe;
            txt_data_excluir.Texts = DateTime.Now.Date.ToShortDateString();
        }


        private void membro_excluir_Load(object sender, EventArgs e)
        {
            DadosMembros();            
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            perfil_membros uc = new perfil_membros();
            membros_info.Instance.addControl(uc);
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            //BANCO DE DADOS
        }
    }
}
