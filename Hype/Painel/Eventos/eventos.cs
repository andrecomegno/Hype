using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hype.script;

namespace Hype.Painel.Eventos
{
    public partial class eventos : UserControl
    {
        public static eventos Instance;
        string id_membro;
        string data_entrada;
        string nick;
        string foi_para_cla;

        public eventos()
        {
            InitializeComponent();
            Instance = this;
        }

        #region MENU TOPO
        private void bt_membros_Click(object sender, EventArgs e)
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void bt_alts_Click(object sender, EventArgs e)
        {
            alts uc = new alts();
            cla.Instance.addControl(uc);
        }
        #endregion

        #region TABELAS
        private void TabelaEvento()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.ID_RECRUTAMENTO, eve.ID_EVENTOS, d.ID_DOACAO, eve.DATA_EVENTO, re.FOI_PARA_CLA, eve.NOME_EVENTO, c.PATENTE, c.CLASSE, c.NICK, d.SEMANA_01, d.SEMANA_02, d.SEMANA_03, d.SEMANA_04, d.TOTAL, d.ANOTACAO from hypedb.cadastro_membro c left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS left join hypedb.eventos eve on eve.ID_EVENTOS = c.ID_MEMBROS left join hypedb.doacao d on d.ID_DOACAO = c.ID_MEMBROS ", database.getConnection());

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
            dataGridView1.Columns[0].Visible = false; // ID_MEMBROS
            dataGridView1.Columns[1].Visible = false; // ID_RECRUTAMENTO
            dataGridView1.Columns[2].Visible = false; // ID_EVENTOS
            dataGridView1.Columns[3].Visible = false; // ID_DOACAO
            dataGridView1.Columns[4].Visible = false; // DATA_EVENTO
            dataGridView1.Columns[5].Visible = false; // FOI_PARA_CLA
            dataGridView1.Columns[6].HeaderText = "EVENTO";
            dataGridView1.Columns[7].HeaderText = "PATENTE";
            dataGridView1.Columns[8].HeaderText = "CLASSE";
            dataGridView1.Columns[9].HeaderText = "NICK";
            dataGridView1.Columns[10].Visible = false; // TOTAL
            dataGridView1.Columns[11].Visible = false; // TOTAL
            dataGridView1.Columns[12].Visible = false; // TOTAL
            dataGridView1.Columns[13].Visible = false; // TOTAL
            dataGridView1.Columns[14].HeaderText = "TOTAL";
            dataGridView1.Columns[15].Visible = false; // ANOTACAO

            dataGridView1.Columns["PATENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "NOME_EVENTO")
                    column.Width = 150;
                else if (column.DataPropertyName == "PATENTE")
                    column.Width = 150;
                else if (column.DataPropertyName == "CLASSE")
                    column.Width = 150;
                else if (column.DataPropertyName == "NICK")
                    column.Width = 250;
                else if (column.DataPropertyName == "TOTAL")
                    column.Width = 150;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                MostrarDadosTabela();
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Cursor = Cursors.Hand;
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Cursor = Cursors.Default;
        }

        private void MostrarDadosTabela()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

                    id_membro = dr["ID_MEMBROS"].ToString();

                    data_entrada = ((DateTime)dr["DATA_RECRUTAMENTO"]).ToShortDateString();
                    nick = dr["NICK"].ToString();
                    foi_para_cla = dr["FOI_PARA_CLA"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                conta_principal uc = new conta_principal();
                cla.Instance.addControl(uc);
            }
        }

        #endregion

        private void eventos_Load(object sender, EventArgs e)
        {
            TabelaEvento();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }
    }
}
