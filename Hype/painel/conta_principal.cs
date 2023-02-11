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
    public partial class conta_principal : UserControl
    {
        string id_membro = string.Empty;
        string id_pergunta_alt = string.Empty;

        public conta_principal()
        {
            InitializeComponent();
            CampoTexto();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            BotaoVoltar();
        }

        private void BotaoVoltar()
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                // BANCO DE DADOS
                configdb database = new configdb();
                database.openConnection();


                // CADASTRO DE MEMBROS
                MySqlCommand objCmdCadastro_membros = new MySqlCommand("update hypedb.cadastro_membro set nick=@nick, classe=@classe, patente=@patente where (ID_MEMBROS=@ID_MEMBROS)", database.getConnection());

                objCmdCadastro_membros.Parameters.AddWithValue("@ID_MEMBROS", id_membro);
                objCmdCadastro_membros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
                objCmdCadastro_membros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Text;
                objCmdCadastro_membros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Text;

                objCmdCadastro_membros.ExecuteNonQuery();

                MySqlCommand objCmdAlt2 = new MySqlCommand("update hypedb.cadastro_alt set nick_principal=@nick_principal where (ID_PERGUNTA_ALT=@ID_PERGUNTA_ALT)", database.getConnection());

                objCmdAlt2.Parameters.AddWithValue("@ID_PERGUNTA_ALT", id_pergunta_alt);
                objCmdAlt2.Parameters.Add("@nick_principal", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;               

                objCmdAlt2.ExecuteNonQuery();

                MessageBox.Show(id_pergunta_alt);

                DialogResult dr = MessageBox.Show("Editado Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.closeConnection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                TabelaCadastroMembros();
            }            
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                TabelaCadastroMembros();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                BotaoVoltar();
            }

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            conta_excluir uc = new conta_excluir();
            cla.Instance.addControl(uc);
        }

        private void TabelaCadastroMembros()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand objCmdCadastro_membros = new MySqlCommand("select * from hypedb.cadastro_membro", database.getConnection());

            objCmdCadastro_membros.ExecuteNonQuery();

            database.closeConnection();
        }

        public void DadosMembros()
        {
            id_pergunta_alt = membros.Instance.id_pergunta_alt;

            // CADASTRO
            id_membro = membros.Instance.id_membro;
            lb_data_entrada.Text = membros.Instance.data_entrada;
            txt_nick.Texts = membros.Instance.nick;
            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Text = membros.Instance.patente;
            txt_classe.Text = membros.Instance.classe;
        }

        private void CampoTexto()
        {
            txt_level.Enabled = false;
            txt_poder.Enabled = false;

            txt_level.BackColor = Color.FromArgb(235, 235, 235);
            txt_poder.BackColor = Color.FromArgb(235, 235, 235);
        }

        private void conta_principal_Load(object sender, EventArgs e)
        {
            DadosMembros();
        }

    }
}
