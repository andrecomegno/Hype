using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hype.painel;
using Hype.script;
using MySql.Data.MySqlClient;

namespace Hype.painel
{
    public partial class membros_perfil : UserControl
    {

        string id_membro = string.Empty;
        string id_remanejamento = string.Empty;
        string id_recrutamento = string.Empty;

        public membros_perfil()
        {
            InitializeComponent();
                        
            ControleDosCampos();
            bt();
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
            txt_patente.Texts = membros.Instance.patente;
            txt_classe.Texts = membros.Instance.classe;

            // ALT

            // REMANEJAMENTO
            txt_vem_do_cla.Texts = membros.Instance.vem_do_cla;
            txt_remanejamento.Texts = membros.Instance.esta_no_cla;

        }

        // BOTÃO MENU
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        // BOTÕES CONTA PRINCIPAL
        private void bt_salvar_conta_Click(object sender, EventArgs e)
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            try
            {
                // CADASTRO DE MEMBROS
                MySqlCommand objCmdCadastro_membros = new MySqlCommand("update cadastro_membro set nick=@nick, classe=@classe, patente=@patente where (id=@id)", database.getConnection());

                objCmdCadastro_membros.Parameters.AddWithValue("@id", id_membro);
                objCmdCadastro_membros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Text;
                objCmdCadastro_membros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Text;
                objCmdCadastro_membros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Text;

                objCmdCadastro_membros.ExecuteNonQuery();

                DialogResult dr = MessageBox.Show("Editado Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                DadosMembros();

                bt_editar_conta.Visible = true;

                bt_salvar_conta.Visible = false;
                bt_excluir_conta.Visible = false;
                bt_cancelar_conta.Visible = false;               

                CampoDesabilitar(this.pl_conta_principal.Controls);
                CampoTextoCinza(this.pl_conta_principal.Controls);
            }

            database.closeConnection();
        }

        private void bt_editar_conta_Click(object sender, EventArgs e)
        {
            conta_principal uc = new conta_principal();
            cla.Instance.addControl(uc);

            /*
            try
            {
                bt_editar_conta.Visible = false;

                bt_salvar_conta.Visible = true;
                bt_excluir_conta.Visible = true;
                bt_cancelar_conta.Visible = true;
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                txt_nick.Enabled = true;
                txt_level.Enabled = false;
                txt_poder.Enabled = false;

                CampoHabilitar(this.pl_conta_principal.Controls);
                CampoTextoBranco(this.pl_conta_principal.Controls);
            }
            */
        }

        private void bt_cancelar_conta_Click(object sender, EventArgs e)
        {
            try
            {
                bt_editar_conta.Visible = true;

                bt_salvar_conta.Visible = false;
                bt_excluir_conta.Visible = false;
                bt_cancelar_conta.Visible = false;

                DadosMembros();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                CampoDesabilitar(this.pl_conta_principal.Controls);
                CampoTextoCinza(this.pl_conta_principal.Controls);
            }


        }

        private void bt_excluir_conta_Click(object sender, EventArgs e)
        {
            bt_editar_conta.Visible = true;

            bt_excluir_conta.Visible = false;
            bt_salvar_conta.Visible = false;
            bt_cancelar_conta.Visible = false;

            CampoDesabilitar(this.pl_conta_principal.Controls);
            CampoTextoCinza(this.pl_conta_principal.Controls);
        }

        // BOTÕES CONTA ALT
        private void bt_salvar_alt_01_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_conta_alt_01_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_alt_01_Click(object sender, EventArgs e)
        {

        }

        private void bt_excluir_alt_01_Click(object sender, EventArgs e)
        {

        }

        private void bt_salvar_alt_02_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_conta_alt_02_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_alt_02_Click(object sender, EventArgs e)
        {

        }

        private void bt_excluir_alt_02_Click(object sender, EventArgs e)
        {

        }

        // BOTÕES REMANEJAMENTO
        private void bt_salvar_rema_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_rema_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_rema_Click(object sender, EventArgs e)
        {

        }

        private void bt_excluir_rema_Click(object sender, EventArgs e)
        {

        }

        // BOTÕES HABILITAR/DESABILITAR
        private void bt()
        {
            // BOTÕES EDITAR EXCLUIR CANCELAR SALVAR
            bt_editar_conta.Visible = true;
            bt_cancelar_alt_01.Visible = true;

            bt_excluir_conta.Visible = false;
            bt_excluir_alt_01.Visible = false;
            bt_excluir_rema.Visible = false;

            bt_salvar_conta.Visible = false;
            bt_salvar_alt_01.Visible = false;
            bt_salvar_rema.Visible = false;

            bt_cancelar_conta.Visible = false;
            bt_cancelar_alt_01.Visible = false;
            bt_cancelar_rema.Visible = false;
        }

        private void ControleDosCampos()
        {
            CampoTextoCinza(this.pl_conta_principal.Controls);
            CampoTextoCinza(this.pl_conta_alt_01.Controls);
            CampoTextoCinza(this.pl_remanejamento.Controls);

            CampoDesabilitar(this.pl_conta_principal.Controls);
            CampoDesabilitar(this.pl_conta_alt_01.Controls);
            CampoDesabilitar(this.pl_remanejamento.Controls);
        }

        private void CampoTextoCinza(Control.ControlCollection control)
        {            
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)c).BackColor = Color.FromArgb(235, 235, 235);
                }
            }
        }

        private void CampoTextoBranco(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)c).BackColor = Color.White;
                }
            }
        }

        public void CampoDesabilitar(Control.ControlCollection control)
        {

            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)c).Enabled = false;
                }
            }

            foreach (Control c in control)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).Enabled = false;
                }
            }
        }

        public void CampoHabilitar(Control.ControlCollection control)
        {

            foreach (Control c in control)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).Enabled = true;
                }
            }
        }

        private void membros_perfil_Load(object sender, EventArgs e)
        {
            DadosMembros();
        }


    }
}
