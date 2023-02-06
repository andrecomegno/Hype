using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hype.painel;
using Hype.script;
using MySql.Data.MySqlClient;

namespace Hype.painel
{
    public partial class conta_alt : UserControl
    {
        string id_conta = "";
        string id_alt = "";


        public conta_alt()
        {
            InitializeComponent();

            // BUSCADOR SETADO NO NICK CONTA PRINCIPAL
            txt_nickMain.Texts = alts.Instance.nickMain;
        }

        public void DadosMembros()
        {
            // ALT SELECIONADA - ALT.CS
            lb_data_entrada.Text = alts.Instance.data_entrada;

            id_conta = alts.Instance.id_conta;          

            id_alt = alts.Instance.id_alt;
            txt_nick.Texts = alts.Instance.nick_alt;
            txt_level.Texts = alts.Instance.level_alt;
            txt_poder.Texts = alts.Instance.poder_alt;
            txt_classe.Text = alts.Instance.classe_alt;
            txt_cla.Texts = alts.Instance.cla_alt;
        }

        private void ListaAlts()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand objCmdCadastro_membros = new MySqlCommand("select al.ID, c.ID, c.NICK, al.DATA_ENTRADA, al.NICK_ALT, al.LEVEL_ALT, al.PODER_ALT, al.CLASSE_ALT, al.CLA_ALT from hypedb.cadastro_membro c join hypedb.pergunta_alt p on p.ID = c.PERGUNTA_ALT_ID join hypedb.cadastro_alt al on al.PERGUNTA_ALT_ID = p.ID where nick like @nickMain '%' ", database.getConnection());

            objCmdCadastro_membros.Parameters.AddWithValue("@nickMain", txt_nickMain.Texts);

            using (MySqlDataAdapter da = new MySqlDataAdapter(objCmdCadastro_membros))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }            

            objCmdCadastro_membros.ExecuteNonQuery();

            database.closeConnection();

            Tabela();
        }

        private void Tabela()
        {

            dataGridView1.Columns[0].Visible = false; // al.id ID Cadastro Alt
            dataGridView1.Columns[1].Visible = false; // c.id ID Cadastro Membro

            dataGridView1.Columns[2].HeaderText = "CONTA PRINCIPAL";
            dataGridView1.Columns[3].Visible = false; // data entrada
            dataGridView1.Columns[4].HeaderText = "NICK";
            dataGridView1.Columns[5].HeaderText = "LEVEL";
            dataGridView1.Columns[6].HeaderText = "PODER";
            dataGridView1.Columns[7].HeaderText = "CLASSE";
            dataGridView1.Columns[8].HeaderText = "CLÃ";

            dataGridView1.Columns["LEVEL_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["PODER_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "NICK")
                    column.Width = 220;
                else if (column.DataPropertyName == "NICK_ALT")
                    column.Width = 220;
                else if (column.DataPropertyName == "LEVEL_ALT")
                    column.Width = 130;
                else if (column.DataPropertyName == "PODER_ALT")
                    column.Width = 130;
                else if (column.DataPropertyName == "CLASSE_ALT")
                    column.Width = 150;
                else if (column.DataPropertyName == "CLA_ALT")
                    column.Width = 240;
            }

        }


        private void conta_alt_Load(object sender, EventArgs e)
        {
            ListaAlts();
            DadosMembros();
        }
    }
}
