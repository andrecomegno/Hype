using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hype.script;
using Hype.Painel.Home;

namespace Hype.Painel.Eventos
{
    public partial class doacao : UserControl
    {
        // ID`S
        string id_membro = eventos.Instance.id_membro;
        string id_doacao;
        string id_eventos;

        // DOAÇÃO
        string _total;
        string titulo;
        int _doacao = 1;
        bool _editarDoacao = false;

        // SELECIONAR CLA 
        public string nome_cla = lista_clas.Instance.nome_cla;        

        public doacao()
        {
            InitializeComponent();
        }

        private void Semanas()
        {
            switch (_doacao)
            {
                case 1:
                    DoacaoSemana_01();
                    break;
                case 2:
                    DoacaoSemana_02();
                    break;
                case 3:
                    DoacaoSemana_03();
                    break;
                case 4:
                    DoacaoSemana_04();
                    break;
            }
        }

        #region TABELAS
        private void TabelaEvento()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, d.ID_DOACAO, eve.ID_EVENTOS, cl.NOME_CLA, eve.ANO_EVENTO, eve.MES_EVENTO, c.NICK, d.SEMANA_01, d.SEMANA_02, d.SEMANA_03, d.SEMANA_04, d.TOTAL, d.ANOTACAO from hypedb.cadastro_membro c join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_RECRUTAMENTO join hypedb.doacao d on d.ID_MEMBROS = c.ID_MEMBROS join hypedb.eventos eve on eve.ID_EVENTOS = d.ID_EVENTOS join hypedb.cadastro_cla cl on cl.ID_CLA = re.ID_CLA where c.ID_MEMBROS like '"+ id_membro +"' ", database.getConnection());

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
            dataGridView1.Columns[1].Visible = false; // ID_DOACAO
            dataGridView1.Columns[2].Visible = false; // ID_EVENTOS
            dataGridView1.Columns[3].Visible = false; // NOME_CLA
            dataGridView1.Columns[4].HeaderText = "ANO";
            dataGridView1.Columns[5].HeaderText = "MÊS";
            dataGridView1.Columns[6].HeaderText = "NICK";
            dataGridView1.Columns[7].HeaderText = "SEMANA 01";
            dataGridView1.Columns[8].HeaderText = "SEMANA 02";
            dataGridView1.Columns[9].HeaderText = "SEMANA 03";
            dataGridView1.Columns[10].HeaderText = "SEMANA 04";
            dataGridView1.Columns[11].Visible = false; // TOTAL
            dataGridView1.Columns[12].Visible = false; // ANOTACAO

            dataGridView1.Columns["MES_EVENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["SEMANA_01"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["SEMANA_02"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["SEMANA_03"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["SEMANA_04"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
                // ATIVA A EDIÇÃO
                _editarDoacao = true;
                // TITULO DA TABELA DOAÇÃO
                titulo = dataGridView1.Columns[e.ColumnIndex].HeaderCell.Value.ToString();

                Editar();
            }
        }

        private void Editar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // CARREGA OS DADOS DOS MEMBROS CONTA_MEMBROS.CS AO CLICAR NA TABELA
                DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

                // ID`S
                id_doacao = dr["ID_DOACAO"].ToString();
                id_membro = dr["ID_MEMBROS"].ToString();
                id_eventos = dr["ID_EVENTOS"].ToString();

                // CARREGA TODOS OS DADOS 
                txt_doacao_01.Texts = dr["SEMANA_01"].ToString();
                txt_doacao_02.Texts = dr["SEMANA_02"].ToString();
                txt_doacao_03.Texts = dr["SEMANA_03"].ToString();
                txt_doacao_04.Texts = dr["SEMANA_04"].ToString();

