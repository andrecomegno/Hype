using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hype.script;
using Hype.Painel.Home;

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

        // SELECIONAR CLA 
        public string nome_cla = home.Instance.nome_cla;

        public eventos()
        {
            InitializeComponent();
            Instance = this;
        }

        #region TABELAS
        private void TabelaEvento()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, eve.ID_EVENTOS, d.ID_DOACAO, cl.NOME_CLA, c.STATUS, re.FOI_PARA_CLA, c.PATENTE, c.CLASSE, c.NICK, d.TOTAL from hypedb.cadastro_membro c left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_RECRUTAMENTO left join hypedb.doacao d on d.ID_MEMBROS = c.ID_MEMBROS left join hypedb.eventos eve on eve.ID_EVENTOS = d.ID_EVENTOS left join hypedb.cadastro_cla cl on cl.ID_CLA = re.ID_CLA where cl.NOME_CLA like @NOME_CLA '%' and c.STATUS like @STATUS '%' ", database.getConnection());
            cmd.Parameters.AddWithValue("@NOME_CLA", nome_cla);
            cmd.Parameters.AddWithValue("@STATUS", "Ativo");

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
            dataGridView1.Columns[1].Visible = false; // ID_EVENTOS
            dataGridView1.Columns[2].Visible = false; // ID_DOACAO
            dataGridView1.Columns[3].Visible = false; // NOME_CLA
            dataGridView1.Columns[4].Visible = false; // STATUS
            dataGridView1.Columns[5].Visible = false; // FOI_PARA_CLA
            dataGridView1.Columns[6].HeaderText = "PATENTE";
            dataGridView1.Columns[7].HeaderText = "CLASSE";
            dataGridView1.Columns[8].HeaderText = "NICK";
            dataGridView1.Columns[9].HeaderText = "TOTAL";

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

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, eve.ID_EVENTOS, d.ID_DOACAO, cl.NOME_CLA, c.STATUS, re.FOI_PARA_CLA, c.PATENTE, c.CLASSE, c.NICK, d.TOTAL from hypedb.cadastro_membro c left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS left join hypedb.doacao d on d.ID_MEMBROS = c.ID_MEMBROS left join hypedb.eventos eve on eve.ID_EVENTOS = d.ID_EVENTOS left join hypedb.cadastro_cla cl on cl.ID_CLA = c.ID_MEMBROS where cl.NOME_CLA like @NOME_CLA '%' and c.STATUS like @STATUS '%' and c.NICK like @NICK '%' ", database.getConnection());
            cmd.Parameters.AddWithValue("@NOME_CLA", nome_cla);
            cmd.Parameters.AddWithValue("@NICK", txt_buscar.Texts);
            cmd.Parameters.AddWithValue("@STATUS", "Ativo");

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
