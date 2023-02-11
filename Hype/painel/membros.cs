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

        public string id_membro = "";
        public string id_remanejamento = "";
        public string id_pergunta_alt = "";
        public string id_pergunta_expedicao = "";
        public string id_recrutamento = "";

        public string data_entrada = "";
        public string nick = "";
        public string level = "";
        public string poder = "";
        public string classe = "";
        public string patente = "";
        public string vem_do_cla = "";
        public string foi_para_cla = "";
        public string esta_no_cla = "";
        public string vai_para_cla = "";

        public membros()
        {
            InitializeComponent();
            Instance = this;
        }

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

        private void ListaMembros()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.id, pro.id, p.id, e.id, r.id, r.DATA_ENTRADA, c.NICK, c.LEVEL, c.PODER, c.CLASSE, c.PATENTE, p.PERGUNTA_ALT, e.PERGUNTA_EXPEDICAO, r.VEM_DO_CLA, r.FOI_PARA_CLA from hypedb.cadastro_membro c join hypedb.progressao pro on pro.ID = c.PROGRESSAO_ID join hypedb.pergunta_alt p on p.ID = c.PERGUNTA_ALT_ID join hypedb.pergunta_expedicao e on e.ID = c.PERGUNTA_EXPEDICAO_ID join hypedb.recrutamento r on r.ID = c.RECRUTAMENTO_ID", database.getConnection());

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
            dataGridView1.Columns[0].Visible = false; // c.id ID Membros
            dataGridView1.Columns[1].Visible = false; // re.di ID Progressão
            dataGridView1.Columns[2].Visible = false; // p.id ID Pergunta Alt
            dataGridView1.Columns[3].Visible = false; // e.id ID Expedicao
            dataGridView1.Columns[4].Visible = false; // r.id ID Recrutamento

            dataGridView1.Columns[5].HeaderText = "DATA ENTRADA";
            dataGridView1.Columns[6].HeaderText = "NICK";
            dataGridView1.Columns[7].HeaderText = "LEVEL";
            dataGridView1.Columns[8].HeaderText = "PODER";
            dataGridView1.Columns[9].HeaderText = "CLASSE";
            dataGridView1.Columns[10].HeaderText = "PATENTE";
            dataGridView1.Columns[11].Visible = false; // pergunta alt
            dataGridView1.Columns[12].Visible = false; // pergunta expedição
            dataGridView1.Columns[13].Visible = false; // vem do cla
            dataGridView1.Columns[14].Visible = false; // foi para o cla

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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarDadosTabela();
        }

        private void MostrarDadosTabela()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

                    id_membro = dr["ID"].ToString();
                    id_remanejamento = dr["ID"].ToString();

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

        private void bt_add_membro_Click(object sender, EventArgs e)
        {
            add_membros uc = new add_membros();
            cla.Instance.addControl(uc);
        }

        // CAMPO DE BUSCA
        private void bt_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.id, re.id, p.id, e.id, r.id, r.DATA_ENTRADA, c.NICK, c.LEVEL, c.PODER, c.CLASSE, c.PATENTE, p.PERGUNTA_ALT, e.PERGUNTA_EXPEDICAO, r.VEM_DO_CLA, r.FOI_PARA_CLA, re.ESTA_NO_CLA, re.VAI_PARA_CLA from hypedb.cadastro_membro c join hypedb.remanejamento re on re.ID = c.REMANEJAMENTO_ID join hypedb.pergunta_alt p on p.ID = c.PERGUNTA_ALT_ID join hypedb.pergunta_expedicao e on e.ID = c.PERGUNTA_EXPEDICAO_ID join hypedb.recrutamento r on r.ID = c.RECRUTAMENTO_ID where c.nick like @nick '%' ", database.getConnection());
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
                buscar();
            }
        }

        private void membros_Load(object sender, EventArgs e)
        {
            ListaMembros();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }


    }
}
