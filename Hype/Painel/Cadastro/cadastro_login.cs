using System;
using System.Drawing;
using System.Windows.Forms;
using Hype.script;
using MySql.Data.MySqlClient;

namespace Hype.Painel.Cadastro
{
    public partial class cadastro_login : UserControl
    {
        public static cadastro_login Instance;

        public cadastro_login()
        {
            InitializeComponent();

            Instance = this;
        }

        #region ALERTAS
        private void Alertas()
        {
            // LOGIN
            if (String.IsNullOrEmpty(txt_login.Texts))
            {
                txt_login.BorderColor = Color.Red;
                txt_login.BorderSize = 3;
            }
            // CARACTERES MINIMO
            else if (txt_login.Texts.Length < 6 || txt_senha.Texts.Length > 12)
            {
                MessageBox.Show("Login Minimo De 6 Ou No Máximo 12 Características", "Senha Invalida !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
            // EMAIL
            else if (String.IsNullOrEmpty(txt_email.Texts))
            {
                txt_email.BorderColor = Color.Red;
                txt_email.BorderSize = 3;
            }
            else if (String.IsNullOrEmpty(txt_email_conf.Texts))
            {
                txt_email_conf.BorderColor = Color.Red;
                txt_email_conf.BorderSize = 3;
            }
            // CONFIRMAÇÃO DO EMAIL
            else if (txt_email.Texts != txt_email_conf.Texts)
            {
                txt_email.BorderColor = Color.Red;
                txt_email.BorderSize = 3;

                txt_email_conf.BorderColor = Color.Red;
                txt_email_conf.BorderSize = 3;
            }
            // VERIFICAR EMAIL
            else if (IsEmail(txt_email.Texts) == false)
            {
                MessageBox.Show("E-mail: seunome@email.com ", "E-Mail Invalido !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
            // SENHA
            else if (String.IsNullOrEmpty(txt_senha.Texts))
            {
                txt_senha.BorderColor = Color.Red;
                txt_senha.BorderSize = 3;
            }
            else if (String.IsNullOrEmpty(txt_senha_conf.Texts))
            {
                txt_senha_conf.BorderColor = Color.Red;
                txt_senha_conf.BorderSize = 3;
            }
            // CONFIRMAÇÃO DA SENHA
            else if (txt_senha.Texts != txt_senha_conf.Texts)
            {
                txt_senha_conf.BorderColor = Color.Red;
                txt_senha_conf.BorderSize = 3;
            }
            // VERIFICA SENHA
            else if (txt_senha.Texts.Length < 6 || txt_senha.Texts.Length > 12)
            {
                MessageBox.Show("A Senha Tem Que Ter No Minimo 6 e No Máximo 12 Características", "Senha Invalida !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Salvar();
            }
        }
        #endregion

        #region BOTÃO
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem Certeza Que Deseja Sair ?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (dr)
            {
                case DialogResult.Yes:
                    cla.Instance.Close();
                    break;
                case DialogResult.No:

                    break;
                default:
                    break;
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Alertas();
        }

        private void Salvar()
        {
            try
            {
                configdb database = new configdb();
                database.openConnection();

                // TABELA CADASTRO LOGIN
                MySqlCommand objCmdLogin = new MySqlCommand("select usuario from hypedb.login where usuario like '" + txt_login.Texts + "' '%' ", database.getConnection());

                var cad = objCmdLogin.ExecuteScalar();

                if (cad != null)
                {
                    try
                    {
                        MessageBox.Show("Login Já Existe !", "AVISO !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        txt_login.BorderColor = Color.Red;
                        txt_login.BorderSize = 3;
                    }                    
                }
                else
                {
                    try
                    {
                        // INSERT TABELA CADASTRO MEMBROS
                        MySqlCommand cmd = new MySqlCommand("insert into hypedb.login (id_login, usuario, email, senha) values (null, ?, ?, ?)", database.getConnection());

                        cmd.Parameters.Add("@usuario", MySqlDbType.VarChar, 256).Value = txt_login.Texts;
                        cmd.Parameters.Add("@email", MySqlDbType.VarChar, 256).Value = txt_email.Texts;
                        cmd.Parameters.Add("@senha", MySqlDbType.VarChar, 256).Value = txt_senha.Texts;

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Novo Login Criado Com Sucesso !", "NOVO LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        // DEPOIS DO CADASTRO FECHAR A JANELA, PARA FAZER O LOGIN 
                        cla.Instance.Close();
                    }                  
                }

                database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO INTERNO: " + ex, "ERRO INTERNO !", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }          
        }
        #endregion

        #region CAMPO TEXTO
        private void txt_login_Enter(object sender, EventArgs e)
        {
            txt_login.BorderSize = 1;
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

        private void txt_login_Leave(object sender, EventArgs e)
        {
            txt_login.BorderColor = Color.Transparent;
            txt_login.BorderSize = 0;
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
    }
}
