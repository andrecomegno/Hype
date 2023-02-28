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
    public partial class novo_evento : UserControl
    {

        string id_membro = eventos.Instance.id_membro;

        public novo_evento()
        {
            InitializeComponent();
        }

        #region TABELAS
        private void TabelaEvento()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.ID_RECRUTAMENTO, d.ID_DOACAO, eve.ID_EVENTOS, re.FOI_PARA_CLA, c.CLASSE, c.PATENTE, eve.ANO_EVENTO, eve.MES_EVENTO, c.NICK, d.SEMANA_01, d.SEMANA_02, d.SEMANA_03, d.SEMANA_04, d.TOTAL, d.ANOTACAO from hypedb.cadastro_membro c left join hypedb.cadastro_alt alt on c.ID_MEMBROS = alt.ID_ALT left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS left join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_MEMBROS left join hypedb.eventos eve on eve.ID_EVENTOS = c.ID_MEMBROS left join hypedb.doacao d on d.ID_DOACAO = c.ID_MEMBROS where c.ID_MEMBROS = '" + id_membro + "' ", database.getConnection());

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
            dataGridView1.Columns[2].Visible = false; // ID_DOACAO
            dataGridView1.Columns[3].Visible = false; // ID_EVENTOS
            dataGridView1.Columns[4].Visible = false; // FOI_PARA_CLA
            dataGridView1.Columns[5].Visible = false; // CLASSE
            dataGridView1.Columns[6].Visible = false; // PATENTE
            dataGridView1.Columns[7].HeaderText = "ANO";
            dataGridView1.Columns[8].HeaderText = "MÊS";
            dataGridView1.Columns[9].HeaderText = "NICK";
            dataGridView1.Columns[10].HeaderText = "SEMANA 01";
            dataGridView1.Columns[11].HeaderText = "SEMANA 02";
            dataGridView1.Columns[12].HeaderText = "SEMANA 03";
            dataGridView1.Columns[13].HeaderText = "SEMANA 04";
            dataGridView1.Columns[14].Visible = false; // TOTAL
            dataGridView1.Columns[15].Visible = false; // ANOTACAO

            dataGridView1.Columns["MES_EVENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["SEMANA_01"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["SEMANA_02"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["SEMANA_03"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["SEMANA_04"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {

                if (column.DataPropertyName == "ANO_EVENTO")
                    column.Width = 80;
                else if (column.DataPropertyName == "MES_EVENTO")
                    column.Width = 100;
                else if (column.DataPropertyName == "NICK")
                    column.Width = 250;
                else if (column.DataPropertyName == "SEMANA_01")
                    column.Width = 150;
                else if (column.DataPropertyName == "SEMANA_02")
                    column.Width = 150;
                else if (column.DataPropertyName == "SEMANA_03")
                    column.Width = 150;
                else if (column.DataPropertyName == "SEMANA_04")
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

                    //id_membro = dr["ID_MEMBROS"].ToString();

                    //data_entrada = ((DateTime)dr["DATA_RECRUTAMENTO"]).ToShortDateString();
                    //nick = dr["NICK"].ToString();
                    //foi_para_cla = dr["FOI_PARA_CLA"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                novo_evento uc = new novo_evento();
                cla.Instance.addControl(uc);
            }
        }

        #endregion

        private void novo_evento_Load(object sender, EventArgs e)
        {
            TabelaEvento();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
