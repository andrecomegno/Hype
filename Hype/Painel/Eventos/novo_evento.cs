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
        // ID`S
        string id_membro = eventos.Instance.id_membro;

        // OURO
        decimal total = 4;

        // DATAS
        int datas = 0;
        string janeiro = "Janeiro";
        string fevereiro = "Fevereiro";
        string marco = "Março";
        string abril = "Abril";
        string maio = "Maio";
        string junho = "Junho";
        string julho = "Julho";
        string agosto = "Agosto";
        string setembro = "Setembro";
        string outubro = "Outubro";
        string novembro = "Novembro";
        string dezembro = "Dezembro";

        public novo_evento()
        {
            InitializeComponent();            
        }

        private void BuscarMes()
        {
            switch (txt_mes_evento.SelectedIndex)
            {
                case 0:
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;

                default:
                    break;
            }
        }

        #region TABELAS
        private void TabelaEvento()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.ID_RECRUTAMENTO, d.ID_DOACAO, eve.ID_EVENTOS, re.FOI_PARA_CLA, c.CLASSE, c.PATENTE, eve.ANO_EVENTO, eve.MES_EVENTO, c.NICK, d.SEMANA_01, d.SEMANA_02, d.SEMANA_03, d.SEMANA_04, d.TOTAL, d.ANOTACAO from hypedb.cadastro_membro c join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS join hypedb.doacao d on d.ID_MEMBROS = c.ID_MEMBROS join hypedb.eventos eve on eve.ID_EVENTOS = d.ID_EVENTOS where c.ID_MEMBROS = '" + id_membro + "' ", database.getConnection());

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

        #region BOTÕES
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            eventos uc = new eventos();
            cla.Instance.addControl(uc);
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Salvar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            
        }

        private void Salvar()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            // INSERT TABELA EVENTOS
            MySqlCommand objCmdEventos = new MySqlCommand("insert into hypedb.eventos (id_eventos, mes_evento, ano_evento, id_membros) values (null, ?, ?, ?)", database.getConnection());

            objCmdEventos.Parameters.Add("@mes_evento", MySqlDbType.VarChar, 256).Value = lb_datas.Text;
            objCmdEventos.Parameters.Add("@ano_evento", MySqlDbType.Year).Value = DateTime.Now.Year;
            objCmdEventos.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = id_membro;

            objCmdEventos.ExecuteNonQuery();
            long idEventos = objCmdEventos.LastInsertedId;
 
            // INSERT TABELA DOAÇÃO
            MySqlCommand objCmdDoacao = new MySqlCommand("insert into hypedb.doacao (id_doacao, semana_01, semana_02, semana_03, semana_04, total, anotacao, id_eventos, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdDoacao.Parameters.Add("@semana_01", MySqlDbType.Decimal).Value = txt_doacao_01.Texts;
            objCmdDoacao.Parameters.Add("@semana_02", MySqlDbType.Decimal).Value = txt_doacao_02.Texts;
            objCmdDoacao.Parameters.Add("@semana_03", MySqlDbType.Decimal).Value = txt_doacao_03.Texts;
            objCmdDoacao.Parameters.Add("@semana_04", MySqlDbType.Decimal).Value = txt_doacao_04.Texts;
            objCmdDoacao.Parameters.Add("@total", MySqlDbType.Decimal).Value = 0.0;
            objCmdDoacao.Parameters.Add("@anotacao", MySqlDbType.VarChar, 256).Value = "";
            objCmdDoacao.Parameters.Add("@id_eventos", MySqlDbType.Int32).Value = idEventos;
            objCmdDoacao.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = id_membro;

            objCmdDoacao.ExecuteNonQuery();

            MessageBox.Show(idEventos.ToString());

            /*
            #region MEMBROS
            // UPDATE MEMBROS
            MySqlCommand objCmdCadastroMembros = new MySqlCommand("update hypedb. set nick=@nick, classe=@classe, patente=@patente where (id_membros=@id_membros)", database.getConnection());

            objCmdCadastroMembros.Parameters.AddWithValue("@id_membros", id_membro);
            objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
            //objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_novo_poder.Texts; // NOVO PODER
            //objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_novo_level.Texts; // NOVO LEVEL
            objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
            objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;

            objCmdCadastroMembros.ExecuteNonQuery();
            #endregion
            */

            DialogResult dr = MessageBox.Show("Membro Atualizado Com Sucesso !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.closeConnection();
        }

        private void MesEvento()
        {
            switch (datas)
            {
                case 0:
                    lb_datas.Text = janeiro;
                    break;
                case 1:
                    lb_datas.Text = fevereiro;
                    break;
                case 2:
                    lb_datas.Text = marco;
                    break;
                case 3:
                    lb_datas.Text = abril;
                    break;
                case 4:
                    lb_datas.Text = maio;
                    break;
                case 5:
                    lb_datas.Text = junho;
                    break;
                case 6:
                    lb_datas.Text = julho;
                    break;
                case 7:
                    lb_datas.Text = agosto;
                    break;
                case 8:
                    lb_datas.Text = setembro;
                    break;
                case 9:
                    lb_datas.Text = outubro;
                    break;
                case 10:
                    lb_datas.Text = novembro;
                    break;
                case 11:
                    lb_datas.Text = dezembro;
                    break;

                default:
                    break;
            }
        }

        private void bt_datas_direita_Click(object sender, EventArgs e)
        {
            datas++;

            if(datas == 12)
            {
                datas = 0;
            }

            MesEvento();
        }

        private void bt_datas_esquerda_Click(object sender, EventArgs e)
        {
            datas--;

            if (datas == -1)
            {
                datas = 11;
            }

            MesEvento();
        }
        #endregion

        private void novo_evento_Load(object sender, EventArgs e)
        {
            TabelaEvento();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }        
    }
}
