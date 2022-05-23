using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mir4.script;
using System.Windows.Forms;
using Mir4.Properties;

namespace Mir4.painel
{
    public partial class add_membros : UserControl
    {
        string pergunta = string.Empty;

        public add_membros()
        {
            InitializeComponent();
        }

        public void RadioSelecao()
        {
            if (rd_nao.Checked == true)
                txt_quantidade_alt.SelectedIndex = 0;
        }

        private void AddMembros()
        {
            database database = new database();
            database.openConnection();

            if (pergunta == "SIM")
            {
                // INSERT TABELA PEGUNTA ALT
                MySqlCommand objCmdPerguntaAlt = new MySqlCommand("insert into pergunta_alt (id, pergunta) values (null, ?)", database.getConnection());

                objCmdPerguntaAlt.Parameters.Add("@pergunta", MySqlDbType.VarChar, 5).Value = pergunta;

                objCmdPerguntaAlt.ExecuteNonQuery();
                long idPergunta = objCmdPerguntaAlt.LastInsertedId;

                // INSERT TABELA ALT 0
                MySqlCommand objCmdAlt0 = new MySqlCommand("insert into alt (id, nick, level, poder, classe, cla, data, pergunta_alt_id) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

                objCmdAlt0.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick_alt_0.Texts;
                objCmdAlt0.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_level_alt_0.Texts;
                objCmdAlt0.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_poder_alt_0.Texts;
                objCmdAlt0.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe_alt_0.Text;
                objCmdAlt0.Parameters.Add("@cla", MySqlDbType.VarChar, 256).Value = txt_foi_alt_0.Texts;
                objCmdAlt0.Parameters.Add("@data", MySqlDbType.Date).Value = DateTime.Now;
                objCmdAlt0.Parameters.Add("@pergunta_alt_id", MySqlDbType.Int32).Value = idPergunta;

                objCmdAlt0.ExecuteNonQuery();

                // INSERT TABELA ALT 1
                MySqlCommand objCmdAlt1 = new MySqlCommand("insert into alt (id, nick, level, poder, classe, cla, data, pergunta_alt_id) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

                objCmdAlt1.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick_alt_1.Texts;
                objCmdAlt1.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_level_alt_1.Texts;
                objCmdAlt1.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_poder_alt_1.Texts;
                objCmdAlt1.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe_alt_1.Text;
                objCmdAlt1.Parameters.Add("@cla", MySqlDbType.VarChar, 256).Value = txt_foi_alt_1.Texts;
                objCmdAlt1.Parameters.Add("@data", MySqlDbType.Date).Value = DateTime.Now;
                objCmdAlt1.Parameters.Add("@pergunta_alt_id", MySqlDbType.Int32).Value = idPergunta;

                objCmdAlt1.ExecuteNonQuery();
            }
            else
            {
                // INSERT TABELA PEGUNTA ALT
                MySqlCommand objCmdPerguntaAlt = new MySqlCommand("insert into pergunta_alt (id, pergunta) values (null, ?)", database.getConnection());

                objCmdPerguntaAlt.Parameters.Add("@pergunta", MySqlDbType.VarChar, 5).Value = pergunta;

                objCmdPerguntaAlt.ExecuteNonQuery();
                long idPergunta = objCmdPerguntaAlt.LastInsertedId;

                // INSERT TABELA REMANEJAMENTO
                MySqlCommand objCmdRemanejamento = new MySqlCommand("insert into remanejamento (id, vem_do_cla, foi_para_cla, data_entrada, data_remanejamento) values (null, ?, ?, ?, ?)", database.getConnection());

                objCmdRemanejamento.Parameters.Add("@vem_do_cla", MySqlDbType.VarChar, 256).Value = txt_vem.Texts;
                objCmdRemanejamento.Parameters.Add("@foi_para_cla", MySqlDbType.VarChar, 256).Value = txt_foi.Texts;
                objCmdRemanejamento.Parameters.Add("@data_entrada", MySqlDbType.Date).Value = DateTime.Now;
                objCmdRemanejamento.Parameters.Add("@data_remanejamento", MySqlDbType.Date).Value = DateTime.Now;

                objCmdRemanejamento.ExecuteNonQuery();
                long idRemanejamento = objCmdRemanejamento.LastInsertedId;

                // INSERT TABELA CADASTRO MEMBROS
                MySqlCommand objCmdCadastroMembros = new MySqlCommand("insert into cadastro_membro (id, nick, level, poder, classe, patente, remanejamento_id, pergunta_alt_id) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

                objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
                objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_level.Texts;
                objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
                objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Text;
                objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Text;
                objCmdCadastroMembros.Parameters.Add("@remanejamento_id", MySqlDbType.Int32).Value = idRemanejamento;
                objCmdCadastroMembros.Parameters.Add("@pergunta_alt_id", MySqlDbType.Int32).Value = idPergunta;

                objCmdCadastroMembros.ExecuteNonQuery();

                MessageBox.Show(pergunta);
            }

            database.closeConnection();
        }


        private void bt_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                AddMembros();
                DialogResult dr = MessageBox.Show("Salvo Com Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }            
            finally
            {
                LimparTextos(pl_membro.Controls);
                LimparTextos(pl_pergunta.Controls);
                LimparTextos(pl_alt_0.Controls);
                LimparTextos(pl_alt_1.Controls);

                rd_nao.Checked = true;
            }            
            
        }

        public void LimparTextos(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)(c)).Texts = string.Empty;
                }
            }

