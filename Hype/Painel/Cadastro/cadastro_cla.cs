using Hype.Painel.Home;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hype.Painel.Cadastro
{
    public partial class cadastro_cla : UserControl
    {
        public static cadastro_cla Instance;

        public string nick_lider;
        //public string nome_cla;


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
                    nick_lider = txt_nick_lider.Texts;
                    //nome_cla = txt_nome_cla.Texts;

                    MessageBox.Show("CLA " + nick_lider);
                }
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
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
    }
}
