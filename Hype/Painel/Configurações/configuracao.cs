using Hype.script;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Hype.Painel
{
    public partial class configuracao : UserControl
    {
        // DADOS
        private string id_login = login.Instance.id_login;
        private string usuario = login.Instance.usuario;

        public configuracao()
        {
            InitializeComponent();

            CampoDesativado();
        }

        #region BOTÃO
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Alertas();
        }

        private void SalvarEmail()
        {
            try
            {
                configdb database = new configdb();
                database.openConnection();

                // INSERT TABELA CADASTRO MEMBROS
                MySqlCommand objCmdLogin = new MySqlCommand("update hypedb.login set email=@email where (id_login=@id_login)", database.getConnection());

                objCmdLogin.Parameters.AddWithValue("@id_login", id_login);
                objCmdLogin.Parameters.Add("@email", MySqlDbType.VarChar, 256).Value = txt_email.Texts;

                objCmdLogin.ExecuteNonQuery();

                database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO INTERNO: " + ex, "ERRO INTERNO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SalvarSenha()
        {
            try
            {
                configdb database = new configdb();
                database.openConnection();

                // INSERT TABELA CADASTRO MEMBROS
                MySqlCommand objCmdLogin = new MySqlCommand("update hypedb.login set senha=@senha where (id_login=@id_login)", database.getConnection());

                objCmdLogin.Parameters.AddWithValue("@id_login", id_login);
                objCmdLogin.Parameters.Add("@senha", MySqlDbType.VarChar, 256).Value = txt_senha.Texts;

                objCmdLogin.ExecuteNonQuery();

                database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO INTERNO: " + ex, "ERRO INTERNO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region ALERTAS 
        private void Alertas()
        {
            // VERIFICA SE FOI PREENCHIDO O TEXTBOX
            if (txt_email.Texts != string.Empty || txt_email_conf.Texts != string.Empty)
            {
                // CONFIRMAÇÃO DO EMAIL
                if (txt_email.Texts != txt_email_conf.Texts)
                {
                    txt_email.BorderColor = Color.Red;
                    txt_email.BorderSize = 3;

                    txt_email_conf.BorderColor = Color.Red;
                    txt_email_conf.BorderSize = 3;
                }
                else
                {
                    // LIMPA O ERRO
                    txt_email.BorderSize = 1;
                    txt_email_conf.BorderSize = 1;
                    txt_email.BorderColor = Color.Transparent;
                    txt_email_conf.BorderColor = Color.Transparent;

                    // VERIFICA EMAIL
                    if (IsEmail(txt_email.Texts) == false)
                    {
                        MessageBox.Show("E-mail: seunome@email.com ", "E-Mail Invalido !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        try
                        {
                            SalvarEmail();
                        }
                        finally
                        {
                            MessageBox.Show("Novo E-Mail Salvo Com Sucesso !", "Novo E-Mail Salvo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            // VERIFICA SE FOI PREENCHIDO O TEXTBOX
            if (txt_senha.Texts != string.Empty || txt_senha_conf.Texts != string.Empty)
            {
                // CONFIRMAÇÃO DA SENHA
                if (txt_senha.Texts != txt_senha_conf.Texts)
                {
                    txt_senha_conf.BorderColor = Color.Red;
                    txt_senha_conf.BorderSize = 3;
                }
                else
                {
                    // LIMPA O ERRO
                    txt_senha.BorderSize = 1;
                    txt_senha_conf.BorderSize = 1;
                    txt_senha.BorderColor = Color.Transparent;
                    txt_senha_conf.BorderColor = Color.Transparent;

                    // VERIFICA SENHA MINIMA
                    if (txt_senha.Texts.Length < 6 || txt_senha.Texts.Length > 12)
                    {
                        MessageBox.Show("A Senha Tem Que Ter No Minimo 6 e No Máximo 12 Características", "Senha Invalida !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        try
                        {
                            SalvarSenha();
                        }
                        finally
                        {
                            MessageBox.Show("Nova Senha Salva Com Sucesso !", "Nova Senha Salva !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        #endregion

        #region CAMPO TEXTO
        private void CampoDesativado()
        {
            txt_usuario.Enabled = false;
            txt_usuario.BackColor = Color.LightGray;
            txt_usuario.Font = new Font(txt_usuario.Font, FontStyle.Bold);
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            txt_email.BorderSize = 1;
        }

        private void txt_email_conf_Enter(object sender, EventArgs e)
        {
            txt_email_conf.BorderSize = 1;
        }

        private void txt_senha_Enter(object sender, EventArgs e)
        {
            txt_senha.BorderSize = 1;
        }

        private void txt_senha_conf_Enter(object sender, EventArgs e)
        {
            txt_senha_conf.BorderSize = 1;
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            txt_email.BorderColor = Color.Transparent;
            txt_email.BorderSize = 0;
        }

        private void txt_email_conf_Leave(object sender, EventArgs e)
        {
            txt_email_conf.BorderColor = Color.Transparent;
            txt_email_conf.BorderSize = 0;
        }

        private void txt_senha_Leave(object sender, EventArgs e)
        {
            txt_senha.BorderColor = Color.Transparent;
            txt_senha.BorderSize = 0;
        }

        private void txt_senha_conf_Leave(object sender, EventArgs e)
        {
            txt_senha_conf.BorderColor = Color.Transparent;
            txt_senha_conf.BorderSize = 0;
        }
        #endregion

        // VERIFICA EMAIL
        private bool IsEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Dados()
        {
            txt_usuario.Texts = usuario;
        }

        private void configuracao_Load(object sender, EventArgs e)
        {
            Dados();
        }

    }
}
