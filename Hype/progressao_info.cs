using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hype.script;
using Hype.painel;

namespace Hype
{
    public partial class progressao_info : Form
    {
        public progressao_info()
        {
            InitializeComponent();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            AddProgressao();
        }

        private void AddProgressao()
        {
            configdb database = new configdb();
            database.openConnection();

            // INSERT TABELA PROGRESSAO
            MySqlCommand objCmdPorgresssao = new MySqlCommand("insert into progressao (id, data, novo_poder, novo_level, remanejamento_id) values (null, null, ?, null)", database.getConnection());

            objCmdPorgresssao.Parameters.Add("@data", MySqlDbType.Date).Value = lb_data_pro.Text;
            objCmdPorgresssao.Parameters.Add("@novo_poder", MySqlDbType.VarChar, 256).Value = txt_novo_poder.Texts;
            objCmdPorgresssao.Parameters.Add("@novo_level", MySqlDbType.VarChar, 256).Value = txt_novo_level.Texts;
            //objCmdPorgresssao.Parameters.Add("@remanejamento_id", MySqlDbType.VarChar, 256).Value = add_membros.Instance.idRemanejamento;

            objCmdPorgresssao.ExecuteNonQuery();
        }

        private void progressao_info_Load(object sender, EventArgs e)
        {
            lb_data_pro.Text = DateTime.Now.ToShortDateString();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
