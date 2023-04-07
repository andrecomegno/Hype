using Hype.script;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hype.Painel.Home
{
    public partial class editar_clas : UserControl
    {
        private string id_login = login.Instance.id_login;
        private string id_cla = lista_clas.Instance.id_cla;
        private string id_membros;

        public editar_clas()
        {
            InitializeComponent();
        }

        private void PesquisarMembros()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            // PESQUISA O ID DO MEMBRO 
            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, c.STATUS, c.NICK from hypedb.cadastro_membro c left join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_MEMBROS left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_RECRUTAMENTO left join hypedb.cadastro_cla cl on cl.ID_CLA = re.ID_CLA where c.STATUS like @STATUS '%' and c.NICK = '"+ txt_nick_lider.Texts +"' ", database.getConnection());
            cmd.Parameters.AddWithValue("@NICK", txt_nick_lider.Texts);
            cmd.Parameters.AddWithValue("@STATUS", "Ativo");

            // COLETA O ID_MEMBROS
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id_membros = dr["ID_MEMBROS"].ToString();
            }

            database.closeConnection();
        }

        private void Alertas()
        {
            if (String.IsNullOrEmpty(txt_nick_lider.Texts))
            {
                txt_nick_lider.BorderColor = Color.Red;
                txt_nick_lider.BorderSize = 3;
            }
            else if (String.IsNullOrEmpty(txt_nome_cla.Texts))
            {
                txt_nome_cla.BorderColor = Color.Red;
                txt_nome_cla.BorderSize = 3;
            }
            else
            {
                try
                {
                    Salvar();
                    MessageBox.Show("Salvo Com Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    Voltar();
                }                
            }
        }

        private void Salvar()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            // UPDATE TABELA CADASTRO CLA
            MySqlCommand objCmdDoacao = new MySqlCommand("update hypedb.cadastro_cla set nick_lider=@nick_lider, nome_cla=@nome_cla where (id_cla=@id_cla) and (id_login=@id_login) ", database.getConnection());

            objCmdDoacao.Parameters.AddWithValue("@id_cla", id_cla);
            objCmdDoacao.Parameters.AddWithValue("@id_login", id_login);
            objCmdDoacao.Parameters.Add("@nick_lider", MySqlDbType.VarChar, 256).Value = txt_nick_lider.Texts;
            objCmdDoacao.Parameters.Add("@nome_cla", MySqlDbType.VarChar, 256).Value = txt_nome_cla.Texts;

            objCmdDoacao.ExecuteNonQuery();

            // UPDATE MEMBROS
            MySqlCommand objCmdCadastro = new MySqlCommand("update hypedb.cadastro_membro set nick=@nick where (id_membros=@id_membros)", database.getConnection());

            objCmdCadastro.Parameters.AddWithValue("@id_membros", id_membros);
            objCmdCadastro.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick_lider.Texts;

            objCmdCadastro.ExecuteNonQuery();

            database.closeConnection();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Alertas();
        }

        private void Voltar()
        {
            lista_clas uc = new lista_clas();
            home.Instance.addControl(uc);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        #region CAMPO TEXTO
        private void txt_nick_lider_Enter(object sender, EventArgs e)
        {
            txt_nick_lider.BorderSize = 1;
            txt_nick_lider.Texts = string.Empty;
        }

        private void txt_nome_cla_Enter(object sender, EventArgs e)
        {
            txt_nome_cla.BorderSize = 1;
            txt_nome_cla.Texts = string.Empty;
        }

        private void txt_nick_lider_Leave(object sender, EventArgs e)
        {
            txt_nick_lider.BorderColor = Color.Transparent;
            txt_nick_lider.BorderSize = 0;
        }

        private void txt_nome_cla_Leave(object sender, EventArgs e)
        {
            txt_nome_cla.BorderColor = Color.Transparent;
            txt_nome_cla.BorderSize = 0;
        }
        #endregion

        private void Dados()
        {
            //CARREGAR DADOS
            txt_nick_lider.Texts = lista_clas.Instance.nick_lider;
            txt_nome_cla.Texts = lista_clas.Instance.nome_cla;

            PesquisarMembros();
        }

        private void editar_clas_Load(object sender, EventArgs e)
        {
            Dados();
        }

        
    }
}
