using Hype.Painel.Home;
using Hype.script;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hype.Painel
{
    public partial class configuracao : UserControl
    {

        public string nome_cla = home.Instance.nome_cla;

        public configuracao()
        {
            InitializeComponent();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
