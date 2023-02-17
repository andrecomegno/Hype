using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hype.Painel;
using Hype.script;
using MySql.Data.MySqlClient;

namespace Hype.Painel
{
    public partial class conta_principal : UserControl
    {
        string id_membro = string.Empty;
        string id_alt = string.Empty;

        public conta_principal()
        {
            InitializeComponent();
            CampoTextoDesativado();
        }

        #region BOTOES
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Alertas();
        } 

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarTabelas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                Voltar();
            }

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conta_excluir uc = new conta_excluir();
                cla.Instance.addControl(uc);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                AtualizarTabelas();
            }
        }

        private void Alertas()
        {
            // CADASTRO
            if (String.IsNullOrEmpty(txt_nick.Texts))
            {
                txt_nick.BorderColor = Color.Red;
                txt_nick.BorderSize = 1;
            }
            else if (txt_classe.SelectedIndex == 0)
            {
                txt_classe.BorderColor = Color.Red;
                txt_classe.BorderSize = 1;
            }
            else if (txt_patente.SelectedIndex == 0)
            {
                txt_patente.BorderColor = Color.Red;
                txt_patente.BorderSize = 1;
            }
            else 
            {
                try
                {
                    Salvar();
                }
                finally
                {
                    AtualizarTabelas();
                }
            }
        }

        private void Salvar()
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
                objCmdCadastro_membros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
                objCmdCadastro_membros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;

                objCmdCadastro_membros.ExecuteNonQuery();

                MySqlCommand objCmdAlt2 = new MySqlCommand("update hypedb.cadastro_alt set nick_principal=@nick_principal where (ID_ALT=@ID_ALT)", database.getConnection());

                objCmdAlt2.Parameters.AddWithValue("@ID_ALT", id_alt);
                objCmdAlt2.Parameters.Add("@nick_principal", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;

                objCmdAlt2.ExecuteNonQuery();

                DialogResult dr = MessageBox.Show("Editado Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.closeConnection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        private void Voltar()
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void CampoTextoDesativado()
        {
            txt_level.Enabled = false;
            txt_poder.Enabled = false;

            txt_level.BackColor = Color.FromArgb(235, 235, 235);
            txt_poder.BackColor = Color.FromArgb(235, 235, 235);
        }

        private void txt_nick_Leave(object sender, EventArgs e)
        {
            txt_nick.BorderColor = Color.Transparent;
            txt_nick.BorderSize = 0;
        }

        private void txt_classe_Leave(object sender, EventArgs e)
        {
            txt_classe.BorderColor = Color.Transparent;
            txt_classe.BorderSize = 0;
        }

        private void txt_patente_Leave(object sender, EventArgs e)
        {
            txt_patente.BorderColor = Color.Transparent;
            txt_patente.BorderSize = 0;
        }

        #endregion

        #region TABELAS
        private void AtualizarTabelas()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand objCmdCadastro_membros = new MySqlCommand("select * from hypedb.cadastro_membro", database.getConnection());

            objCmdCadastro_membros.ExecuteNonQuery();

            MySqlCommand objCmdCadastro_alt = new MySqlCommand("select * from hypedb.cadastro_alt", database.getConnection());

            objCmdCadastro_alt.ExecuteNonQuery();

            database.closeConnection();
        }

        public void DadosMembros()
        {
            // CADASTRO
            id_membro = membros.Instance.id_membro;
            lb_data_entrada.Text = membros.Instance.data_entrada;
            txt_nick.Texts = membros.Instance.nick;
            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Texts = membros.Instance.patente;
            txt_classe.Texts = membros.Instance.classe;

            // ALT
            id_alt = membros.Instance.id_alt;
        }
        #endregion

        private void conta_principal_Load(object sender, EventArgs e)
        {
            DadosMembros();
        }


    }
}