                // COMPARACAO DA TAG DENTRO DO CAMPO TEXTO COM O TITULO DA TABELA 
                if (String.Equals(txt_doacao_01.Tag, titulo))
                {
                    // IMPEDI A EDICÃO SE O CAMPO FOR VAZIO
                    if (String.IsNullOrEmpty(txt_doacao_01.Texts))
                    {
                        MessageBox.Show("NAO TEM O QUE EDITAR");
                    }
                    else
                    {
                        // PASSA O VALOR DOADO AO CAMPO TEXTO
                        txt_doacao_01.Texts = dr["SEMANA_01"].ToString();
                        // HABILITA O CAMPO DOACAO DA SEMANA
                        CampoDoacao(lb_semana_01, txt_doacao_01, lb_semana_02, txt_doacao_02, lb_semana_03, txt_doacao_03, lb_semana_04, txt_doacao_04);
                        // SEMANAS
                        _doacao = 1;
                    }
                }
                else if (String.Equals(txt_doacao_02.Tag, titulo))
                {
                    if (String.IsNullOrEmpty(txt_doacao_02.Texts))
                    {
                        MessageBox.Show("NAO TEM O QUE EDITAR");
                    }
                    else
                    {
                        txt_doacao_02.Texts = dr["SEMANA_02"].ToString();
                        CampoDoacao(lb_semana_02, txt_doacao_02, lb_semana_01, txt_doacao_01, lb_semana_03, txt_doacao_03, lb_semana_04, txt_doacao_04);
                        _doacao = 2;
                    }
                }
                else if (String.Equals(txt_doacao_03.Tag, titulo))
                {
                    if (String.IsNullOrEmpty(txt_doacao_03.Texts))
                    {
                        MessageBox.Show("NAO TEM O QUE EDITAR");
                    }
                    else
                    {
                        txt_doacao_03.Texts = dr["SEMANA_03"].ToString();
                        CampoDoacao(lb_semana_03, txt_doacao_03, lb_semana_01, txt_doacao_01, lb_semana_02, txt_doacao_02, lb_semana_04, txt_doacao_04);
                        _doacao = 3;
                    }
                }
                else if (String.Equals(txt_doacao_04.Tag, titulo))
                {
                    if (String.IsNullOrEmpty(txt_doacao_04.Texts))
                    {
                        MessageBox.Show("NAO TEM O QUE EDITAR");
                    }
                    else
                    {
                        txt_doacao_04.Texts = dr["SEMANA_04"].ToString();
                        CampoDoacao(lb_semana_04, txt_doacao_04, lb_semana_02, txt_doacao_02, lb_semana_01, txt_doacao_01, lb_semana_03, txt_doacao_03);
                        _doacao = 4;
                    }
                }
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