            foreach (Control c in control)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)(c)).SelectedIndex = -1;
                }
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void rd_sim_CheckedChanged(object sender, EventArgs e)
        {
            txt_quantidade_alt.Enabled = true;

            txt_quantidade_alt.SelectedIndex = 1;

            pergunta = "SIM";
        }

        private void rd_nao_CheckedChanged(object sender, EventArgs e)
        {

            LimparTextos(pl_alt_0.Controls);
            LimparTextos(pl_alt_1.Controls);

            //limpar avatar

            txt_quantidade_alt.Enabled = false;

            pl_alt_0.Visible = false;
            pl_alt_1.Visible = false;

            txt_quantidade_alt.SelectedIndex = 0;

            pergunta = "NÃO";
        }

        private void txt_quantidade_alt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_quantidade_alt.SelectedIndex == 1)
            {
                pl_alt_0.Visible = true;
                pl_alt_1.Visible = false;
            }
            else if (txt_quantidade_alt.SelectedIndex == 2)
            {
                pl_alt_0.Visible = true;
                pl_alt_1.Visible = true;
            }
            else
            {
                pl_alt_0.Visible = false;
                pl_alt_1.Visible = false;

                txt_quantidade_alt.SelectedIndex = 0;
            }
        }

        private void add_membros_Load(object sender, EventArgs e)
        {
            RadioSelecao();
            pl_botao.Dock = DockStyle.Top;
        }

        private void txt_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe.SelectedIndex == 0 )
            {
                foto_classe.Image = Resources.Arbalista;

            }
            else if (txt_classe.SelectedIndex == 1)
            {
                foto_classe.Image = Resources.Mago;
            }
            else if (txt_classe.SelectedIndex == 2)
            {
                foto_classe.Image = Resources.Guerreiro;
            }
            else if (txt_classe.SelectedIndex == 3)
            {
                foto_classe.Image = Resources.Lanceiro;
            }
            else if (txt_classe.SelectedIndex == 4)
            {
                foto_classe.Image = Resources.Taoista;
            }
        }

        private void txt_classe_alt_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe_alt_0.SelectedIndex == 0)
            {
                foto_classe_alt_0.Image = Resources.Arbalista;
            }
            else if (txt_classe_alt_0.SelectedIndex == 1)
            {
                foto_classe_alt_0.Image = Resources.Mago;
            }
            else if (txt_classe_alt_0.SelectedIndex == 2)
            {
                foto_classe_alt_0.Image = Resources.Guerreiro;
            }
            else if (txt_classe_alt_0.SelectedIndex == 3)
            {
                foto_classe_alt_0.Image = Resources.Lanceiro;
            }
            else if (txt_classe_alt_0.SelectedIndex == 4)
            {
                foto_classe_alt_0.Image = Resources.Taoista;
            }
        }

        private void txt_classe_alt_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe_alt_1.SelectedIndex == 0)
            {
                foto_classe_alt_1.Image = Resources.Arbalista;
            }
            else if (txt_classe_alt_1.SelectedIndex == 1)
            {
                foto_classe_alt_1.Image = Resources.Mago;
            }
            else if (txt_classe_alt_1.SelectedIndex == 2)
            {
                foto_classe_alt_1.Image = Resources.Guerreiro;
            }
            else if (txt_classe_alt_1.SelectedIndex == 3)
            {
                foto_classe_alt_1.Image = Resources.Lanceiro;
            }
            else if (txt_classe_alt_1.SelectedIndex == 4)
            {
                foto_classe_alt_1.Image = Resources.Taoista;
            }
        }


    }
}
