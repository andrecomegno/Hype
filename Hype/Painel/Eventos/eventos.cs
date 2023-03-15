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
        public string id_membro = "";
        public string id_eventos = "";
        public string id_doacao = "";
        public string nick;
        public string foi_para_cla;

        public eventos()
        {
            InitializeComponent();
            Instance = this;
        }

        #region MENU TOPO
        private void bt_membros_Click(object sender, EventArgs e)
        {
            cla.Instance.btMembros();
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

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.ID_RECRUTAMENTO, d.ID_DOACAO, eve.ID_EVENTOS, re.FOI_PARA_CLA, c.PATENTE, c.CLASSE, eve.ANO_EVENTO, eve.MES_EVENTO, c.NICK, d.SEMANA_01, d.SEMANA_02, d.SEMANA_03, d.SEMANA_04, d.TOTAL, d.ANOTACAO from hypedb.cadastro_membro c left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS left join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_MEMBROS left join hypedb.doacao d on d.ID_MEMBROS = c.ID_MEMBROS left join hypedb.eventos eve on eve.ID_EVENTOS = d.ID_EVENTOS", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();

            if (dataGridView1.Rows.Count == 0)
            {
                txt_sem_dados.Visible = true;

                dataGridView1.Visible = false;
            }
            else
            {
                txt_sem_dados.Visible = false;

                dataGridView1.Visible = true;
            }

            Tabela();
        }

        private void Tabela()
        {
            dataGridView1.Columns[0].Visible = false; // ID_MEMBROS
            dataGridView1.Columns[1].Visible = false; // ID_RECRUTAMENTO
            dataGridView1.Columns[2].Visible = false; // ID_DOACAO
            dataGridView1.Columns[3].Visible = false; // ID_EVENTOS
            dataGridView1.Columns[4].Visible = false; // FOI_PARA_CLA
            dataGridView1.Columns[5].HeaderText = "PATENTE";
            dataGridView1.Columns[6].HeaderText = "CLASSE";
            dataGridView1.Columns[7].Visible = false; // ANO_EVENTO
            dataGridView1.Columns[8].Visible = false; // MES_EVENTO
            dataGridView1.Columns[9].HeaderText = "NICK";
            dataGridView1.Columns[10].Visible = false; // SEMANA_01
            dataGridView1.Columns[11].Visible = false; // SEMANA_02
            dataGridView1.Columns[12].Visible = false; // SEMANA_03
            dataGridView1.Columns[13].Visible = false; // SEMANA_04
            dataGridView1.Columns[14].HeaderText = "TOTAL";
            dataGridView1.Columns[15].Visible = false; // ANOTACAO

            dataGridView1.Columns["PATENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "PATENTE")
                    column.Width = 150;
                else if (column.DataPropertyName == "CLASSE")
                    column.Width = 150;
                else if (column.DataPropertyName == "NICK")
                    column.Width = 550;
                else if (column.DataPropertyName == "TOTAL")
                    column.Width = 200;
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
                    id_eventos = dr["ID_EVENTOS"].ToString();
                    id_doacao = dr["ID_DOACAO"].ToString();

                    //data_entrada = ((DateTime)dr["DATA_RECRUTAMENTO"]).ToShortDateString();
                    nick = dr["NICK"].ToString();
                    foi_para_cla = dr["FOI_PARA_CLA"].ToString();

                    MessageBox.Show(id_membro);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                doacao uc = new doacao();
                cla.Instance.addControl(uc);
            }
        }

        #endregion

        #region BUSCAR
        private void bt_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.ID_RECRUTAMENTO, d.ID_DOACAO, eve.ID_EVENTOS, re.FOI_PARA_CLA, c.PATENTE, c.CLASSE, eve.ANO_EVENTO, eve.MES_EVENTO, c.NICK, d.SEMANA_01, d.SEMANA_02, d.SEMANA_03, d.SEMANA_04, d.TOTAL, d.ANOTACAO from hypedb.cadastro_membro c left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS left join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_MEMBROS left join hypedb.eventos eve on eve.ID_EVENTOS = c.ID_MEMBROS left join hypedb.doacao d on d.ID_DOACAO = c.ID_MEMBROS where c.NICK like @NICK '%'", database.getConnection());
            cmd.Parameters.AddWithValue("@NICK", txt_buscar.Texts);

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();
        }

        private void txt_buscar__TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_buscar.Texts))
            {
                Buscar();
            }
        }

        private void bt_buscar_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bt_buscar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
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