        private void AtualizarTabela()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, d.ID_DOACAO, eve.ID_EVENTOS, cl.NOME_CLA, eve.ANO_EVENTO, eve.MES_EVENTO, c.NICK, d.SEMANA_01, d.SEMANA_02, d.SEMANA_03, d.SEMANA_04, d.TOTAL, d.ANOTACAO from hypedb.cadastro_membro c join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_RECRUTAMENTO join hypedb.doacao d on d.ID_MEMBROS = c.ID_MEMBROS join hypedb.eventos eve on eve.ID_EVENTOS = d.ID_EVENTOS join hypedb.cadastro_cla cl on cl.ID_CLA = re.ID_CLA where c.ID_MEMBROS like '" + id_membro + "' ", database.getConnection());

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
        }

        private void Dados()
        {
            // QUANDO NÃO TEM NENHUMA DOAÇÃO
            if (dataGridView1.Rows.Count == 0)
            {
                // HABILITA O PRIMEIRO CAMPO SEMANA 1 PARA DOAÇÃO
                CampoDoacao(lb_semana_01, txt_doacao_01, lb_semana_02, txt_doacao_02, lb_semana_03, txt_doacao_03, lb_semana_04, txt_doacao_04);
                // ATRIBUI DOAÇÃO EM UM - Semanas()
                _doacao = 1;
            }

            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, d.ID_DOACAO, eve.ID_EVENTOS, cl.NOME_CLA, eve.ANO_EVENTO, eve.MES_EVENTO, c.NICK, d.SEMANA_01, d.SEMANA_02, d.SEMANA_03, d.SEMANA_04, d.TOTAL, d.ANOTACAO from hypedb.cadastro_membro c join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_RECRUTAMENTO join hypedb.doacao d on d.ID_MEMBROS = c.ID_MEMBROS join hypedb.eventos eve on eve.ID_EVENTOS = d.ID_EVENTOS join hypedb.cadastro_cla cl on cl.ID_CLA = re.ID_CLA where c.ID_MEMBROS like '" + id_membro + "' ", database.getConnection());

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // ID`S
                id_membro = dr["ID_MEMBROS"].ToString();
                id_doacao = dr["ID_DOACAO"].ToString();
                id_eventos = dr["ID_EVENTOS"].ToString();

                // STRING CRIADA PARA VERIFICAR SEMANAS DOADAS
                string doacao_01 = dr["SEMANA_01"].ToString();
                string doacao_02 = dr["SEMANA_02"].ToString();
                string doacao_03 = dr["SEMANA_03"].ToString();
                string doacao_04 = dr["SEMANA_04"].ToString();

                // VERIFICA SE DOACAO ESTÁ VAZIA
                if (String.IsNullOrEmpty(doacao_01))
                {
                    //PRIMEIRA DOAÇÃO NÃO CARREGA DADOS NO TEXTOBOX

                    // HABILITA O PRIMEIRO CAMPO SEMANA 1 PARA DOAÇÃO
                    CampoDoacao(lb_semana_01, txt_doacao_01, lb_semana_02, txt_doacao_02, lb_semana_03, txt_doacao_03, lb_semana_04, txt_doacao_04);
                    // ATRIBUI DOAÇÃO EM UM - Semanas()
                    _doacao = 1;
                }
                else if (String.IsNullOrEmpty(doacao_02))
                {
                    // CARREGAR DADOS NO TEXTOBOX
                    txt_doacao_01.Texts = dr["SEMANA_01"].ToString();
                    txt_doacao_03.Texts = dr["SEMANA_03"].ToString();
                    txt_doacao_04.Texts = dr["SEMANA_04"].ToString();

                    // LIMPA DADOS ANTIGOS CARREGADOS
                    txt_doacao_02.Texts = string.Empty;

                    CampoDoacao(lb_semana_02, txt_doacao_02, lb_semana_01, txt_doacao_01, lb_semana_03, txt_doacao_03, lb_semana_04, txt_doacao_04);
                    _doacao = 2;
                }
                else if (String.IsNullOrEmpty(doacao_03))
                {
                    txt_doacao_01.Texts = dr["SEMANA_01"].ToString();
                    txt_doacao_02.Texts = dr["SEMANA_02"].ToString();
                    txt_doacao_04.Texts = dr["SEMANA_04"].ToString();

                    txt_doacao_03.Texts = string.Empty;

                    CampoDoacao(lb_semana_03, txt_doacao_03, lb_semana_01, txt_doacao_01, lb_semana_02, txt_doacao_02, lb_semana_04, txt_doacao_04);
                    _doacao = 3;
                }
                else if (String.IsNullOrEmpty(doacao_04))
                {
                    txt_doacao_01.Texts = dr["SEMANA_01"].ToString();
                    txt_doacao_02.Texts = dr["SEMANA_02"].ToString();
                    txt_doacao_03.Texts = dr["SEMANA_03"].ToString();

                    txt_doacao_04.Texts = string.Empty;

                    CampoDoacao(lb_semana_04, txt_doacao_04, lb_semana_01, txt_doacao_01, lb_semana_02, txt_doacao_02, lb_semana_03, txt_doacao_03);
                    _doacao = 4;
                }
                else
                {
                    // LIMPA TODOS OS DADOS ANTIGOS CARREGADOS
                    Limpar();

                    // DEPOIS DE DOAR TODAS AS SEMANAS COMEÇA A SEMANA 1
                    CampoDoacao(lb_semana_01, txt_doacao_01, lb_semana_02, txt_doacao_02, lb_semana_03, txt_doacao_03, lb_semana_04, txt_doacao_04);
                    _doacao = 1;
                }
            }

            database.closeConnection();            
        }
        #endregion

        #region ALERTAS
        private void DoacaoSemana_01()
        {
            if (String.IsNullOrEmpty(txt_doacao_01.Texts))
            {
                txt_doacao_01.BorderColor = Color.Red;
                txt_doacao_01.BorderSize = 3;
            }
            else if (conftext.IsNumero(txt_doacao_01.Texts) == false)
            {
                txt_doacao_01.BorderColor = Color.Red;
                txt_doacao_01.BorderSize = 3;

                MessageBox.Show("Somente Numeros !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Semana_01();
                }
                finally
                {
                    AtualizarTabela();
                }
            }
        }

        private void DoacaoSemana_02()
        {
            if (String.IsNullOrEmpty(txt_doacao_02.Texts))
            {
                txt_doacao_02.BorderColor = Color.Red;
                txt_doacao_02.BorderSize = 3;
            }
            else if (conftext.IsNumero(txt_doacao_02.Texts) == false)
            {
                txt_doacao_02.BorderColor = Color.Red;
                txt_doacao_02.BorderSize = 3;

                MessageBox.Show("Somente Numeros !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Semana_02();
                }
                finally
                {
                    AtualizarTabela();
                }
            }
        }

        private void DoacaoSemana_03()
        {
            if (String.IsNullOrEmpty(txt_doacao_03.Texts))
            {
                txt_doacao_03.BorderColor = Color.Red;
                txt_doacao_03.BorderSize = 3;
            }
            else if (conftext.IsNumero(txt_doacao_03.Texts) == false)
            {
                txt_doacao_03.BorderColor = Color.Red;
                txt_doacao_03.BorderSize = 3;

                MessageBox.Show("Somente Numeros !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Semana_03();
                }
                finally
                {
                    AtualizarTabela();
                }
            }
        }

        private void DoacaoSemana_04()
        {
            if (String.IsNullOrEmpty(txt_doacao_04.Texts))
            {
                txt_doacao_04.BorderColor = Color.Red;
                txt_doacao_04.BorderSize = 3;
            }
            else if (conftext.IsNumero(txt_doacao_04.Texts) == false)
            {
                txt_doacao_04.BorderColor = Color.Red;
                txt_doacao_04.BorderSize = 3;

                MessageBox.Show("Somente Numeros !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Semana_04();
                }
                finally
                {
                    AtualizarTabela();
                }
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
                Semanas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }            
        }

        private void Semana_01()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            try
            {
                // SE EDITAR FDR VERDADEIRO
                if (_editarDoacao)
                {
                    // UPDATE TABELA DOAÇÃO 01
                    MySqlCommand objCmdDoacao = new MySqlCommand("update hypedb.doacao set semana_01=@semana_01 where (id_doacao=@id_doacao) and (id_eventos=@id_eventos) and (id_membros=@id_membros)", database.getConnection());

                    objCmdDoacao.Parameters.AddWithValue("@id_doacao", id_doacao);
                    objCmdDoacao.Parameters.AddWithValue("@id_eventos", id_eventos);
                    objCmdDoacao.Parameters.AddWithValue("@id_membros", id_membro);
                    objCmdDoacao.Parameters.Add("@semana_01", MySqlDbType.Decimal).Value = txt_doacao_01.Texts;

                    objCmdDoacao.ExecuteNonQuery();                    

                    MessageBox.Show("Doação Efetuada Com Sucesso !", "Semana 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    double de = (Convert.ToDouble(txt_doacao_01.Texts));
                    _total = de.ToString();

                    // INSERT TABELA EVENTOS
                    MySqlCommand objCmdEventos = new MySqlCommand("insert into hypedb.eventos (id_eventos, mes_evento, ano_evento, id_membros) values (null, ?, ?, ?)", database.getConnection());

                    objCmdEventos.Parameters.Add("@mes_evento", MySqlDbType.VarChar, 256).Value = DateTime.Now.ToString("MMMM");
                    objCmdEventos.Parameters.Add("@ano_evento", MySqlDbType.Year).Value = DateTime.Now.Year;
                    objCmdEventos.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = id_membro;

                    objCmdEventos.ExecuteNonQuery();
                    id_eventos = objCmdEventos.LastInsertedId.ToString();

                    // INSERT TABELA DOAÇÃO
                    MySqlCommand objCmdDoacao = new MySqlCommand("insert into hypedb.doacao (id_doacao, semana_01, semana_02, semana_03, semana_04, total, anotacao, id_eventos, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

                    objCmdDoacao.Parameters.Add("@semana_01", MySqlDbType.Decimal).Value = txt_doacao_01.Texts;
                    objCmdDoacao.Parameters.Add("@semana_02", MySqlDbType.Decimal).Value = null;
                    objCmdDoacao.Parameters.Add("@semana_03", MySqlDbType.Decimal).Value = null;
                    objCmdDoacao.Parameters.Add("@semana_04", MySqlDbType.Decimal).Value = null;
                    objCmdDoacao.Parameters.Add("@total", MySqlDbType.Decimal).Value = _total;
                    objCmdDoacao.Parameters.Add("@anotacao", MySqlDbType.VarChar, 256).Value = "";
                    objCmdDoacao.Parameters.Add("@id_eventos", MySqlDbType.Int32).Value = id_eventos;
                    objCmdDoacao.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = id_membro;

                    objCmdDoacao.ExecuteNonQuery();
                    id_doacao = objCmdDoacao.LastInsertedId.ToString();

                    MessageBox.Show("Doação Efetuada Com Sucesso !", "Semana 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                // SE EDITAR FDR VERDADEIRO
                if (_editarDoacao)
                {
                    try
                    {
                        // CARREGA OS DADOS NOVAMENTE 
                        Dados();
                    }
                    finally
                    {
                        _editarDoacao = false;
                    }
                }
                else
                {
                    // HABILITAR OS CAMPOS TEXTOS
                    CampoDoacao(lb_semana_02, txt_doacao_02, lb_semana_01, txt_doacao_01, lb_semana_03, txt_doacao_03, lb_semana_04, txt_doacao_04);
                    // SEMANAS +1
                    _doacao++;
                }                
            }

            database.closeConnection();
        }

        private void Semana_02()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            try
            {
                double de = (Convert.ToDouble(txt_doacao_01.Texts) + Convert.ToDouble(txt_doacao_02.Texts));
                _total = de.ToString();

                // UPDATE TABELA DOAÇÃO 02
                MySqlCommand objCmdDoacao = new MySqlCommand("update hypedb.doacao set semana_01=@semana_01, semana_02=@semana_02, total=@total where (id_doacao=@id_doacao) and (id_eventos=@id_eventos) and (id_membros=@id_membros)", database.getConnection());

                objCmdDoacao.Parameters.AddWithValue("@id_doacao", id_doacao);
                objCmdDoacao.Parameters.AddWithValue("@id_eventos", id_eventos);
                objCmdDoacao.Parameters.AddWithValue("@id_membros", id_membro);
                objCmdDoacao.Parameters.Add("@semana_01", MySqlDbType.Decimal).Value = txt_doacao_01.Texts;
                objCmdDoacao.Parameters.Add("@semana_02", MySqlDbType.Decimal).Value = txt_doacao_02.Texts;
                objCmdDoacao.Parameters.Add("@total", MySqlDbType.Decimal).Value = _total;

                objCmdDoacao.ExecuteNonQuery();

                MessageBox.Show("Doação Efetuada Com Sucesso !", "Semana 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (_editarDoacao)
                {
                    try
                    {
                        Dados();
                    }
                    finally
                    {
                        _editarDoacao = false;
                    }
                }
                else
                {
                    CampoDoacao(lb_semana_03, txt_doacao_03, lb_semana_01, txt_doacao_01, lb_semana_02, txt_doacao_02, lb_semana_04, txt_doacao_04);
                    _doacao++;
                }
            }

            database.closeConnection();
        }

        private void Semana_03()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            try
            {
                double de = (Convert.ToDouble(txt_doacao_01.Texts) + Convert.ToDouble(txt_doacao_02.Texts) + Convert.ToDouble(txt_doacao_03.Texts));
                _total = de.ToString();

                // UPDATE TABELA DOAÇÃO 03
                MySqlCommand objCmdDoacao = new MySqlCommand("update hypedb.doacao set semana_01=@semana_01, semana_02=@semana_02, semana_03=@semana_03, total=@total where (id_doacao=@id_doacao) and (id_eventos=@id_eventos) and (id_membros=@id_membros)", database.getConnection());

                objCmdDoacao.Parameters.AddWithValue("@id_doacao", id_doacao);
                objCmdDoacao.Parameters.AddWithValue("@id_eventos", id_eventos);
                objCmdDoacao.Parameters.AddWithValue("@id_membros", id_membro);
                objCmdDoacao.Parameters.Add("@semana_01", MySqlDbType.Decimal).Value = txt_doacao_01.Texts;
                objCmdDoacao.Parameters.Add("@semana_02", MySqlDbType.Decimal).Value = txt_doacao_02.Texts;
                objCmdDoacao.Parameters.Add("@semana_03", MySqlDbType.Decimal).Value = txt_doacao_03.Texts;
                objCmdDoacao.Parameters.Add("@total", MySqlDbType.Decimal).Value = _total;

                objCmdDoacao.ExecuteNonQuery();

                MessageBox.Show("Doação Efetuada Com Sucesso !", "Semana 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (_editarDoacao)
                {
                    try
                    {
                        Dados();
                    }
                    finally
                    {
                        //txt_doacao_03.Texts = string.Empty;
                        _editarDoacao = false;
                    }                    
                }
                else
                {
                    CampoDoacao(lb_semana_04, txt_doacao_04, lb_semana_01, txt_doacao_01, lb_semana_02, txt_doacao_02, lb_semana_03, txt_doacao_03);
                    _doacao++;
                }
            }

            database.closeConnection();
        }

        private void Semana_04()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            try
            {
                double de = (Convert.ToDouble(txt_doacao_01.Texts) + Convert.ToDouble(txt_doacao_02.Texts) + Convert.ToDouble(txt_doacao_03.Texts) + Convert.ToDouble(txt_doacao_04.Texts));
                _total = de.ToString();

                // UPDATE TABELA DOAÇÃO 04
                MySqlCommand objCmdDoacao = new MySqlCommand("update hypedb.doacao set semana_01=@semana_01, semana_02=@semana_02, semana_03=@semana_03, semana_04=@semana_04, total=@total where (id_doacao=@id_doacao) and (id_eventos=@id_eventos) and (id_membros=@id_membros)", database.getConnection());

                objCmdDoacao.Parameters.AddWithValue("@id_doacao", id_doacao);
                objCmdDoacao.Parameters.AddWithValue("@id_eventos", id_eventos);
                objCmdDoacao.Parameters.AddWithValue("@id_membros", id_membro);
                objCmdDoacao.Parameters.Add("@semana_01", MySqlDbType.Decimal).Value = txt_doacao_01.Texts;
                objCmdDoacao.Parameters.Add("@semana_02", MySqlDbType.Decimal).Value = txt_doacao_02.Texts;
                objCmdDoacao.Parameters.Add("@semana_03", MySqlDbType.Decimal).Value = txt_doacao_03.Texts;
                objCmdDoacao.Parameters.Add("@semana_04", MySqlDbType.Decimal).Value = txt_doacao_04.Texts;
                objCmdDoacao.Parameters.Add("@total", MySqlDbType.Decimal).Value = _total;

                objCmdDoacao.ExecuteNonQuery();

                MessageBox.Show("Doação Efetuada Com Sucesso !", "Semana 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (_editarDoacao)
                {
                    try
                    {
                        Dados();
                    }
                    finally
                    {
                        //txt_doacao_04.Texts = string.Empty;
                        _editarDoacao = false;
                    }
                }
                else
                {
                    try
                    {
                        CampoDoacao(lb_semana_01, txt_doacao_01, lb_semana_02, txt_doacao_02, lb_semana_03, txt_doacao_03, lb_semana_04, txt_doacao_04);
                        // RETORNA DOAÇÃO 1
                        _doacao = 1;
                    }
                    finally
                    {
                        // LIMPA A CAMPO DE TEXTO
                        Limpar();
                    }
                }
            }

            database.closeConnection();
        }
        #endregion

        #region CAMPO TEXTO
        private void Limpar()
        {
            txt_doacao_01.Texts = string.Empty;
            txt_doacao_02.Texts = string.Empty;
            txt_doacao_03.Texts = string.Empty;
            txt_doacao_04.Texts = string.Empty;
        }

        private void CampoDoacao(Label lb1, RJTextBox text1, Label lb2, RJTextBox text2, Label lb3, RJTextBox text3, Label lb4, RJTextBox text4)
        {
            lb1.ForeColor = Color.White;
            text1.BackColor = Color.White;
            text4.ForeColor = Color.FromArgb(64, 64, 64);
            text1.Enabled = true;

            lb2.ForeColor = Color.FromArgb(24, 25, 28);
            text2.BackColor = Color.FromArgb(24, 25, 28);
            text2.ForeColor = Color.FromArgb(24, 25, 28);
            text2.Enabled = false;

            lb3.ForeColor = Color.FromArgb(24, 25, 28);
            text3.BackColor = Color.FromArgb(24, 25, 28);
            text3.ForeColor = Color.FromArgb(24, 25, 28);
            text3.Enabled = false;

            lb4.ForeColor = Color.FromArgb(24, 25, 28);
            text4.BackColor = Color.FromArgb(24, 25, 28);
            text4.ForeColor = Color.FromArgb(24, 25, 28);
            text4.Enabled = false;
        }

        private void txt_doacao_01_Enter(object sender, EventArgs e)
        {
            txt_doacao_01.BorderSize = 1;
        }

        private void txt_doacao_02_Enter(object sender, EventArgs e)
        {
            txt_doacao_02.BorderSize = 1;
        }

        private void txt_doacao_03_Enter(object sender, EventArgs e)
        {
            txt_doacao_03.BorderSize = 1;
        }

        private void txt_doacao_04_Enter(object sender, EventArgs e)
        {
            txt_doacao_04.BorderSize = 1;
        }

        private void txt_doacao_01_Leave(object sender, EventArgs e)
        {
            txt_doacao_01.BorderColor = Color.Transparent;
            txt_doacao_01.BorderSize = 0;
        }

        private void txt_doacao_02_Leave(object sender, EventArgs e)
        {
            txt_doacao_02.BorderColor = Color.Transparent;
            txt_doacao_02.BorderSize = 0;
        }

        private void txt_doacao_03_Leave(object sender, EventArgs e)
        {
            txt_doacao_03.BorderColor = Color.Transparent;
            txt_doacao_03.BorderSize = 0;
        }

        private void txt_doacao_04_Leave(object sender, EventArgs e)
        {
            txt_doacao_04.BorderColor = Color.Transparent;
            txt_doacao_04.BorderSize = 0;
        }
        #endregion

        private void novo_evento_Load(object sender, EventArgs e)
        {
            Dados();
            TabelaEvento();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }
    }
}
