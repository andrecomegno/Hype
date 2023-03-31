using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Hype.Painel.Home;
using Hype.script;
using MySql.Data.MySqlClient;

namespace Hype.Painel
{
    public partial class conta_alt : UserControl
    {
        // ID`S
        string id_alt = alts.Instance.id_alt;
        string id_membros = alts.Instance.id_membro;

        bool _editarConta = false;

        // SELECIONAR CLA 
        public string nome_cla = home.Instance.nome_cla;

        public conta_alt()
        {
            InitializeComponent();

            lb_saida.Text = DateTime.Now.ToString("d");

            CampoTextoDesativado(pl_conta_principal.Controls);
        }

        #region TABELAS
        private void TabelaALT()
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

            database.closeConnection();

            TabelaContaALT();
        }

        private void TabelaContaALT()
        {
            dataGridView1.Columns[0].Visible = false; // ID_ALT
            dataGridView1.Columns[1].Visible = false; // DATA_ALT
            dataGridView1.Columns[2].HeaderText = "NICK";
            dataGridView1.Columns[3].HeaderText = "LEVEL";
            dataGridView1.Columns[4].HeaderText = "CLASSE";
            dataGridView1.Columns[5].HeaderText = "CLÃ";
            dataGridView1.Columns[6].Visible = false; // STATUS_ALT;
            dataGridView1.Columns[7].Visible = false; // NOME_CLA;
            dataGridView1.Columns[8].Visible = false; // ID_MEMBROS;

            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;

            // ADICIONA A CAIXA DE SELECAO NA TABELA 
            DataGridViewCheckBoxColumn selecionar = new DataGridViewCheckBoxColumn();
            selecionar.Name = "SELECIONAR";
            selecionar.DataPropertyName = "SELECIONAR";
            selecionar.HeaderText = "";

            dataGridView1.Columns.Insert(0, selecionar);

            dataGridView1.Columns["LEVEL_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CLASSE_ALT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "NICK_ALT")
                    column.Width = 220;
                else if (column.DataPropertyName == "LEVEL_ALT")
                    column.Width = 80;
                else if (column.DataPropertyName == "CLASSE_ALT")
                    column.Width = 100;
                else if (column.DataPropertyName == "CLA_ALT")
                    column.Width = 185;
                else if (column.DataPropertyName == "SELECIONAR")
                    column.Width = 30;
            }
        }

        // ATUALIZA A TABELA ALT 
        private void AtualizarTabela()
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

