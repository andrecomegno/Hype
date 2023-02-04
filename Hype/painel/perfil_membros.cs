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
using MySql.Data.MySqlClient;

namespace Hype.painel
{
    public partial class perfil_membros : UserControl
    {
        string id_membro = string.Empty;
        string id_remanejamento = string.Empty;
        string id_recrutamento = string.Empty;

        string remanejamentos = string.Empty;

        public perfil_membros()
        {
            InitializeComponent();
        }

        public void DadosMembros()
        {
            // CADASTRO
            id_membro = membros.Instance.id_membro;
            id_remanejamento = membros.Instance.id_remanejamento;
            id_recrutamento = membros.Instance.id_recrutamento;
            lb_data_entrada.Text = membros.Instance.data_entrada;
            txt_nick.Texts = membros.Instance.nick;
            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Text = membros.Instance.patente;
            txt_classe.Text = membros.Instance.classe;
            txt_vem_do_cla.Texts = membros.Instance.vem_do_cla;
            txt_esta_cla.Texts = membros.Instance.foi_para_cla;

            // REMANEJAMENTO
            txt_esta_cla_rema.Texts = membros.Instance.esta_no_cla;
            //txt_vai_cla_rema.Texts = membros.Instance.esta_no_cla;

        }

        private void txt_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (txt_classe.SelectedIndex)
            {
                case 0:
                    foto_classe.Image = Resources.Arbalista;
                    break;
                case 1:
                    foto_classe.Image = Resources.Mago;
                    break;
                case 2:
                    foto_classe.Image = Resources.Guerreiro;
                    break;
                case 3:
                    foto_classe.Image = Resources.Lanceiro;
                    break;
                case 4:
                    foto_classe.Image = Resources.Taoista;
                    break;
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

            if(rd_sim.Checked == true)
            {
                // CADASTRO DE MEMBROS
                MySqlCommand objCmdCadastro_membros = new MySqlCommand("update cadastro_membro set classe=@classe, patente=@patente where (id=@id)", database.getConnection());

                objCmdCadastro_membros.Parameters.AddWithValue("@id", id_membro);
                objCmdCadastro_membros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Text;
                objCmdCadastro_membros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Text;

                objCmdCadastro_membros.ExecuteNonQuery();

                // RECRUTAMENTO
                MySqlCommand objCmdRecrutamento = new MySqlCommand("update recrutamento set  vem_do_cla=@vem_do_cla, foi_para_cla=@foi_para_cla", database.getConnection());

                objCmdRecrutamento.Parameters.AddWithValue("@id", id_remanejamento);
                objCmdRecrutamento.Parameters.Add("@vem_do_cla", MySqlDbType.VarChar, 256).Value = txt_vem_do_cla.Texts;
                objCmdRecrutamento.Parameters.Add("@foi_para_cla", MySqlDbType.VarChar, 256).Value = txt_esta_cla.Texts;

                objCmdRecrutamento.ExecuteNonQuery();

                // REMANEJAMENTOS
                MySqlCommand objCmdRemanejamento = new MySqlCommand("update remanejamento set data_remanejamento=@data_remanejamento, esta_no_cla=@esta_no_cla, vai_para_cla=@vai_para_cla where (id=@id) ", database.getConnection());

                objCmdRemanejamento.Parameters.AddWithValue("@id", id_remanejamento);
                objCmdRemanejamento.Parameters.Add("@data_remanejamento", MySqlDbType.Date).Value = DateTime.Now;
                objCmdRemanejamento.Parameters.Add("@esta_no_cla", MySqlDbType.VarChar, 256).Value = txt_vem_do_cla.Texts;
                objCmdRemanejamento.Parameters.Add("@vai_para_cla", MySqlDbType.VarChar, 256).Value = txt_esta_cla.Texts;

                // remanejamento.Parameters.AddWithValue("@progressao_id", progressao_id);

                objCmdRemanejamento.ExecuteNonQuery();
                
            }
            else
            {
                // CADASTRO DE MEMBROS
                MySqlCommand objCmdcadastro_membros = new MySqlCommand("update cadastro_membro set classe=@classe, patente=@patente where (id=@id)", database.getConnection());

                objCmdcadastro_membros.Parameters.AddWithValue("@id", id_membro);
                objCmdcadastro_membros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Text;
                objCmdcadastro_membros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Text;

                objCmdcadastro_membros.ExecuteNonQuery();
            } 

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
            membros.Instance.perfilMembros = false; // Limpa o formulario 
        }
    }
}
