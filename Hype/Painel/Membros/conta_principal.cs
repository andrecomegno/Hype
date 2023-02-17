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
        string id_membro = string.Empty;
        string id_alt = string.Empty;
        string id_recrutamento = string.Empty;
        string id_progressao = string.Empty;

        // PROGRESSAO
        decimal novo_poder;
        int novo_level;
        

        // PAINEIS
        bool _progressao = false;
        bool _remanejamento = false;

        public conta_principal()
        {
            InitializeComponent();
            CamposDesativados();
        }

        #region BOTOES
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Alertas();
            }
            finally
            {
                BtCancelarRema();
                BtCancelarProg();
            }
            
        } 

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarTabelas();
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
                AtualizarTabelas();
            }
        }

        private void Alertas()
        {
            // CADASTRO
            if (String.IsNullOrEmpty(txt_nick.Texts))
            {
                txt_nick.BorderColor = Color.Red;
                txt_nick.BorderSize = 1;
            }
            else if (txt_classe.SelectedIndex == 0)
            {
                txt_classe.BorderColor = Color.Red;
                txt_classe.BorderSize = 1;
            }
            else if (txt_patente.SelectedIndex == 0)
            {
                txt_patente.BorderColor = Color.Red;
                txt_patente.BorderSize = 1;
            }
            else 
            {
                try
                {
                    Salvar();
                }
                finally
                {
                    AtualizarTabelas();
                }
            }

        }

        private void Salvar()
        {
            try
            {
                // BANCO DE DADOS
                configdb database = new configdb();
                database.openConnection();


                // CADASTRO DE MEMBROS
                MySqlCommand objCmdCadastro_membros = new MySqlCommand("update hypedb.cadastro_membro set nick=@nick, classe=@classe, patente=@patente where (id_membros=@id_membros)", database.getConnection());

                objCmdCadastro_membros.Parameters.AddWithValue("@id_membros", id_membro);
                objCmdCadastro_membros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
                objCmdCadastro_membros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
                objCmdCadastro_membros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;

                objCmdCadastro_membros.ExecuteNonQuery();

                MySqlCommand objCmdAlt = new MySqlCommand("update hypedb.cadastro_alt set nick_principal=@nick_principal where (id_alt=@id_alt)", database.getConnection());

                objCmdAlt.Parameters.AddWithValue("@id_alt", id_alt);
                objCmdAlt.Parameters.Add("@nick_principal", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;

                objCmdAlt.ExecuteNonQuery();

                // SE PROGRESSÃO FOR ATIVADO 
                if (_progressao != false)
                {            
                    // PROGRESSAO INTO
                    MySqlCommand objCmdProgressao = new MySqlCommand("insert into hypedb.progressao (id_progressao, data_progressao, antigo_poder, antigo_level, novo_poder, novo_level) values (null, ?, ?, ?, ?, ?)", database.getConnection());

                    objCmdProgressao.Parameters.Add("@data_progressao", MySqlDbType.Date).Value = DateTime.Now;
                    objCmdProgressao.Parameters.Add("@antigo_poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
                    objCmdProgressao.Parameters.Add("@antigo_level", MySqlDbType.Int32).Value = txt_level.Texts;
                    objCmdProgressao.Parameters.Add("@novo_poder", MySqlDbType.Decimal).Value = txt_poder_ja.Texts;
                    objCmdProgressao.Parameters.Add("@novo_level", MySqlDbType.Int32).Value = txt_level_ja.Texts;

                    objCmdProgressao.ExecuteNonQuery();

                    /*
                    // PROGRESSAO UPDATE
                    MySqlCommand objCmdProgressao2 = new MySqlCommand("update hypedb.progressao set novo_poder=@novo_poder, novo_level=@novo_level where (id_progressao=@id_progressao)", database.getConnection());

                    objCmdProgressao2.Parameters.Add("@novo_poder", MySqlDbType.Decimal).Value = novo_poder;
                    objCmdProgressao2.Parameters.Add("@novo_level", MySqlDbType.Int32).Value = novo_level;

                    objCmdProgressao.ExecuteNonQuery();
                    */
                }

                // SE REMANEJAMENTO FOR ATIVADO 
                if (_remanejamento != false)
                {
                    // RECRUTAMENTO UPDATE
                    MySqlCommand objCmdRecrutamento = new MySqlCommand("update hypedb.recrutamento set foi_para_cla=@foi_para_cla where (id_recrutamento=@id_recrutamento)", database.getConnection());

                    objCmdRecrutamento.Parameters.AddWithValue("@id_recrutamento", id_recrutamento);
                    objCmdRecrutamento.Parameters.Add("@foi_para_cla", MySqlDbType.VarChar, 256).Value = txt_remanejamento.Texts;

                    objCmdRecrutamento.ExecuteNonQuery();

                    // REMANEJAMENTO INTO
                    MySqlCommand objCmdRemanejamento = new MySqlCommand("insert into hypedb.remanejamento (id_remanejamento, data_remanejamento, id_recrutamento) values (null, ?, ?)", database.getConnection());

                    objCmdRemanejamento.Parameters.Add("@data_remanejamento", MySqlDbType.Date).Value = DateTime.Now;
                    objCmdRemanejamento.Parameters.Add("@id_recrutamento", MySqlDbType.Int32).Value = id_recrutamento;

                    objCmdRemanejamento.ExecuteNonQuery();
                }

                DialogResult dr = MessageBox.Show("Editado Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            txt_level.BackColor = Color.FromArgb(235, 235, 235);
            txt_poder.BackColor = Color.FromArgb(235, 235, 235);

            bt_cancelar_prog.Visible = false;
            bt_cancelar_rema.Visible = false;
            lb_seta.Visible = false;

            CampoTextoDesativado(pl_progressao.Controls);
            CampoTextoDesativado(pl_remanejamento.Controls);
        }

        private void txt_nick_Leave(object sender, EventArgs e)
        {
            txt_nick.BorderColor = Color.Transparent;
            txt_nick.BorderSize = 0;
        }

        private void txt_classe_Leave(object sender, EventArgs e)
        {
            txt_classe.BorderColor = Color.Transparent;
            txt_classe.BorderSize = 0;
        }

        private void txt_patente_Leave(object sender, EventArgs e)
        {
            txt_patente.BorderColor = Color.Transparent;
            txt_patente.BorderSize = 0;
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

        private void bt_editar_prog_Click(object sender, EventArgs e)
        {
            CampoTextoHabilitado(pl_progressao.Controls);

            bt_cancelar_prog.Visible = true;
            bt_editar_prog.Visible = false;

            _progressao = true;
        }

        private void bt_cancelar_prog_Click(object sender, EventArgs e)
        {
            BtCancelarProg();
        }

        private void BtCancelarProg()
        {
            bt_cancelar_prog.Visible = false;
            bt_editar_prog.Visible = true;

            _progressao = false;

            CampoTextoDesativado(pl_progressao.Controls);
        }

        private void bt_editar_rema_Click(object sender, EventArgs e)
        {
            bt_cancelar_rema.Visible = true;
            bt_editar_rema.Visible = false;
            lb_seta.Visible = true;           
            txt_remanejamento.PlaceholderText = "Remanejamento";

            // DADOS MEMBROS
            txt_vem_cla.Texts = membros.Instance.vem_do_cla;
            txt_esta_cla.Texts = membros.Instance.foi_para_cla;

            _remanejamento = true;
            CampoTextoHabilitado(pl_remanejamento.Controls);

            // CAMPOS FIXO DESATIVAODS
            txt_vem_cla.Enabled = false;
            txt_esta_cla.Enabled = false;
            txt_vem_cla.BackColor = Color.FromArgb(235, 235, 235);
            txt_esta_cla.BackColor = Color.FromArgb(235, 235, 235);
        }

        private void bt_cancelar_rema_Click(object sender, EventArgs e)
        {
            BtCancelarRema();
        }

        private void BtCancelarRema()
        {
            bt_cancelar_rema.Visible = false;
            bt_editar_rema.Visible = true;
            lb_seta.Visible = false;
            txt_remanejamento.PlaceholderText = "";

            // DADOS MEMBROS
            txt_vem_cla.Texts = "";
            txt_esta_cla.Texts = "";
            txt_vem_cla.Enabled = false;

            _remanejamento = false;
            CampoTextoDesativado(pl_remanejamento.Controls);
        }

        #endregion

        #region TABELAS
        private void AtualizarTabelas()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand objCmdCadastro_membros = new MySqlCommand("select * from hypedb.cadastro_membro", database.getConnection());

            objCmdCadastro_membros.ExecuteNonQuery();

            MySqlCommand objCmdCadastro_alt = new MySqlCommand("select * from hypedb.cadastro_alt", database.getConnection());

            objCmdCadastro_alt.ExecuteNonQuery();

            database.closeConnection();
        }

        public void DadosMembros()
        {
            // CADASTRO
            id_membro = membros.Instance.id_membro;
            lb_data_entrada.Text = membros.Instance.data_entrada;
            txt_nick.Texts = membros.Instance.nick;
            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Texts = membros.Instance.patente;
            txt_classe.Texts = membros.Instance.classe;

            // ALT
            id_alt = membros.Instance.id_alt;

            //REMANEJAMENTO
            id_recrutamento = membros.Instance.id_recrutamento;
            //txt_vem_cla.Texts = membros.Instance.vem_do_cla;
            //txt_esta_cla.Texts = membros.Instance.foi_para_cla;
        }
        #endregion

        private void conta_principal_Load(object sender, EventArgs e)
        {
            DadosMembros();
        }

 
    }
}
