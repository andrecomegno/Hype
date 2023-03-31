using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hype.script;
using Hype.Painel.Home;

namespace Hype.Painel
{
    public partial class alts : UserControl
    {
        public static alts Instance;

        // ID`S
        public string id_membro = membros.Instance.id_membros;

        // COLETAR DADOS
        public string id_alt = string.Empty;
        public string data_entrada = string.Empty;
        public string nick_principal = string.Empty;
        public string nick_alt = string.Empty;
        public string level_alt = string.Empty;
        public string poder_alt = string.Empty;
        public string classe_alt = string.Empty;
        public string cla_alt = string.Empty;

        // SELECIONAR CLA 
        public string nome_cla = home.Instance.nome_cla;

        public alts()
        {
            InitializeComponent();
            Instance = this;

            txt_sem_dados.Visible = false;
            txt_clique_aqui.Visible = false;
        }

        #region MENU TOP
        private void bt_membros_Click(object sender, EventArgs e)
        {
            cla.Instance.btMembros();
        }
        #endregion

        #region TABELAS
        private void TabelaAlt()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select alt.ID_ALT, alt.DATA_ALT, alt.NICK_ALT, alt.LEVEL_ALT, alt.CLASSE_ALT, alt.CLA_ALT, alt.STATUS_ALT, cl.NOME_CLA, alt.ID_MEMBROS from hypedb.cadastro_membro c join hypedb.cadastro_alt alt on alt.ID_MEMBROS = c.ID_MEMBROS join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_RECRUTAMENTO join hypedb.cadastro_cla cl on cl.ID_CLA = re.ID_CLA where cl.NOME_CLA like @NOME_CLA '%' and alt.STATUS_ALT like @STATUS_ALT '%' ", database.getConnection());
            cmd.Parameters.AddWithValue("@NOME_CLA", nome_cla);
            cmd.Parameters.AddWithValue("@STATUS_ALT", "Ativo");

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                txt_sem_dados.Visible = true;
                txt_clique_aqui.Visible = true;
                bt_add_alt.Visible = false;

                dataGridView1.Visible = false;
            }
            else
            {
                txt_sem_dados.Visible = false;
                txt_clique_aqui.Visible = false;
                bt_add_alt.Visible = true;

                dataGridView1.Visible = true;
            }

            database.closeConnection();

            Tabela();
        }

        private void Tabela()
        {

            dataGridView1.Columns[0].Visible = false; // ID_ALT
            dataGridView1.Columns[1].HeaderText = "DATA ENTRADA";
            dataGridView1.Columns[2].HeaderText = "NICK";
            dataGridView1.Columns[3].HeaderText = "LEVEL";
            dataGridView1.Columns[4].HeaderText = "CLASSE";
            dataGridView1.Columns[5].HeaderText = "CLÃ";
            dataGridView1.Columns[6].Visible = false; // STATUS_ALT
            dataGridView1.Columns[7].Visible = false; // NOME_CLA
            dataGridView1.Columns[8].Visible = false; // ID_MEMBROS

            dataGridView1.Columns["DATA_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LEVEL_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "DATA_ALT")
                    column.Width = 200;
                else if (column.DataPropertyName == "NICK_ALT")
                    column.Width = 350;
                else if (column.DataPropertyName == "LEVEL_ALT")
                    column.Width = 130;
                else if (column.DataPropertyName == "CLASSE_ALT")
                    column.Width = 150;
                else if (column.DataPropertyName == "CLA_ALT")
                    column.Width = 200;
            }
        }

        private void DadosTabela()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

                    id_alt = dr["ID_ALT"].ToString();
                    id_membro = dr["ID_MEMBROS"].ToString();
                    data_entrada = ((DateTime)dr["DATA_ALT"]).ToShortDateString();
                    nick_alt = dr["NICK_ALT"].ToString();
                    level_alt = dr["LEVEL_ALT"].ToString();
                    classe_alt = dr["CLASSE_ALT"].ToString();
                    cla_alt = dr["CLA_ALT"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Interno" + erro + "ERRO FATAL");
            }
            finally
            {
                conta_alt uc = new conta_alt();
                cla.Instance.addControl(uc);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DadosTabela();
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
        #endregion

        #region BUSCAR
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Buscar();
            }
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txt_buscar__TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_buscar.Texts))
            {
                Buscar();
            }
        }

        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Buscar()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select alt.ID_ALT, alt.DATA_ALT, alt.NICK_ALT, alt.LEVEL_ALT, alt.CLASSE_ALT, alt.CLA_ALT, alt.STATUS_ALT, cl.NOME_CLA, alt.ID_MEMBROS from hypedb.cadastro_membro c join hypedb.cadastro_alt alt on alt.ID_MEMBROS = c.ID_MEMBROS join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_MEMBROS join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_RECRUTAMENTO join hypedb.cadastro_cla cl on cl.ID_CLA = re.ID_CLA where cl.NOME_CLA like @NOME_CLA '%' and alt.STATUS_ALT like @STATUS_ALT '%' and NICK_ALT like @NICK_ALT '%' ", database.getConnection());
            cmd.Parameters.AddWithValue("@NICK_ALT", txt_buscar.Texts);
            cmd.Parameters.AddWithValue("@NOME_CLA", nome_cla);
            cmd.Parameters.AddWithValue("@STATUS_ALT", "Ativo");

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();
        }
        #endregion

        #region BOTOES
        private void txt_clique_aqui_Click(object sender, EventArgs e)
        {
            cadastro_alt uc = new cadastro_alt();
            cla.Instance.addControl(uc);
        }

        private void bt_add_alt_Click(object sender, EventArgs e)
        {
            cadastro_alt uc = new cadastro_alt();
            cla.Instance.addControl(uc);
        }

        private void bt_add_alt_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bt_add_alt_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        #endregion

        private void alts_Load(object sender, EventArgs e)
        {
            TabelaAlt();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;

        }


    }
}
