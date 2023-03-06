using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hype.Painel;
using Hype.script;
using MySql.Data.MySqlClient;

namespace Hype.Painel
{
    public partial class conta_principal : UserControl
    {
        // ID TABELA
        string id_membro = membros.Instance.id_membro;
        string id_recrutamento = membros.Instance.id_recrutamento;

        // PAINEIS
        bool _membro = true;
        bool _progressao = false;
        bool _remanejamento = false;

        public conta_principal()
        {
            InitializeComponent();
            CamposDesativados();

            lb_data_entrada.Text = membros.Instance.data_entrada;
        }

        #region BOTOES
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Alertas();
        } 

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarTabela();
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

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conta_excluir uc = new conta_excluir();
                cla.Instance.addControl(uc);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
            finally
            {
                AtualizarTabela();
            }
        }

        private void bt_adicionar_pro_Click(object sender, EventArgs e)
        {
            Alertas();
        }

        private void bt_editar_prog_Click(object sender, EventArgs e)
        {
            CampoTextoHabilitado(pl_pro_adicionar.Controls);

            TabelaHabilitada();

            bt_cancelar_prog.Visible = true;
            bt_editar_prog.Visible = false;
            bt_adicionar_prog.Visible = true;

            _progressao = true;
        }

        private void bt_cancelar_prog_Click(object sender, EventArgs e)
        {
            BtCancelarProg();
        }

        private void bt_editar_rema_Click(object sender, EventArgs e)
        {
            bt_cancelar_rema.Visible = true;
            bt_editar_rema.Visible = false;
            bt_ok_rema.Visible = true;
            lb_seta.Visible = true;
            txt_remanejamento.PlaceholderText = "Remanejamento";

            // DADOS MEMBROS
            txt_vem_cla_rema.Texts = membros.Instance.vem_do_cla;
            txt_esta_cla_rema.Texts = membros.Instance.foi_para_cla;

            _remanejamento = true;
            CampoTextoHabilitado(pl_remanejamento.Controls);

            // CAMPOS FIXO DESATIVAODS
            txt_vem_cla_rema.Enabled = false;
            txt_esta_cla_rema.Enabled = false;
            txt_vem_cla_rema.BackColor = Color.LightGray;
            txt_esta_cla_rema.BackColor = Color.LightGray;
        }

        private void bt_cancelar_rema_Click(object sender, EventArgs e)
        {
            BtCancelarRema();
        }

        private void bt_ok_rema_Click(object sender, EventArgs e)
        {
            Alertas();
        }

        private void BtCancelarProg()
        {
            bt_cancelar_prog.Visible = false;
            bt_editar_prog.Visible = true;
            bt_adicionar_prog.Visible = false;

            txt_novo_level.Texts = "";
            txt_novo_poder.Texts = "";

            txt_novo_level.BorderColor = Color.Transparent;
            txt_novo_level.BorderSize = 0;

            txt_novo_poder.BorderColor = Color.Transparent;
            txt_novo_poder.BorderSize = 0;

            _progressao = false;

            TabelaDesabilitada();

            CampoTextoDesativado(pl_pro_adicionar.Controls);
        }

        private void BtCancelarRema()
        {
            bt_cancelar_rema.Visible = false;
            bt_editar_rema.Visible = true;
            bt_ok_rema.Visible = false;
            lb_seta.Visible = false;
            txt_remanejamento.PlaceholderText = "";

            // DADOS MEMBROS
            txt_vem_cla_rema.Texts = "";
            txt_esta_cla_rema.Texts = "";            

            _remanejamento = false;
            CampoTextoDesativado(pl_remanejamento.Controls);
        }

        private void Salvar()
        {
            try
            {
                // BANCO DE DADOS
                configdb database = new configdb();
                database.openConnection();

                #region MEMBROS
                if (_membro && !_progressao && !_remanejamento)
                {
                    #region MEMBROS
                    // UPDATE MEMBROS
                    MySqlCommand objCmdCadastroMembros = new MySqlCommand("update hypedb.cadastro_membro set nick=@nick, classe=@classe, patente=@patente where (id_membros=@id_membros)", database.getConnection());

                    objCmdCadastroMembros.Parameters.AddWithValue("@id_membros", id_membro);
                    objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
                    //objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_novo_poder.Texts; // NOVO PODER
                    //objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_novo_level.Texts; // NOVO LEVEL
                    objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
                    objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;

                    objCmdCadastroMembros.ExecuteNonQuery();
                    #endregion

                    DialogResult dr = MessageBox.Show("Membro Atualizado Com Sucesso !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #endregion

                #region MEMBRO E PROGRESSÃO
                if (_membro && _progressao && !_remanejamento)
                {
                    #region MEMBROS
                    // UPDATE MEMBROS
                    MySqlCommand objCmdCadastroMembros = new MySqlCommand("update hypedb.cadastro_membro set nick=@nick, poder=@poder, level=@level, classe=@classe, patente=@patente where (id_membros=@id_membros)", database.getConnection());

                    objCmdCadastroMembros.Parameters.AddWithValue("@id_membros", id_membro);
                    objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
                    objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_novo_poder.Texts; // NOVO PODER
                    objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_novo_level.Texts; // NOVO LEVEL
                    objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
                    objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;

                    objCmdCadastroMembros.ExecuteNonQuery();
                    #endregion

                    #region PROGRESSÂO
                    // INTO PROGRESSÃO
                    MySqlCommand objCmdProgre = new MySqlCommand("insert into hypedb.progressao (id_progressao, data_progressao, antigo_level, antigo_poder, novo_level, novo_poder, id_membros) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

                    objCmdProgre.Parameters.Add("@data_progressao", MySqlDbType.Date).Value = DateTime.Now;
                    objCmdProgre.Parameters.Add("@atual_level", MySqlDbType.Int32).Value = txt_level.Texts;
                    objCmdProgre.Parameters.Add("@atual_poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
                    objCmdProgre.Parameters.Add("@novo_level", MySqlDbType.Int32).Value = txt_novo_level.Texts;
                    objCmdProgre.Parameters.Add("@novo_poder", MySqlDbType.Decimal).Value = txt_novo_poder.Texts;
                    objCmdProgre.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = id_membro;

                    objCmdProgre.ExecuteNonQuery();
                    #endregion

                    DialogResult dr = MessageBox.Show("Progressão Adicionada Com Sucesso !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #endregion

                #region MEMBRO E REMANEJAMENTO
                if (_membro && _remanejamento && !_progressao)
                {
                    #region MEMBROS
                    // UPDATE MEMBROS
                    MySqlCommand objCmdCadastroMembros = new MySqlCommand("update hypedb.cadastro_membro set nick=@nick, classe=@classe, patente=@patente where (id_membros=@id_membros)", database.getConnection());

                    objCmdCadastroMembros.Parameters.AddWithValue("@id_membros", id_membro);
                    objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
                    //objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_novo_poder.Texts; // NOVO PODER
                    //objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_novo_level.Texts; // NOVO LEVEL
                    objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
                    objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;

                    objCmdCadastroMembros.ExecuteNonQuery();
                    #endregion

                    #region REMANEJAMENTO
                    // REMANEJAMENTO INTO
                    MySqlCommand objCmdRemanejamento = new MySqlCommand("insert into hypedb.remanejamento (id_remanejamento, data_remanejamento, id_recrutamento) values (null, ?, ?)", database.getConnection());

                    objCmdRemanejamento.Parameters.Add("@data_remanejamento", MySqlDbType.Date).Value = DateTime.Now;
                    objCmdRemanejamento.Parameters.Add("@id_recrutamento", MySqlDbType.Int32).Value = id_recrutamento;

                    objCmdRemanejamento.ExecuteNonQuery();

                    // RECRUTAMENTO UPDATE
                    MySqlCommand objCmdRecrutamento = new MySqlCommand("update hypedb.recrutamento set foi_para_cla=@foi_para_cla where (id_recrutamento=@id_recrutamento)", database.getConnection());

                    objCmdRecrutamento.Parameters.AddWithValue("@id_recrutamento", id_recrutamento);
                    objCmdRecrutamento.Parameters.Add("@foi_para_cla", MySqlDbType.VarChar, 256).Value = txt_remanejamento.Texts;

                    objCmdRecrutamento.ExecuteNonQuery();
                    #endregion

                    DialogResult dr = MessageBox.Show("Remanejado com Sucesso !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                #endregion

                #region MEMBRO E PROGRESSÃO E REMANEJAMENTO
                if (_membro && _remanejamento && _progressao)
                {
                    #region MEMBROS
                    // UPDATE MEMBROS
                    MySqlCommand objCmdCadastroMembros = new MySqlCommand("update hypedb.cadastro_membro set nick=@nick, poder=@poder, level=@level, classe=@classe, patente=@patente where (id_membros=@id_membros)", database.getConnection());

                    objCmdCadastroMembros.Parameters.AddWithValue("@id_membros", id_membro);
                    objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
                    objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_novo_poder.Texts; // NOVO PODER
                    objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_novo_level.Texts; // NOVO LEVEL
                    objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
                    objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;

                    objCmdCadastroMembros.ExecuteNonQuery();
                    #endregion

                    #region PROGRESSÂO
                    // INTO PROGRESSÃO
                    MySqlCommand objCmdProgre = new MySqlCommand("insert into hypedb.progressao (id_progressao, data_progressao, antigo_level, antigo_poder, novo_level, novo_poder, id_membros) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

                    objCmdProgre.Parameters.Add("@data_progressao", MySqlDbType.Date).Value = DateTime.Now;
                    objCmdProgre.Parameters.Add("@atual_level", MySqlDbType.Int32).Value = txt_level.Texts;
                    objCmdProgre.Parameters.Add("@atual_poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
                    objCmdProgre.Parameters.Add("@novo_level", MySqlDbType.Int32).Value = txt_novo_level.Texts;
                    objCmdProgre.Parameters.Add("@novo_poder", MySqlDbType.Decimal).Value = txt_novo_poder.Texts;
                    objCmdProgre.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = id_membro;

                    objCmdProgre.ExecuteNonQuery();
                    #endregion

                    #region REMANEJAMENTO
                    // REMANEJAMENTO INTO
                    MySqlCommand objCmdRemanejamento = new MySqlCommand("insert into hypedb.remanejamento (id_remanejamento, data_remanejamento, id_recrutamento) values (null, ?, ?)", database.getConnection());

                    objCmdRemanejamento.Parameters.Add("@data_remanejamento", MySqlDbType.Date).Value = DateTime.Now;
                    objCmdRemanejamento.Parameters.Add("@id_recrutamento", MySqlDbType.Int32).Value = id_recrutamento;

                    objCmdRemanejamento.ExecuteNonQuery();

                    // RECRUTAMENTO UPDATE
                    MySqlCommand objCmdRecrutamento = new MySqlCommand("update hypedb.recrutamento set foi_para_cla=@foi_para_cla where (id_recrutamento=@id_recrutamento)", database.getConnection());

                    objCmdRecrutamento.Parameters.AddWithValue("@id_recrutamento", id_recrutamento);
                    objCmdRecrutamento.Parameters.Add("@foi_para_cla", MySqlDbType.VarChar, 256).Value = txt_remanejamento.Texts;

                    objCmdRecrutamento.ExecuteNonQuery();
                    #endregion

                    DialogResult dr = MessageBox.Show("Salvo Sucesso !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #endregion

                database.closeConnection();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        private void Voltar()
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void CamposDesativados()
        {
            txt_level.Enabled = false;
            txt_poder.Enabled = false;
            txt_esta_cla.Enabled = false;

            txt_level.BackColor = Color.LightGray;
            txt_poder.BackColor = Color.LightGray;
            txt_esta_cla.BackColor = Color.LightGray;

            bt_cancelar_prog.Visible = false;
            bt_adicionar_prog.Visible = false;
            bt_cancelar_rema.Visible = false;
            bt_ok_rema.Visible = false;
            lb_seta.Visible = false;

            TabelaDesabilitada();

            CampoTextoDesativado(pl_pro_adicionar.Controls);
            CampoTextoDesativado(pl_remanejamento.Controls);
        }
        #endregion

        #region CAMPO DO TEXTO EM BRANCO - ALERTAS
        private void Alertas()
        {
            #region MEMBRO
            if (_membro && !_progressao && !_remanejamento)
            {
                // MEMBRO
                if (String.IsNullOrEmpty(txt_nick.Texts))
                {
                    txt_nick.BorderColor = Color.Red;
                    txt_nick.BorderSize = 3;
                }
                else if (txt_classe.SelectedIndex == 0)
                {
                    txt_classe.BorderColor = Color.Red;
                    txt_classe.BorderSize = 3;
                }
                else if (txt_patente.SelectedIndex == 0)
                {
                    txt_patente.BorderColor = Color.Red;
                    txt_patente.BorderSize = 3;
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
                    }
                }
            }
            #endregion

            #region MEMBRO E PROGRESSÃO
            else if (_membro && _progressao && !_remanejamento)
            {
                // MEMBRO
                if (String.IsNullOrEmpty(txt_nick.Texts))
                {
                    txt_nick.BorderColor = Color.Red;
                    txt_nick.BorderSize = 3;
                }
                else if (txt_classe.SelectedIndex == 0)
                {
                    txt_classe.BorderColor = Color.Red;
                    txt_classe.BorderSize = 3;
                }
                else if (txt_patente.SelectedIndex == 0)
                {
                    txt_patente.BorderColor = Color.Red;
                    txt_patente.BorderSize = 3;
                }

                // PROGRESSÃO
                else if (String.IsNullOrEmpty(txt_novo_level.Texts))
                {
                    txt_novo_level.BorderColor = Color.Red;
                    txt_novo_level.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_novo_poder.Texts))
                {
                    txt_novo_poder.BorderColor = Color.Red;
                    txt_novo_poder.BorderSize = 3;
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
                        BtCancelarProg();
                    }
                }
            }
            #endregion

            #region MEMBRO E REMANEJAMENTO
            else if (_membro && _remanejamento && !_progressao)
            {
                // MEMBROS
                if (String.IsNullOrEmpty(txt_nick.Texts))
                {
                    txt_nick.BorderColor = Color.Red;
                    txt_nick.BorderSize = 3;
                }
                else if (txt_classe.SelectedIndex == 0)
                {
                    txt_classe.BorderColor = Color.Red;
                    txt_classe.BorderSize = 3;
                }
                else if (txt_patente.SelectedIndex == 0)
                {
                    txt_patente.BorderColor = Color.Red;
                    txt_patente.BorderSize = 3;
                }

                // REMANEJAMENTO
                else if (String.IsNullOrEmpty(txt_remanejamento.Texts))
                {
                    txt_remanejamento.BorderColor = Color.Red;
                    txt_remanejamento.BorderSize = 3;
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
                        BtCancelarRema();
                    }
                }
            }
            #endregion

            #region MEMBRO E PROGRESSÃO E REMANEJAMENTO
            else if (_membro && _progressao && _remanejamento)
            {
                // MEMBROS
                if (String.IsNullOrEmpty(txt_nick.Texts))
                {
                    txt_nick.BorderColor = Color.Red;
                    txt_nick.BorderSize = 3;
                }
                else if (txt_classe.SelectedIndex == 0)
                {
                    txt_classe.BorderColor = Color.Red;
                    txt_classe.BorderSize = 3;
                }
                else if (txt_patente.SelectedIndex == 0)
                {
                    txt_patente.BorderColor = Color.Red;
                    txt_patente.BorderSize = 3;
                }

                // PROGRESSÃO
                else if (String.IsNullOrEmpty(txt_novo_level.Texts))
                {
                    txt_novo_level.BorderColor = Color.Red;
                    txt_novo_level.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_novo_poder.Texts))
                {
                    txt_novo_poder.BorderColor = Color.Red;
                    txt_novo_poder.BorderSize = 3;
                }

                // REMANEJAMENTO
                else if (String.IsNullOrEmpty(txt_remanejamento.Texts))
                {
                    txt_remanejamento.BorderColor = Color.Red;
                    txt_remanejamento.BorderSize = 3;
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
                        BtCancelarProg();
                        BtCancelarRema();
                    }
                }
            }
            #endregion
        }
        #endregion

        #region CAMPO TEXTO
        private void txt_nick_Leave(object sender, EventArgs e)
        {
            txt_nick.BorderColor = Color.Transparent;
            txt_nick.BorderSize = 0;
        }

        private void txt_nick_Enter(object sender, EventArgs e)
        {
            txt_nick.BorderSize = 1;
        }

        private void txt_classe_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe.SelectedIndex > 0)
            {
                txt_classe.BorderColor = Color.Transparent;
                txt_classe.BorderSize = 0;
            }
        }

        private void txt_patente_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_patente.SelectedIndex > 0)
            {
                txt_patente.BorderColor = Color.Transparent;
                txt_patente.BorderSize = 0;
            }
        }

        private void txt_novo_level_Enter(object sender, EventArgs e)
        {
            txt_novo_level.BorderSize = 1;
        }

        private void txt_novo_level_Leave(object sender, EventArgs e)
        {
            txt_novo_level.BorderColor = Color.Transparent;
            txt_novo_level.BorderSize = 0;
        }

        private void txt_novo_poder_Enter(object sender, EventArgs e)
        {
            txt_novo_poder.BorderSize = 1;
        }

        private void txt_novo_poder_Leave(object sender, EventArgs e)
        {
            txt_novo_poder.BorderColor = Color.Transparent;
            txt_novo_poder.BorderSize = 0;
        }

        private void txt_remanejamento_Enter(object sender, EventArgs e)
        {
            txt_remanejamento.BorderSize = 1;
        }

        private void txt_remanejamento_Leave(object sender, EventArgs e)
        {
            txt_remanejamento.BorderColor = Color.Transparent;
            txt_remanejamento.BorderSize = 0;
        }

        private void CampoTextoDesativado(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)c).Enabled = false;
                    ((RJTextBox)c).BackColor = Color.FromArgb(32, 34, 37);

                }

                if (c is Label)
                {
                    ((Label)c).ForeColor = Color.FromArgb(32, 34, 37);
                }
            }
        }

        private void CampoTextoHabilitado(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)c).Enabled = true;
                    ((RJTextBox)c).BackColor = Color.White;

                }

                if (c is Label)
                {
                    ((Label)c).ForeColor = Color.White;
                }
            }
        }
        #endregion

        #region TABELAS
        private void TabelaProgressao()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select ID_PROGRESSAO, DATA_PROGRESSAO, ANTIGO_LEVEL, ANTIGO_PODER, NOVO_LEVEL, NOVO_PODER, ID_MEMBROS from hypedb.progressao where ID_MEMBROS = '" + id_membro +"' ", database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            database.closeConnection();

            TabelaContaMembros();
        }

        private void TabelaContaMembros()
        {
            dataGridView1.Columns[0].Visible = false; // ID_PROGRESSãO
            dataGridView1.Columns[1].HeaderText = "DATA";
            dataGridView1.Columns[2].HeaderText = "LEVEL";
            dataGridView1.Columns[3].HeaderText = "PODER";
            dataGridView1.Columns[4].HeaderText = "NOVO LEVEL";
            dataGridView1.Columns[5].HeaderText = "NOVO PODER";
            dataGridView1.Columns[6].Visible = false; // ID_MEMBROS

            dataGridView1.Columns["DATA_PROGRESSAO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ANTIGO_LEVEL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ANTIGO_PODER"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["NOVO_LEVEL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["NOVO_PODER"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.DataPropertyName == "DATA_PROGRESSAO")
                    column.Width = 135;
                else if (column.DataPropertyName == "ANTIGO_LEVEL")
                    column.Width = 130;
                else if (column.DataPropertyName == "ANTIGO_PODER")
                    column.Width = 130;
                else if (column.DataPropertyName == "NOVO_LEVEL")
                    column.Width = 150;
                else if (column.DataPropertyName == "NOVO_PODER")
                    column.Width = 150;
            }
        }

        private void TabelaDesabilitada()
        {
            dataGridView1.ScrollBars = ScrollBars.None;

            // FUNDO TABELA
            dataGridView1.BackgroundColor = Color.FromArgb(32, 34, 37);
            dataGridView1.GridColor = Color.FromArgb(32, 34, 37);

            // CABEÇALHO TABELA
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 34, 37);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 34, 37);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 34, 37);

            // CORPO DA TABELA
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(32, 34, 37);
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(32, 34, 37);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 34, 37);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 34, 37);

            dataGridView1.Enabled = false;
        }

        private void TabelaHabilitada()
        {
            dataGridView1.ScrollBars = ScrollBars.Both;

            // FUNDO TABELA
            dataGridView1.BackgroundColor = Color.FromArgb(34, 32, 46);
            dataGridView1.GridColor = Color.FromArgb(34, 32, 46);

            // CABEÇALHO TABELA
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 44, 70);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 44, 70);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // CORPO DA TABELA
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(39, 44, 60);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.Enabled = true;
        }

        private void AtualizarTabela()
        {
            try
            {
                // BANCO DE DADOS
                configdb database = new configdb();
                database.openConnection();

                MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.DATA_RECRUTAMENTO, c.NICK, c.LEVEL, c.PODER, c.CLASSE, c.PATENTE, alt.ID_ALT, alt.DATA_ALT, alt.NICK_ALT, alt.LEVEL_ALT, alt.CLASSE_ALT, alt.CLA_ALT, pro.ID_PROGRESSAO, pro.DATA_PROGRESSAO, pro.ANTIGO_LEVEL, pro.ANTIGO_PODER, pro.NOVO_LEVEL, pro.NOVO_PODER, re.ID_RECRUTAMENTO, re.VEM_DO_CLA, re.FOI_PARA_CLA from hypedb.cadastro_membro c left join hypedb.cadastro_alt alt on c.ID_MEMBROS = alt.ID_ALT left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS left join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_MEMBROS where c.id_membros = '" + id_membro + "' ", database.getConnection());

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txt_level.Texts = dr["LEVEL"].ToString();
                    txt_poder.Texts = dr["PODER"].ToString();
                    txt_esta_cla.Texts = dr["FOI_PARA_CLA"].ToString();
                }

                database.closeConnection();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        public void DadosMembros()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.DATA_RECRUTAMENTO, c.NICK, c.LEVEL, c.PODER, c.CLASSE, c.PATENTE, alt.ID_ALT, alt.DATA_ALT, alt.NICK_ALT, alt.LEVEL_ALT, alt.CLASSE_ALT, alt.CLA_ALT, pro.ID_PROGRESSAO, pro.DATA_PROGRESSAO, pro.ANTIGO_LEVEL, pro.ANTIGO_PODER, pro.NOVO_LEVEL, pro.NOVO_PODER, re.ID_RECRUTAMENTO, re.VEM_DO_CLA, re.FOI_PARA_CLA from hypedb.cadastro_membro c left join hypedb.cadastro_alt alt on c.ID_MEMBROS = alt.ID_ALT left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS left join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_MEMBROS where c.id_membros = '" + id_membro + "' ", database.getConnection());

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

        #endregion

        private void conta_principal_Load(object sender, EventArgs e)
        {
            DadosMembros();
            TabelaProgressao();


            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }


    }
}
