using Hype.Painel.Cadastro;
using System;
using System.Windows.Forms;

namespace Hype.Painel.Home
{
    public partial class home : UserControl
    {
        public static home Instance;

        public bool _novoCla;

        private int _clas = 0;

        public home()
        {
            InitializeComponent();

            Instance = this;
        }

        private void bt_novo_cla_Click(object sender, EventArgs e)
        {
            NovoCla();
        }

        public void NovoCla()
        {
            cadastro_cla uc = new cadastro_cla();
            cla.Instance.addControl(uc);

            _novoCla = true;
        }

        public void AtivarClas(string _cla, int _cont)
        {

            switch (_cont)
            {
                case 0:
                    txt_cla_01.Text = _cla;
                    bt_cla_01.Enabled = true;
                    break;
                case 1:
                    txt_cla_02.Text = _cla;
                    bt_cla_02.Enabled = true;
                    break;

                default:
                    break;
            }

            MessageBox.Show(_cont.ToString());

        }

        private void Clas()
        {
            switch (_clas)
            {
                case 0:
                   
                    break;
                case 1:
                   
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:

                    break;
                case 12:

                    break;
                case 13:

                    break;
                case 14:

                    break;
                case 15:

                    break;
                case 16:

                    break;
                case 17:

                    break;
                case 18:

                    break;
                case 19:

                    break;

                default:
                    break;
            }

        }

        private void Cla_00(string _cla)
        {
            txt_cla_01.Text = _cla;
            bt_cla_01.Enabled = true;
        }

        private void Cla_01(string _cla)
        {
            txt_cla_02.Text = _cla;
            bt_cla_02.Enabled = true;
        }
    }
}
