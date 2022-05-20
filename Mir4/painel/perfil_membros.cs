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
using Mir4.Properties;
using Mir4.painel;
using Mir4.script;
using MySql.Data.MySqlClient;

namespace Mir4.painel
{
    public partial class perfil_membros : UserControl
    {
        private string id_cad_mb = "";

        public perfil_membros()
        {
            InitializeComponent();
        }

        public void DadosMembros()
        {
            txt_data_entrada.Texts = membros.Instance.data_entrada;
            //membros.Instance.data_saida;
            //membros.Instance.data_remanejamento;
            txt_nick.Texts = membros.Instance.nick;
            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Text = membros.Instance.patente;
            txt_classe.Text = membros.Instance.classe;
            txt_veio_cla.Texts = membros.Instance.vem_do_cla;
            txt_esta_cla.Texts = membros.Instance.foi_para_cla;

            txt_esta_cla_rema.Texts = membros.Instance.foi_para_cla;
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
            database database = new database();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("update c.CLASSE, c.PATENTE, r.FOI_PARA_CLA from hypedb.cadastro_membro c join hypedb.remanejamento r on c.id = r.id", database.getConnection());

            cmd.Parameters.AddWithValue("@id", id_cad_mb);
            cmd.Parameters.Add("@CLASSE", MySqlDbType.VarChar, 256).Value = txt_classe.Text;
            cmd.Parameters.Add("@PATENTE", MySqlDbType.VarChar, 256).Value = txt_patente.Text;
            cmd.Parameters.Add("@FOI_PARA_CLA", MySqlDbType.VarChar, 256).Value = txt_vai_cla_rema.Texts;

            cmd.ExecuteNonQuery();
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
            membros_info.Instance.addControl(uc);
        }

        private void perfil_membros_Load(object sender, EventArgs e)
        {
            DadosMembros();
        }
    }
}
