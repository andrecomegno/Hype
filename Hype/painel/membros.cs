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

namespace Hype.painel
{
    public partial class membros : UserControl
    {
        public static membros Instance;

        public string data_entrada = "";
        public string nick = "";
        public string level = "";
        public string poder = "";
        public string classe = "";
        public string patente = "";
        public string vem_do_cla = "";
        public string foi_para_cla = "";

        public string id_membro = "";
        public string id_alt = "";
        public string id_progressao = "";
        public string id_recrutamento = "";

        public membros()
        {
            InitializeComponent();
            Instance = this;

            txt_sem_dados.Visible = false;
            txt_clique_aqui.Visible = false;
        }

        #region MENU TOPO
        private void bt_progressao_Click(object sender, EventArgs e)
        {
            progressao uc = new progressao();
            cla.Instance.addControl(uc);
        }

        private void bt_ouro_Click(object sender, EventArgs e)
        {
            ouro uc = new ouro();
            cla.Instance.addControl(uc);
        }

        private void bt_alts_Click(object sender, EventArgs e)
        {
            alts uc = new alts();
            cla.Instance.addControl(uc);
        }
        #endregion

        #region TABELAS
        private void TabelaMembros()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select re.ID_RECRUTAMENTO, pro.ID_PROGRESSAO, alt.ID_ALT, c.ID_MEMBROS, re.DATA_ENTRADA, c.NICK, c.LEVEL, c.PODER, c.CLASSE, c.PATENTE, re.VEM_DO_CLA, re.FOI_PARA_CLA from hypedb.cadastro_membro c left join hypedb.cadastro_alt alt on c.ID_MEMBROS = alt.ID_ALT left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS left join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_PROGRESSAO", database.getConnection());

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
                txt_clique_aqui.Visible = true;

                dataGridView1.Visible = false;
            }
            else
            {
                txt_sem_dados.Visible = false;
                txt_clique_aqui.Visible = false;

                dataGridView1.Visible = true;
            }

            Tabela();
        }

        private void Tabela()
        {
            dataGridView1.Columns[0].Visible = false; // ID_RECRUTAMENTO
            dataGridView1.Columns[1].Visible = false; // ID_PROGRESSAO
            dataGridView1.Columns[2].Visible = false; // ID_ALT
            dataGridView1.Columns[3].Visible = false; // ID_MEMBROS
            dataGridView1.Columns[4].HeaderText = "DATA ENTRADA";
            dataGridView1.Columns[5].HeaderText = "NICK";
            dataGridView1.Columns[6].HeaderText = "LEVEL";
            dataGridView1.Columns[7].HeaderText = "PODER";
            dataGridView1.Columns[8].HeaderText = "CLASSE";
            dataGridView1.Columns[9].HeaderText = "PATENTE";
            dataGridView1.Columns[10].Visible = false; // vem do cla
            dataGridView1.Columns[11].Visible = false; // foi para o cla

            dataGridView1.Columns["DATA_ENTRADA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["LEVEL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["PODER"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["PATENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "DATA_ENTRADA")
                    column.Width = 200;
                else if (column.DataPropertyName == "NICK")
                    column.Width = 220;
                else if (column.DataPropertyName == "LEVEL")
                    column.Width = 130;
                else if (column.DataPropertyName == "PODER")
                    column.Width = 130;
                else if (column.DataPropertyName == "CLASSE")
                    column.Width = 150;
                else if (column.DataPropertyName == "PATENTE")
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
                    id_alt = dr["ID_ALT"].ToString();
                    id_recrutamento = dr["ID_RECRUTAMENTO"].ToString();
                    id_progressao = dr["ID_PROGRESSAO"].ToString();

                    data_entrada = ((DateTime)dr["DATA_ENTRADA"]).ToShortDateString();
                    nick = dr["NICK"].ToString();
                    level = dr["LEVEL"].ToString();
                    poder = dr["PODER"].ToString();
                    patente = dr["PATENTE"].ToString();
                    classe = dr["CLASSE"].ToString();
                    vem_do_cla = dr["VEM_DO_CLA"].ToString();
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

        #region BOTOES
        private void bt_add_membro_Click(object sender, EventArgs e)
        {
            cadastro uc = new cadastro();
            cla.Instance.addControl(uc);
        }

        private void txt_clique_aqui_Click(object sender, EventArgs e)
        {
            cadastro uc = new cadastro();
            cla.Instance.addControl(uc);
        }
        private void bt_add_membro_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bt_add_membro_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        // CAMPO DE BUSCA
        private void bt_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select re.ID_RECRUTAMENTO, pro.ID_PROGRESSAO, alt.ID_ALT, c.ID_MEMBROS, re.DATA_ENTRADA, c.NICK, c.LEVEL, c.PODER, c.CLASSE, c.PATENTE, re.VEM_DO_CLA, re.FOI_PARA_CLA from hypedb.cadastro_membro c left join hypedb.cadastro_alt alt on c.ID_MEMBROS = alt.ID_ALT left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS left join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_PROGRESSAO where NICK like @nick '%' ", database.getConnection());
            cmd.Parameters.AddWithValue("@nick", txt_buscar.Texts);

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
            if(String.IsNullOrEmpty(txt_buscar.Texts))
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

        private void membros_Load(object sender, EventArgs e)
        {
            TabelaMembros();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }


    }
}
