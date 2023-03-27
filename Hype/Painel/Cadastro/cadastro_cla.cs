using Hype.Painel.Home;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hype.Painel.Cadastro
{
    public partial class cadastro_cla : UserControl
    {
        public static cadastro_cla Instance;

        public cadastro_cla()
        {
            InitializeComponent();

            Instance = this;            
        }

        private void Alertas()
        {
            if (String.IsNullOrEmpty(txt_nick_lider.Texts))
            {
                txt_nick_lider.BorderColor = Color.Red;
                txt_nick_lider.BorderSize = 3;
            }
            else if (String.IsNullOrEmpty(txt_nome_cla.Texts))
            {
                txt_nome_cla.BorderColor = Color.Red;
                txt_nome_cla.BorderSize = 3;
            }
            else
            {
                try
                {
                    cadastro_membros uc = new cadastro_membros();
                    cla.Instance.addControl(uc);
                }
                finally
                {
                    // RECEBE OS VALORES E PASSA PARA O CADASTRO MEMBROS
                    cadastro_membros.Instance.CadastroCla(txt_nick_lider.Texts, txt_nome_cla.Texts);
                }
            }
        }

        #region BOTÕES
        private void bt_proximo_Click(object sender, EventArgs e)
        {
            Alertas();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            home uc = new home();
            cla.Instance.addControl(uc);
        }

        private void txt_nick_lider_Enter(object sender, EventArgs e)
        {
            txt_nick_lider.BorderSize = 1;
        }

        private void txt_nick_lider_Leave(object sender, EventArgs e)
        {
            txt_nick_lider.BorderColor = Color.Transparent;
            txt_nick_lider.BorderSize = 0;
        }

        private void txt_nome_cla_Enter(object sender, EventArgs e)
        {
            txt_nome_cla.BorderSize = 1;
        }

        private void txt_nome_cla_Leave(object sender, EventArgs e)
        {
            txt_nome_cla.BorderColor = Color.Transparent;
            txt_nome_cla.BorderSize = 0;
        }
        #endregion
    }
}
