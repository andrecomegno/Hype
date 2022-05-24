using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hype.script;
using Google.Cloud.Firestore;

namespace Hype.painel
{
    public partial class membros : UserControl
    {
        public static membros Instance;

        public string id = "";
        public string nick = "";
        public string level = "";
        public string poder = "";
        public string classe = "";
        public string patente = "";
        public string data_entrada = "";
        public string data_saida = "";
        public string vem_do_cla = "";
        public string foi_para_cla = "";

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


        public void ListaMembros()
        {
            Tabela();
        }

        public void Tabela()
        {
            dataGridView1.Columns[0].Visible = false; // ID
            dataGridView1.Columns[1].Visible = false; // DATA ENTRADA
            dataGridView1.Columns[2].Visible = false; // DATA SAIDA
            dataGridView1.Columns[3].Visible = false; // VEM DO CLA

            dataGridView1.Columns[4].HeaderText = "NICK";
            dataGridView1.Columns[5].HeaderText = "LEVEL";            
            dataGridView1.Columns[6].HeaderText = "PODER";
            dataGridView1.Columns[7].HeaderText = "CLASSE";
            dataGridView1.Columns[8].HeaderText = "PATENTE";
            dataGridView1.Columns[9].HeaderText = "ESTÁ NO CLA"; // FOI PARA O CLA

            dataGridView1.Columns["LEVEL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["PODER"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["PATENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "NICK")
                    column.Width = 220;
                else if (column.DataPropertyName == "LEVEL")
                    column.Width = 150;
                else if (column.DataPropertyName == "PODER")
                    column.Width = 150;
                else if (column.DataPropertyName == "CLASSE")
                    column.Width = 200;
                else if (column.DataPropertyName == "PATENTE")
                    column.Width = 200;
                else if (column.DataPropertyName == "FOI_PARA_CLA") // ESTÁ NO CLA
                    column.Width = 220;
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarDadosTabela();
        }

        public void MostrarDadosTabela()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

                    id = dr["ID"].ToString();
                    data_entrada = ((DateTime)dr["DATA_ENTRADA"]).ToShortDateString();
                    //data_saida = dr["DATA_SAIDA"].ToString();
                    // data_remanejamento = dr["DATA_ENTRADA"].ToString();
                    nick = dr["NICK"].ToString();
                    level = dr["LEVEL"].ToString();
                    poder = dr["PODER"].ToString();
                    patente = dr["PATENTE"].ToString();
                    classe = dr["CLASSE"].ToString();
                    vem_do_cla = dr["VEM_DO_CLA"].ToString();
                    foi_para_cla = dr["FOI_PARA_CLA"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Erro Interno", "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                membros_info mb = new membros_info();
                mb.ShowDialog();
            }
        }

        private void membros_Load(object sender, EventArgs e)
        {
            ListaMembros();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void bt_add_membro_Click(object sender, EventArgs e)
        {
            add_membros uc = new add_membros();
            cla.Instance.addControl(uc);
        }
    }
}
