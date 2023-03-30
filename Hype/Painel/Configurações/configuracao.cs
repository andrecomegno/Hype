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

 
        }

        // BOTÃO
        private void bt_salvar_Click(object sender, EventArgs e)
        {

        }

        #region CAMPO DO TEXTO EM BRANCO - ALERTAS 
        private void Alertas()
        {
            // LOGIN
            if (String.IsNullOrEmpty(txt_login.Texts))
            {
                txt.BorderColor = Color.Red;
                txt_login.BorderSize = 3;
            }
            else if (String.IsNullOrEmpty(txt_senha.Texts))
            {
                txt_senha.BorderColor = Color.Red;
                txt_senha.BorderSize = 3;
            }
            else
            {
                
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
        #endregion

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