            database.closeConnection();
        }

        private void EditarContaALT()
        {
            try
            {
                // EDITAR CONTA ALT AO CLICAR NA TABELA 
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

                    // CARREGA DADOS DA ALT NA EDIÇÃO
                    id_alt = dr["ID_ALT"].ToString();
                    txt_nick_alt.Texts = dr["NICK_ALT"].ToString();
                    txt_level_alt.Texts = dr["LEVEL_ALT"].ToString();
                    txt_classe_alt.Texts = dr["CLASSE_ALT"].ToString();
                    txt_cla_alt.Texts = dr["CLA_ALT"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        // CARREGAR DADOS DA CONTA PRINCIPAL
        public void DadosMembros()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.DATA_RECRUTAMENTO, c.NICK, c.LEVEL, c.PODER, c.CLASSE, c.PATENTE, c.STATUS, re.ID_RECRUTAMENTO, re.VEM_DO_CLA, re.FOI_PARA_CLA, cl.NOME_CLA from hypedb.cadastro_membro c left join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_MEMBROS left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_RECRUTAMENTO left join hypedb.cadastro_cla cl on cl.ID_CLA = re.ID_CLA where c.ID_MEMBROS = '"+ id_membros +"' ", database.getConnection());

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_nick.Texts = dr["NICK"].ToString();
                txt_level.Texts = dr["LEVEL"].ToString();
                txt_poder.Texts = dr["PODER"].ToString();
                txt_classe.Texts = dr["CLASSE"].ToString();
                txt_patente.Texts = dr["PATENTE"].ToString();
                txt_esta_cla.Texts = dr["FOI_PARA_CLA"].ToString();
            }

            database.closeConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["SELECIONAR"].Index)
            {
                //INTERROMPE A EDICAO NO dataGridView1
                dataGridView1.EndEdit();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                EditarContaALT();
                _editarConta = true;
            }
        }
        #endregion

        #region BOTOES 
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Alertas();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                TabelaALT();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                Voltar();
            }
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Tem Certeza Que Deseja Excluir ?", "AVISO !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        ExcluirConta();
                        break;
                    case DialogResult.No:

                        break;
                    default:
                        break;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                Voltar();
            }
        }

        private void ExcluirConta()
        {
            configdb database = new configdb();
            database.openConnection();

            try
            {
                // QUANDO TIVER ALT CADASTRADA 
                if (dataGridView1.Visible == true)
                {
                    // VERIFICA SE O CHECKBOX ESTA SELECIONADO COMO VERDADEIRO, NA CELL ZERO 
                    if (bool.Parse(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString()) == true)
                    {
                        foreach (DataGridViewRow check in dataGridView1.Rows)
                        {
                            // PEGA TODOS OS VALORES SELECIONADOS NA CELLS, O ZERO QUE REPRESENTA O CHECKBOX
                            if (bool.Parse(check.Cells[0].EditedFormattedValue.ToString()))
                            {
                                // EXCLUIR ALT
                                MySqlCommand objCmdCadastroAlt = new MySqlCommand("delete from hypedb.cadastro_alt where id_alt=@id_alt", database.getConnection());
                                objCmdCadastroAlt.Parameters.AddWithValue("@id_alt", check.Cells[1].Value.ToString()); // TODOS OS ID`S SELECIONADOS

                                objCmdCadastroAlt.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }

            database.closeConnection();
        }

        private void Voltar()
        {
            alts uc = new alts();
            cla.Instance.addControl(uc);
        }

        private void Salvar()
        {
            try
            {
                // BANCO DE DADOS
                configdb database = new configdb();
                database.openConnection();

                if (_editarConta)
                {
                    // CADASTRO DE MEMBROS
                    MySqlCommand objCmdCadastroAlt = new MySqlCommand("update hypedb.cadastro_alt set nick_alt=@nick_alt, level_alt=@level_alt, classe_alt=@classe_alt, cla_alt=@cla_alt where (ID_ALT=@ID_ALT)", database.getConnection());

                    objCmdCadastroAlt.Parameters.AddWithValue("@ID_ALT", id_alt);
                    objCmdCadastroAlt.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt.Texts;
                    objCmdCadastroAlt.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt.Texts;
                    objCmdCadastroAlt.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt.Texts;
                    objCmdCadastroAlt.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_cla_alt.Texts;

                    objCmdCadastroAlt.ExecuteNonQuery();

                    DialogResult dr = MessageBox.Show("Editado Sucesso !", "CONTA ALT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Selecione Uma Conta, Com Duplo Clique =)", "SELECIONAR CONTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                database.closeConnection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }
        #endregion

        #region ALERTAS
        private void Alertas()
        {
            if (String.IsNullOrEmpty(txt_nick_alt.Texts))
            {
                txt_nick_alt.BorderColor = Color.Red;
                txt_nick_alt.BorderSize = 3;
            }
            else if (String.IsNullOrEmpty(txt_level_alt.Texts))
            {
                txt_level_alt.BorderColor = Color.Red;
                txt_level_alt.BorderSize = 3;
            }
            else if (conftext.IsNumero(txt_level_alt.Texts) == false)
            {
                txt_level_alt.BorderColor = Color.Red;
                txt_level_alt.BorderSize = 3;

                MessageBox.Show("Somente Numeros !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txt_classe_alt.Texts))
            {
                txt_classe_alt.BorderColor = Color.Red;
                txt_classe_alt.BorderSize = 3;
            }
            else if (String.IsNullOrEmpty(txt_cla_alt.Texts))
            {
                txt_cla_alt.BorderColor = Color.Red;
                txt_cla_alt.BorderSize = 1;
            }
            else
            {
                try
                {
                    Salvar();
                }
                finally
                {
                    AtualizarTabela();
                    LimparCampos(pl_editar_alt.Controls);
                }
            }
        }
        #endregion

        #region CAMPO TEXTO
        private void txt_nick_alt_Enter(object sender, EventArgs e)
        {
            txt_nick_alt.BorderSize = 1;
        }

        private void txt_nick_alt_Leave(object sender, EventArgs e)
        {
            txt_nick_alt.BorderColor = Color.Transparent;
            txt_nick_alt.BorderSize = 0;
        }

        private void txt_level_alt_Enter(object sender, EventArgs e)
        {
            txt_level_alt.BorderSize = 1;
        }

        private void txt_level_alt_Leave(object sender, EventArgs e)
        {
            txt_level_alt.BorderColor = Color.Transparent;
            txt_level_alt.BorderSize = 0;
        }

        private void txt_classe_alt_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe_alt.SelectedIndex > 0)
            {
                txt_classe_alt.BorderColor = Color.Transparent;
                txt_classe_alt.BorderSize = 0;
            }
        }

        private void txt_cla_alt_Enter(object sender, EventArgs e)
        {
            txt_cla_alt.BorderSize = 1;
        }

        private void txt_cla_alt_Leave(object sender, EventArgs e)
        {
            txt_cla_alt.BorderColor = Color.Transparent;
            txt_cla_alt.BorderSize = 0;
        }

        private void CampoTextoDesativado(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)c).Enabled = false;
                    ((RJTextBox)c).BackColor = Color.LightGray;
                }
            }
        }

        private void LimparCampos(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)c).Texts = string.Empty;                    
                }

                if (c is RJComboBox)
                {
                    ((RJComboBox)c).SelectedIndex = -1;
                }
            }

            _editarConta = false;
        }
        #endregion

        private void conta_alt_Load(object sender, EventArgs e)
        {
            DadosMembros();
            TabelaALT();

            dataGridView1.EnableHeadersVisualStyles = false;
        }


    }
}
