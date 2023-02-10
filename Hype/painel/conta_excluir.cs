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
    public partial class conta_excluir : UserControl
    {

        string id_membro = string.Empty;

        public string id_alt = "";
        public string data_saida = "";
        public string nick_alt = "";
        public string level_alt = "";
        public string classe_alt = "";
        public string cla_alt = "";

        public conta_excluir()
        {
            InitializeComponent();

            txt_nick.Texts = membros.Instance.nick;
        }

        public void DadosMembros()
        {
            // CADASTRO
            id_membro = membros.Instance.id_membro;
            //lb_data_saida.Text = DateTime.Now;            
            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Text = membros.Instance.patente;
            txt_classe.Text = membros.Instance.classe;
            txt_cla.Texts = membros.Instance.esta_no_cla;
        }

        private void ListaAlts()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select al.ID, c.ID, c.NICK, al.DATA_ENTRADA, al.NICK_ALT, al.LEVEL_ALT, al.PODER_ALT, al.CLASSE_ALT, al.CLA_ALT from hypedb.cadastro_membro c join hypedb.pergunta_alt p on p.ID = c.PERGUNTA_ALT_ID join hypedb.cadastro_alt al on al.PERGUNTA_ALT_ID = p.ID where nick like @nickMain '%' ", database.getConnection());

            cmd.Parameters.AddWithValue("@nickMain", txt_nick.Texts);

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();

            Tabela();
        }

        private void Tabela()
        {         
            dataGridView1.Columns[0].Visible = false; // al.id ID Membros
            dataGridView1.Columns[1].Visible = false; // c.id ID Remanejamento
            dataGridView1.Columns[2].Visible = false; // c.nick ID Pergunta Alt
            dataGridView1.Columns[3].Visible = false; // Data da Entrada
            dataGridView1.Columns[4].HeaderText = "NICK";
            dataGridView1.Columns[5].HeaderText = "LEVEL";
            dataGridView1.Columns[6].Visible = false; // poder alt
            dataGridView1.Columns[7].HeaderText = "CLASSE";
            dataGridView1.Columns[8].HeaderText = "CLÃ";

            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
            dataGridView1.Columns[8].ReadOnly = true;

            DataGridViewCheckBoxColumn selecionar = new DataGridViewCheckBoxColumn();
            selecionar.Name = "SELECIONAR";
            selecionar.DataPropertyName = "SELECIONAR";
            selecionar.HeaderText = "";

            dataGridView1.Columns.Insert(0, selecionar);

            dataGridView1.Columns["DATA_ENTRADA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LEVEL_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "NICK_ALT")
                    column.Width = 220;
                else if (column.DataPropertyName == "LEVEL_ALT")
                    column.Width = 100;
                else if (column.DataPropertyName == "CLASSE_ALT")
                    column.Width = 150;
                else if (column.DataPropertyName == "CLA_ALT")
                    column.Width = 200;
                else if (column.DataPropertyName == "SELECIONAR")
                    column.Width = 30;
            }

        }

        private void MostrarDadosTabela()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {                    
                    bool _selecionar = Convert.ToBoolean(row.Cells["SELECIONAR"].Value);
                    if (_selecionar)
                    {
                        id_alt += row.Cells["ID"].Value.ToString();
                        nick_alt += row.Cells["NICK_ALT"].Value.ToString();
                        level_alt += row.Cells["LEVEL_ALT"].Value.ToString();
                        classe_alt += row.Cells["CLASSE_ALT"].Value.ToString();
                        cla_alt += row.Cells["CLA_ALT"].Value.ToString();
                    }                    
                }

                MessageBox.Show(id_alt);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }


        private void BotaoVoltar()
        {
            conta_principal uc = new conta_principal();
            cla.Instance.addControl(uc);
        }

        private void BotaoCancelar()
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Tem Certeza Que Deseja Excluir ?", "AVISO !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        ExcluirConta();
                        break;
                    case DialogResult.No:
                        
                        break;
                    default:
                        break;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                BotaoCancelar();
            }
        }

        private void ExcluirConta()
        {
            try
            {
                configdb database = new configdb();
                database.openConnection();

                MySqlCommand objCmdRemanejamento = new MySqlCommand("delete from hypedb.remanejamento where ID=@id", database.getConnection());
                objCmdRemanejamento.Parameters.AddWithValue("@id", id_membro);

                objCmdRemanejamento.ExecuteNonQuery();

                MySqlCommand objCmdContaAlt = new MySqlCommand("delete from hypedb.pergunta_alt where ID=@id", database.getConnection());
                objCmdContaAlt.Parameters.AddWithValue("@id", id_alt);

                objCmdContaAlt.ExecuteNonQuery();

                database.closeConnection();

                MostrarDadosTabela();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            BotaoVoltar();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            BotaoCancelar();
        }

        private void conta_excluir_Load(object sender, EventArgs e)
        {
            ListaAlts();
            DadosMembros();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;            
        }
    }
}
