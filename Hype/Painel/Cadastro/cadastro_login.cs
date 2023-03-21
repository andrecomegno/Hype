using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hype.script;
using MySql.Data.MySqlClient;

namespace Hype.Painel.Cadastro
{
    public partial class cadastro_login : UserControl
    {
        public cadastro_login()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            configdb database = new configdb();
            database.openConnection();

            // INSERT TABELA CADASTRO MEMBROS
            MySqlCommand objCmdLogin = new MySqlCommand("insert into hypedb.login (id_login, usuario, email, senha) values (null, ?, ?, ?)", database.getConnection());

            objCmdLogin.Parameters.Add("@usuario", MySqlDbType.VarChar, 256).Value = txt_login.Texts;
            objCmdLogin.Parameters.Add("@email", MySqlDbType.Int32).Value = txt_email.Texts;
            objCmdLogin.Parameters.Add("@senha", MySqlDbType.Decimal).Value = txt_senha.Texts;

            objCmdLogin.ExecuteNonQuery();

            database.closeConnection();
        }
    }
}
