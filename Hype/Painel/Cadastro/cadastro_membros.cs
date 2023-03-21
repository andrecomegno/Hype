using System;
using System.Drawing;
using Hype.script;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hype.Painel
{
    public partial class cadastro : UserControl
    {
        public static cadastro Instance;

        string tem_alt = string.Empty;

        public cadastro()
        {
            InitializeComponent();
            Instance = this;

            txt_quantidade_alt.SelectedIndex = 0;
            txt_classe.SelectedIndex = 0;
            txt_patente.SelectedIndex = 0;
        }

        private void Cadastro()
        {
            switch (txt_quantidade_alt.SelectedIndex)
            {
                case 0:
                    NovoMembro();
                    break;
                case 1:
                    NovaAlt_01();
                    break;
                case 2:
                    NovaAlt_02();
                    break;
                case 3:
                    NovaAlt_03();
                    break;
                case 4:
                    NovaAlt_04();
                    break;
                case 5:
                    NovaAlt_05();
                    break;

                default:
                    break;
            }
        }

        #region NOVO CADASTRO
        private void NovoMembro()
        {
            configdb database = new configdb();
            database.openConnection();

            // INSERT TABELA RECRUTAMENTO
            MySqlCommand objCmdRecrutamento = new MySqlCommand("insert into hypedb.recrutamento (id_recrutamento, data_recrutamento, vem_do_cla, foi_para_cla) values (null, ?, ?, ?)", database.getConnection());

            objCmdRecrutamento.Parameters.Add("@data_recrutamento", MySqlDbType.Date).Value = DateTime.Now;
            objCmdRecrutamento.Parameters.Add("@vem_do_cla", MySqlDbType.VarChar, 256).Value = txt_vem.Texts;
            objCmdRecrutamento.Parameters.Add("@foi_para_cla", MySqlDbType.VarChar, 256).Value = txt_foi.Texts;

            objCmdRecrutamento.ExecuteNonQuery();
            long idRecruta = objCmdRecrutamento.LastInsertedId;

            // INSERT TABELA CADASTRO MEMBROS
            MySqlCommand objCmdCadastroMembros = new MySqlCommand("insert into hypedb.cadastro_membro (id_membros, nick, level, poder, classe, patente, id_recrutamento) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
            objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
            objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;
            objCmdCadastroMembros.Parameters.Add("@id_recrutamento", MySqlDbType.Int32).Value = idRecruta;

            objCmdCadastroMembros.ExecuteNonQuery();
            long idMembros = objCmdCadastroMembros.LastInsertedId;

            // INSERT TABELA PROGRESSÃO
            MySqlCommand objCmdProgressao = new MySqlCommand("insert into hypedb.progressao (id_progressao, data_progressao, antigo_poder, antigo_level, novo_poder, novo_level, id_membros) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdProgressao.Parameters.Add("@data_progressao", MySqlDbType.Date).Value = DateTime.Now;
            objCmdProgressao.Parameters.Add("@antigo_poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdProgressao.Parameters.Add("@antigo_level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdProgressao.Parameters.Add("@novo_poder", MySqlDbType.Decimal).Value = 0.00;
            objCmdProgressao.Parameters.Add("@novo_level", MySqlDbType.Int32).Value = 0;
            objCmdProgressao.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdProgressao.ExecuteNonQuery();

            database.closeConnection();
        }

        private void NovaAlt_01()
        {
            configdb database = new configdb();
            database.openConnection();

            // INSERT TABELA RECRUTAMENTO
            MySqlCommand objCmdRecrutamento = new MySqlCommand("insert into hypedb.recrutamento (id_recrutamento, data_recrutamento, vem_do_cla, foi_para_cla) values (null, ?, ?, ?)", database.getConnection());

            objCmdRecrutamento.Parameters.Add("@data_recrutamento", MySqlDbType.Date).Value = DateTime.Now;
            objCmdRecrutamento.Parameters.Add("@vem_do_cla", MySqlDbType.VarChar, 256).Value = txt_vem.Texts;
            objCmdRecrutamento.Parameters.Add("@foi_para_cla", MySqlDbType.VarChar, 256).Value = txt_foi.Texts;

            objCmdRecrutamento.ExecuteNonQuery();
            long idRecruta = objCmdRecrutamento.LastInsertedId;

            // INSERT TABELA CADASTRO MEMBROS
            MySqlCommand objCmdCadastroMembros = new MySqlCommand("insert into hypedb.cadastro_membro (id_membros, nick, level, poder, classe, patente, id_recrutamento) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
            objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
            objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;
            objCmdCadastroMembros.Parameters.Add("@id_recrutamento", MySqlDbType.Int32).Value = idRecruta;

            objCmdCadastroMembros.ExecuteNonQuery();
            long idMembros = objCmdCadastroMembros.LastInsertedId;

            // INSERT TABELA PROGRESSÃO
            MySqlCommand objCmdProgressao = new MySqlCommand("insert into hypedb.progressao (id_progressao, data_progressao, antigo_poder, antigo_level, novo_poder, novo_level, id_membros) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdProgressao.Parameters.Add("@data_progressao", MySqlDbType.Date).Value = DateTime.Now;
            objCmdProgressao.Parameters.Add("@antigo_poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdProgressao.Parameters.Add("@antigo_level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdProgressao.Parameters.Add("@novo_poder", MySqlDbType.Decimal).Value = 0.00;
            objCmdProgressao.Parameters.Add("@novo_level", MySqlDbType.Int32).Value = 0;
            objCmdProgressao.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdProgressao.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 01
            MySqlCommand objCmdCadastroAlt = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt.ExecuteNonQuery();

            database.closeConnection();
        }

        private void NovaAlt_02()
        {
            configdb database = new configdb();
            database.openConnection();

            // INSERT TABELA RECRUTAMENTO
            MySqlCommand objCmdRecrutamento = new MySqlCommand("insert into hypedb.recrutamento (id_recrutamento, data_recrutamento, vem_do_cla, foi_para_cla) values (null, ?, ?, ?)", database.getConnection());

            objCmdRecrutamento.Parameters.Add("@data_recrutamento", MySqlDbType.Date).Value = DateTime.Now;
            objCmdRecrutamento.Parameters.Add("@vem_do_cla", MySqlDbType.VarChar, 256).Value = txt_vem.Texts;
            objCmdRecrutamento.Parameters.Add("@foi_para_cla", MySqlDbType.VarChar, 256).Value = txt_foi.Texts;

            objCmdRecrutamento.ExecuteNonQuery();
            long idRecruta = objCmdRecrutamento.LastInsertedId;

            // INSERT TABELA CADASTRO MEMBROS
            MySqlCommand objCmdCadastroMembros = new MySqlCommand("insert into hypedb.cadastro_membro (id_membros, nick, level, poder, classe, patente, id_recrutamento) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
            objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
            objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;
            objCmdCadastroMembros.Parameters.Add("@id_recrutamento", MySqlDbType.Int32).Value = idRecruta;

            objCmdCadastroMembros.ExecuteNonQuery();
            long idMembros = objCmdCadastroMembros.LastInsertedId;

            // INSERT TABELA PROGRESSÃO
            MySqlCommand objCmdProgressao = new MySqlCommand("insert into hypedb.progressao (id_progressao, data_progressao, antigo_poder, antigo_level, novo_poder, novo_level, id_membros) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdProgressao.Parameters.Add("@data_progressao", MySqlDbType.Date).Value = DateTime.Now;
            objCmdProgressao.Parameters.Add("@antigo_poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdProgressao.Parameters.Add("@antigo_level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdProgressao.Parameters.Add("@novo_poder", MySqlDbType.Decimal).Value = 0.00;
            objCmdProgressao.Parameters.Add("@novo_level", MySqlDbType.Int32).Value = 0;
            objCmdProgressao.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdProgressao.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 01
            MySqlCommand objCmdCadastroAlt = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 02
            MySqlCommand objCmdCadastroAlt2 = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt2.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt2.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt2.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt2.ExecuteNonQuery();

            database.closeConnection();
        }

        private void NovaAlt_03()
        {
            configdb database = new configdb();
            database.openConnection();

            // INSERT TABELA RECRUTAMENTO
            MySqlCommand objCmdRecrutamento = new MySqlCommand("insert into hypedb.recrutamento (id_recrutamento, data_recrutamento, vem_do_cla, foi_para_cla) values (null, ?, ?, ?)", database.getConnection());

            objCmdRecrutamento.Parameters.Add("@data_recrutamento", MySqlDbType.Date).Value = DateTime.Now;
            objCmdRecrutamento.Parameters.Add("@vem_do_cla", MySqlDbType.VarChar, 256).Value = txt_vem.Texts;
            objCmdRecrutamento.Parameters.Add("@foi_para_cla", MySqlDbType.VarChar, 256).Value = txt_foi.Texts;

            objCmdRecrutamento.ExecuteNonQuery();
            long idRecruta = objCmdRecrutamento.LastInsertedId;

            // INSERT TABELA CADASTRO MEMBROS
            MySqlCommand objCmdCadastroMembros = new MySqlCommand("insert into hypedb.cadastro_membro (id_membros, nick, level, poder, classe, patente, id_recrutamento) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
            objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
            objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;
            objCmdCadastroMembros.Parameters.Add("@id_recrutamento", MySqlDbType.Int32).Value = idRecruta;

            objCmdCadastroMembros.ExecuteNonQuery();
            long idMembros = objCmdCadastroMembros.LastInsertedId;

            // INSERT TABELA PROGRESSÃO
            MySqlCommand objCmdProgressao = new MySqlCommand("insert into hypedb.progressao (id_progressao, data_progressao, antigo_poder, antigo_level, novo_poder, novo_level, id_membros) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdProgressao.Parameters.Add("@data_progressao", MySqlDbType.Date).Value = DateTime.Now;
            objCmdProgressao.Parameters.Add("@antigo_poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdProgressao.Parameters.Add("@antigo_level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdProgressao.Parameters.Add("@novo_poder", MySqlDbType.Decimal).Value = 0.00;
            objCmdProgressao.Parameters.Add("@novo_level", MySqlDbType.Int32).Value = 0;
            objCmdProgressao.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdProgressao.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 01
            MySqlCommand objCmdCadastroAlt = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 02
            MySqlCommand objCmdCadastroAlt2 = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt2.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt2.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt2.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt2.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 03
            MySqlCommand objCmdCadastroAlt3 = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt3.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt3.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_03.Texts;
            objCmdCadastroAlt3.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_03.Texts;
            objCmdCadastroAlt3.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_03.Texts;
            objCmdCadastroAlt3.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_03.Texts;            
            objCmdCadastroAlt3.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt3.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt3.ExecuteNonQuery();

            database.closeConnection();
        }

        private void NovaAlt_04()
        {
            configdb database = new configdb();
            database.openConnection();

            // INSERT TABELA RECRUTAMENTO
            MySqlCommand objCmdRecrutamento = new MySqlCommand("insert into hypedb.recrutamento (id_recrutamento, data_recrutamento, vem_do_cla, foi_para_cla) values (null, ?, ?, ?)", database.getConnection());

            objCmdRecrutamento.Parameters.Add("@data_recrutamento", MySqlDbType.Date).Value = DateTime.Now;
            objCmdRecrutamento.Parameters.Add("@vem_do_cla", MySqlDbType.VarChar, 256).Value = txt_vem.Texts;
            objCmdRecrutamento.Parameters.Add("@foi_para_cla", MySqlDbType.VarChar, 256).Value = txt_foi.Texts;

            objCmdRecrutamento.ExecuteNonQuery();
            long idRecruta = objCmdRecrutamento.LastInsertedId;

            // INSERT TABELA CADASTRO MEMBROS
            MySqlCommand objCmdCadastroMembros = new MySqlCommand("insert into hypedb.cadastro_membro (id_membros, nick, level, poder, classe, patente, id_recrutamento) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
            objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
            objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;
            objCmdCadastroMembros.Parameters.Add("@id_recrutamento", MySqlDbType.Int32).Value = idRecruta;

            objCmdCadastroMembros.ExecuteNonQuery();
            long idMembros = objCmdCadastroMembros.LastInsertedId;

            // INSERT TABELA PROGRESSÃO
            MySqlCommand objCmdProgressao = new MySqlCommand("insert into hypedb.progressao (id_progressao, data_progressao, antigo_poder, antigo_level, novo_poder, novo_level, id_membros) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdProgressao.Parameters.Add("@data_progressao", MySqlDbType.Date).Value = DateTime.Now;
            objCmdProgressao.Parameters.Add("@antigo_poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdProgressao.Parameters.Add("@antigo_level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdProgressao.Parameters.Add("@novo_poder", MySqlDbType.Decimal).Value = 0.00;
            objCmdProgressao.Parameters.Add("@novo_level", MySqlDbType.Int32).Value = 0;
            objCmdProgressao.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdProgressao.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 01
            MySqlCommand objCmdCadastroAlt = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 02
            MySqlCommand objCmdCadastroAlt2 = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt2.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt2.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt2.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt2.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 03
            MySqlCommand objCmdCadastroAlt3 = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt3.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt3.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_03.Texts;
            objCmdCadastroAlt3.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_03.Texts;
            objCmdCadastroAlt3.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_03.Texts;
            objCmdCadastroAlt3.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_03.Texts;
            objCmdCadastroAlt3.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt3.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt3.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 04
            MySqlCommand objCmdCadastroAlt4 = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt4.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt4.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_04.Texts;
            objCmdCadastroAlt4.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_04.Texts;
            objCmdCadastroAlt4.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_04.Texts;
            objCmdCadastroAlt4.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_04.Texts;
            objCmdCadastroAlt4.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt4.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt4.ExecuteNonQuery();

            database.closeConnection();
        }

        private void NovaAlt_05()
        {
            configdb database = new configdb();
            database.openConnection();

            // INSERT TABELA RECRUTAMENTO
            MySqlCommand objCmdRecrutamento = new MySqlCommand("insert into hypedb.recrutamento (id_recrutamento, data_recrutamento, vem_do_cla, foi_para_cla) values (null, ?, ?, ?)", database.getConnection());

            objCmdRecrutamento.Parameters.Add("@data_recrutamento", MySqlDbType.Date).Value = DateTime.Now;
            objCmdRecrutamento.Parameters.Add("@vem_do_cla", MySqlDbType.VarChar, 256).Value = txt_vem.Texts;
            objCmdRecrutamento.Parameters.Add("@foi_para_cla", MySqlDbType.VarChar, 256).Value = txt_foi.Texts;

            objCmdRecrutamento.ExecuteNonQuery();
            long idRecruta = objCmdRecrutamento.LastInsertedId;

            // INSERT TABELA CADASTRO MEMBROS
            MySqlCommand objCmdCadastroMembros = new MySqlCommand("insert into hypedb.cadastro_membro (id_membros, nick, level, poder, classe, patente, id_recrutamento) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroMembros.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
            objCmdCadastroMembros.Parameters.Add("@level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdCadastroMembros.Parameters.Add("@poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdCadastroMembros.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
            objCmdCadastroMembros.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;
            objCmdCadastroMembros.Parameters.Add("@id_recrutamento", MySqlDbType.Int32).Value = idRecruta;

            objCmdCadastroMembros.ExecuteNonQuery();
            long idMembros = objCmdCadastroMembros.LastInsertedId;

            // INSERT TABELA PROGRESSÃO
            MySqlCommand objCmdProgressao = new MySqlCommand("insert into hypedb.progressao (id_progressao, data_progressao, antigo_poder, antigo_level, novo_poder, novo_level, id_membros) values (null, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdProgressao.Parameters.Add("@data_progressao", MySqlDbType.Date).Value = DateTime.Now;
            objCmdProgressao.Parameters.Add("@antigo_poder", MySqlDbType.Decimal).Value = txt_poder.Texts;
            objCmdProgressao.Parameters.Add("@antigo_level", MySqlDbType.Int32).Value = txt_level.Texts;
            objCmdProgressao.Parameters.Add("@novo_poder", MySqlDbType.Decimal).Value = 0.00;
            objCmdProgressao.Parameters.Add("@novo_level", MySqlDbType.Int32).Value = 0;
            objCmdProgressao.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdProgressao.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 01
            MySqlCommand objCmdCadastroAlt = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_01.Texts;
            objCmdCadastroAlt.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 02
            MySqlCommand objCmdCadastroAlt2 = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt2.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt2.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_02.Texts;
            objCmdCadastroAlt2.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt2.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt2.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 03
            MySqlCommand objCmdCadastroAlt3 = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt3.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt3.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_03.Texts;
            objCmdCadastroAlt3.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_03.Texts;
            objCmdCadastroAlt3.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_03.Texts;
            objCmdCadastroAlt3.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_03.Texts;
            objCmdCadastroAlt3.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt3.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt3.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 04
            MySqlCommand objCmdCadastroAlt4 = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt4.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt4.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_04.Texts;
            objCmdCadastroAlt4.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_04.Texts;
            objCmdCadastroAlt4.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_04.Texts;
            objCmdCadastroAlt4.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_04.Texts;
            objCmdCadastroAlt4.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt4.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt4.ExecuteNonQuery();

            // INSERT TABELA CADASTRO ALT 05
            MySqlCommand objCmdCadastroAlt5 = new MySqlCommand("insert into hypedb.cadastro_alt (id_alt, data_alt, nick_alt, level_alt, classe_alt, cla_alt, quantas_alt, id_membros) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

            objCmdCadastroAlt5.Parameters.Add("@data_alt", MySqlDbType.Date).Value = DateTime.Now;
            objCmdCadastroAlt5.Parameters.Add("@nick_alt", MySqlDbType.VarChar, 256).Value = txt_nick_alt_05.Texts;
            objCmdCadastroAlt5.Parameters.Add("@level_alt", MySqlDbType.Int32).Value = txt_level_alt_05.Texts;
            objCmdCadastroAlt5.Parameters.Add("@classe_alt", MySqlDbType.VarChar, 256).Value = txt_classe_alt_05.Texts;
            objCmdCadastroAlt5.Parameters.Add("@cla_alt", MySqlDbType.VarChar, 256).Value = txt_foi_alt_05.Texts;
            objCmdCadastroAlt5.Parameters.Add("@quantas_alt", MySqlDbType.Int32).Value = txt_quantidade_alt.Texts;
            objCmdCadastroAlt5.Parameters.Add("@id_membros", MySqlDbType.Int32).Value = idMembros;

            objCmdCadastroAlt5.ExecuteNonQuery();

            database.closeConnection();
        }
        #endregion

        #region BOTÕES
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Alertas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        private void VoltarMembros()
        {
            membros uc = new membros();
            cla.Instance.addControl(uc);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            LimparCadastro();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            try
            {
                VoltarMembros();
                LimparCadastro();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }

        private void rd_sim_CheckedChanged(object sender, EventArgs e)
        {
            txt_quantidade_alt.Enabled = true;

            txt_quantidade_alt.SelectedIndex = 1;

            tem_alt = "SIM";
        }

        private void rd_nao_CheckedChanged(object sender, EventArgs e)
        {
            
            txt_quantidade_alt.Enabled = false;
            txt_quantidade_alt.SelectedIndex = 0;

            LimparTextoAlt(pl_conta_alt_01.Controls);
            LimparTextoAlt(pl_conta_alt_02.Controls);
            LimparTextoAlt(pl_conta_alt_03.Controls);
            LimparTextoAlt(pl_conta_alt_04.Controls);
            LimparTextoAlt(pl_conta_alt_05.Controls);

            CampoTextoAltDesativado(this.pl_conta_alt_01.Controls);

            tem_alt = "NÃO";
        }      

        private void txt_quantidade_alt_SelectedIndexChanged(object sender, EventArgs e)
        { 
                     
            // HABILITA O CADASTRO PARA CADA QUANTIDADE
            switch (txt_quantidade_alt.SelectedIndex)
            {
                case 0:
                    PainelAlt_00();
                    break;
                case 1:
                    PainelAlt_01();
                    break;
                case 2:
                    PainelAlt_02();
                    break;
                case 3:
                    PainelAlt_03();
                    break;
                case 4:
                    PainelAlt_04();
                    break;
                case 5:
                    PainelAlt_05();
                    break;
                default:
                    break;
            }
            
        }
        #endregion

        #region Limpar Cadastro
        private void LimparCadastro()
        {
            txt_quantidade_alt.Enabled = false;
            txt_quantidade_alt.SelectedIndex = 0;

            txt_patente.SelectedIndex = 0;

            LimparTextoCadastro(pl_conta_principal.Controls);

            LimparTextoAlt(pl_conta_alt_01.Controls);
            LimparTextoAlt(pl_conta_alt_02.Controls);
            LimparTextoAlt(pl_conta_alt_03.Controls);
            LimparTextoAlt(pl_conta_alt_04.Controls);
            LimparTextoAlt(pl_conta_alt_05.Controls);

            CampoTextoAltDesativado(this.pl_conta_alt_01.Controls);
        }

        private void LimparTextoAlt(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)(c)).Texts = string.Empty;
                }

                if (c is RJComboBox)
                {
                    ((RJComboBox)(c)).SelectedIndex = -1;
                }
            }
        }

        private void LimparTextoCadastro(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)(c)).Texts = string.Empty;
                }

                if (c is RJComboBox)
                {
                    ((RJComboBox)(c)).SelectedIndex = 0;
                }
            }
        }

        private void CampoTextoAltDesativado(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)c).Enabled = false;
                    ((RJTextBox)c).BackColor = Color.FromArgb(32, 34, 37);
                    ((RJTextBox)c).PlaceholderText = "";
                }

                if (c is RJComboBox)
                {
                    ((RJComboBox)c).Enabled = false;
                    ((RJComboBox)c).BackColor = Color.FromArgb(32, 34, 37);
                    ((RJComboBox)c).SelectedIndex = -1;

                }
            }
        }

        private void CampoTextoAltHabilitado(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)c).Enabled = true;
                    ((RJTextBox)c).BackColor = Color.White;                  
                }

                if (c is RJComboBox)
                {
                    ((RJComboBox)c).Enabled = true;
                    ((RJComboBox)c).BackColor = Color.White;
                    ((RJComboBox)c).SelectedIndex = 0;
                }
            }
        }
        #endregion

        #region CAMPO TEXTO
        private void txt_nick_Enter(object sender, EventArgs e)
        {
            txt_nick.BorderSize = 1;
        }

        private void txt_level_Enter(object sender, EventArgs e)
        {
            txt_level.BorderSize = 1;
        }

        private void txt_poder_Enter(object sender, EventArgs e)
        {
            txt_poder.BorderSize = 1;
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

        private void txt_vem_Enter(object sender, EventArgs e)
        {
            txt_vem.BorderSize = 1;
        }

        private void txt_foi_Enter(object sender, EventArgs e)
        {
            txt_foi.BorderSize = 1;
        }

        private void txt_nick_alt_01_Enter(object sender, EventArgs e)
        {
            txt_nick_alt_01.BorderSize = 1;
        }

        private void txt_level_alt_01_Enter(object sender, EventArgs e)
        {
            txt_level_alt_01.BorderSize = 1;
        }

        private void txt_classe_alt_01_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe_alt_01.SelectedIndex > 0)
            {
                txt_classe_alt_01.BorderColor = Color.Transparent;
                txt_classe_alt_01.BorderSize = 0;
            }
        }

        private void txt_foi_alt_01_Enter(object sender, EventArgs e)
        {
            txt_foi_alt_01.BorderSize = 1;
        }

        private void txt_nick_alt_02_Enter(object sender, EventArgs e)
        {
            txt_nick_alt_02.BorderSize = 1;
        }

        private void txt_level_alt_02_Enter(object sender, EventArgs e)
        {
            txt_level_alt_02.BorderSize = 1;
        }

        private void txt_classe_alt_02_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe_alt_02.SelectedIndex > 0)
            {
                txt_classe_alt_02.BorderColor = Color.Transparent;
                txt_classe_alt_02.BorderSize = 0;
            }
        }

        private void txt_foi_alt_02_Enter(object sender, EventArgs e)
        {
            txt_foi_alt_02.BorderSize = 1;
        }

        private void txt_nick_alt_03_Enter(object sender, EventArgs e)
        {
            txt_nick_alt_03.BorderSize = 1;
        }

        private void txt_level_alt_03_Enter(object sender, EventArgs e)
        {
            txt_level_alt_03.BorderSize = 1;
        }

        private void txt_classe_alt_03_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe_alt_03.SelectedIndex > 0)
            {
                txt_classe_alt_03.BorderColor = Color.Transparent;
                txt_classe_alt_03.BorderSize = 0;
            }
        }

        private void txt_foi_alt_03_Enter(object sender, EventArgs e)
        {
            txt_foi_alt_03.BorderSize = 1;
        }

        private void txt_nick_alt_04_Enter(object sender, EventArgs e)
        {
            txt_nick_alt_04.BorderSize = 1;
        }

        private void txt_level_alt_04_Enter(object sender, EventArgs e)
        {
            txt_level_alt_04.BorderSize = 1;
        }

        private void txt_classe_alt_04_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe_alt_04.SelectedIndex > 0)
            {
                txt_classe_alt_04.BorderColor = Color.Transparent;
                txt_classe_alt_04.BorderSize = 0;
            }
        }

        private void txt_foi_alt_04_Enter(object sender, EventArgs e)
        {
            txt_foi_alt_04.BorderSize = 1;
        }

        private void txt_nick_alt_05_Enter(object sender, EventArgs e)
        {
            txt_nick_alt_05.BorderSize = 1;
        }

        private void txt_level_alt_05_Enter(object sender, EventArgs e)
        {
            txt_level_alt_05.BorderSize = 1;
        }

        private void txt_classe_alt_05_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe_alt_05.SelectedIndex > 0)
            {
                txt_classe_alt_05.BorderColor = Color.Transparent;
                txt_classe_alt_05.BorderSize = 0;
            }
        }

        private void txt_foi_alt_05_Enter(object sender, EventArgs e)
        {
            txt_foi_alt_05.BorderSize = 1;
        }
        #endregion

        #region CAMPO DO TEXTO EM BRANCO - ALERTAS
        private void Alertas()
        {
            #region MEMBRO
            if (txt_quantidade_alt.SelectedIndex == 0)
            {
                // CADASTRO
                if (String.IsNullOrEmpty(txt_nick.Texts))
                {
                    txt_nick.BorderColor = Color.Red;
                    txt_nick.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level.Texts))
                {
                    txt_level.BorderColor = Color.Red;
                    txt_level.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_poder.Texts))
                {
                    txt_poder.BorderColor = Color.Red;
                    txt_poder.BorderSize = 3;
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
                else if (String.IsNullOrEmpty(txt_vem.Texts))
                {
                    txt_vem.BorderColor = Color.Red;
                    txt_vem.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi.Texts))
                {
                    txt_foi.BorderColor = Color.Red;
                    txt_foi.BorderSize = 3;
                }
                else
                {
                    try
                    {
                        Cadastro();
                        DialogResult dr = MessageBox.Show("Salvo Com Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        LimparCadastro();
                        rd_nao.Checked = true;
                    }
                }
            }
            #endregion

            #region ALT 01
            if (txt_quantidade_alt.SelectedIndex == 1)
            {
                // ALT 01
                if (String.IsNullOrEmpty(txt_nick_alt_01.Texts))
                {
                    txt_nick_alt_01.BorderColor = Color.Red;
                    txt_nick_alt_01.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_01.Texts))
                {
                    txt_level_alt_01.BorderColor = Color.Red;
                    txt_level_alt_01.BorderSize = 3;
                }
                else if (txt_classe_alt_01.SelectedIndex == 0)
                {
                    txt_classe_alt_01.BorderColor = Color.Red;
                    txt_classe_alt_01.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_01.Texts))
                {
                    txt_foi_alt_01.BorderColor = Color.Red;
                    txt_foi_alt_01.BorderSize = 3;
                }
                else
                {
                    try
                    {
                        Cadastro();
                        DialogResult dr = MessageBox.Show("Salvo Com Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        LimparCadastro();
                        rd_nao.Checked = true;
                    }
                }
            }
            #endregion

            #region ALT 02
            if (txt_quantidade_alt.SelectedIndex == 2)
            {
                // ALT 01
                if (String.IsNullOrEmpty(txt_nick_alt_01.Texts))
                {
                    txt_nick_alt_01.BorderColor = Color.Red;
                    txt_nick_alt_01.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_01.Texts))
                {
                    txt_level_alt_01.BorderColor = Color.Red;
                    txt_level_alt_01.BorderSize = 3;
                }
                else if (txt_classe_alt_01.SelectedIndex == 0)
                {
                    txt_classe_alt_01.BorderColor = Color.Red;
                    txt_classe_alt_01.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_01.Texts))
                {
                    txt_foi_alt_01.BorderColor = Color.Red;
                    txt_foi_alt_01.BorderSize = 3;
                }

                // ALT 02
                else if (String.IsNullOrEmpty(txt_nick_alt_02.Texts))
                {
                    txt_nick_alt_02.BorderColor = Color.Red;
                    txt_nick_alt_02.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_02.Texts))
                {
                    txt_level_alt_02.BorderColor = Color.Red;
                    txt_level_alt_02.BorderSize = 3;
                }
                else if (txt_classe_alt_02.SelectedIndex == 0)
                {
                    txt_classe_alt_02.BorderColor = Color.Red;
                    txt_classe_alt_02.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_02.Texts))
                {
                    txt_foi_alt_02.BorderColor = Color.Red;
                    txt_foi_alt_02.BorderSize = 3;
                }
                else
                {
                    try
                    {
                        Cadastro();
                        DialogResult dr = MessageBox.Show("Salvo Com Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        LimparCadastro();
                        rd_nao.Checked = true;
                    }
                }
            }
            #endregion

            #region ALT 03
            if (txt_quantidade_alt.SelectedIndex == 3)
            {
                // ALT 01
                if (String.IsNullOrEmpty(txt_nick_alt_01.Texts))
                {
                    txt_nick_alt_01.BorderColor = Color.Red;
                    txt_nick_alt_01.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_01.Texts))
                {
                    txt_level_alt_01.BorderColor = Color.Red;
                    txt_level_alt_01.BorderSize = 3;
                }
                else if (txt_classe_alt_01.SelectedIndex == 0)
                {
                    txt_classe_alt_01.BorderColor = Color.Red;
                    txt_classe_alt_01.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_01.Texts))
                {
                    txt_foi_alt_01.BorderColor = Color.Red;
                    txt_foi_alt_01.BorderSize = 3;
                }

                // ALT 02
                else if (String.IsNullOrEmpty(txt_nick_alt_02.Texts))
                {
                    txt_nick_alt_02.BorderColor = Color.Red;
                    txt_nick_alt_02.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_02.Texts))
                {
                    txt_level_alt_02.BorderColor = Color.Red;
                    txt_level_alt_02.BorderSize = 3;
                }
                else if (txt_classe_alt_02.SelectedIndex == 0)
                {
                    txt_classe_alt_02.BorderColor = Color.Red;
                    txt_classe_alt_02.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_02.Texts))
                {
                    txt_foi_alt_02.BorderColor = Color.Red;
                    txt_foi_alt_02.BorderSize = 3;
                }           

                // ALT 03
                else if (String.IsNullOrEmpty(txt_nick_alt_03.Texts))
                {
                    txt_nick_alt_03.BorderColor = Color.Red;
                    txt_nick_alt_03.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_03.Texts))
                {
                    txt_level_alt_03.BorderColor = Color.Red;
                    txt_level_alt_03.BorderSize = 3;
                }
                else if (txt_classe_alt_03.SelectedIndex == 0)
                {
                    txt_classe_alt_03.BorderColor = Color.Red;
                    txt_classe_alt_03.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_03.Texts))
                {
                    txt_foi_alt_03.BorderColor = Color.Red;
                    txt_foi_alt_03.BorderSize = 3;
                }
                else
                {
                    try
                    {
                        Cadastro();
                        DialogResult dr = MessageBox.Show("Salvo Com Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        LimparCadastro();
                        rd_nao.Checked = true;
                    }
                }
            }
            #endregion

            #region ALT 04
            if (txt_quantidade_alt.SelectedIndex == 4)
            {
                // ALT 01
                if (String.IsNullOrEmpty(txt_nick_alt_01.Texts))
                {
                    txt_nick_alt_01.BorderColor = Color.Red;
                    txt_nick_alt_01.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_01.Texts))
                {
                    txt_level_alt_01.BorderColor = Color.Red;
                    txt_level_alt_01.BorderSize = 3;
                }
                else if (txt_classe_alt_01.SelectedIndex == 0)
                {
                    txt_classe_alt_01.BorderColor = Color.Red;
                    txt_classe_alt_01.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_01.Texts))
                {
                    txt_foi_alt_01.BorderColor = Color.Red;
                    txt_foi_alt_01.BorderSize = 3;
                }

                // ALT 02
                else if (String.IsNullOrEmpty(txt_nick_alt_02.Texts))
                {
                    txt_nick_alt_02.BorderColor = Color.Red;
                    txt_nick_alt_02.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_02.Texts))
                {
                    txt_level_alt_02.BorderColor = Color.Red;
                    txt_level_alt_02.BorderSize = 3;
                }
                else if (txt_classe_alt_02.SelectedIndex == 0)
                {
                    txt_classe_alt_02.BorderColor = Color.Red;
                    txt_classe_alt_02.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_02.Texts))
                {
                    txt_foi_alt_02.BorderColor = Color.Red;
                    txt_foi_alt_02.BorderSize = 3;
                }

                // ALT 03
                else if (String.IsNullOrEmpty(txt_nick_alt_03.Texts))
                {
                    txt_nick_alt_03.BorderColor = Color.Red;
                    txt_nick_alt_03.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_03.Texts))
                {
                    txt_level_alt_03.BorderColor = Color.Red;
                    txt_level_alt_03.BorderSize = 3;
                }
                else if (txt_classe_alt_03.SelectedIndex == 0)
                {
                    txt_classe_alt_03.BorderColor = Color.Red;
                    txt_classe_alt_03.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_03.Texts))
                {
                    txt_foi_alt_03.BorderColor = Color.Red;
                    txt_foi_alt_03.BorderSize = 3;
                }

                // ALT 04
                else if (String.IsNullOrEmpty(txt_nick_alt_04.Texts))
                {
                    txt_nick_alt_04.BorderColor = Color.Red;
                    txt_nick_alt_04.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_04.Texts))
                {
                    txt_level_alt_04.BorderColor = Color.Red;
                    txt_level_alt_04.BorderSize = 3;
                }
                else if (txt_classe_alt_04.SelectedIndex == 0)
                {
                    txt_classe_alt_04.BorderColor = Color.Red;
                    txt_classe_alt_04.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_04.Texts))
                {
                    txt_foi_alt_04.BorderColor = Color.Red;
                    txt_foi_alt_04.BorderSize = 3;
                }
                else
                {
                    try
                    {
                        Cadastro();
                        DialogResult dr = MessageBox.Show("Salvo Com Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        LimparCadastro();
                        rd_nao.Checked = true;
                    }
                }
            }
            #endregion

            #region ALT 05
            if (txt_quantidade_alt.SelectedIndex == 5)
            {
                // ALT 01
                if (String.IsNullOrEmpty(txt_nick_alt_01.Texts))
                {
                    txt_nick_alt_01.BorderColor = Color.Red;
                    txt_nick_alt_01.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_01.Texts))
                {
                    txt_level_alt_01.BorderColor = Color.Red;
                    txt_level_alt_01.BorderSize = 3;
                }
                else if (txt_classe_alt_01.SelectedIndex == 0)
                {
                    txt_classe_alt_01.BorderColor = Color.Red;
                    txt_classe_alt_01.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_01.Texts))
                {
                    txt_foi_alt_01.BorderColor = Color.Red;
                    txt_foi_alt_01.BorderSize = 3;
                }

                // ALT 02
                else if (String.IsNullOrEmpty(txt_nick_alt_02.Texts))
                {
                    txt_nick_alt_02.BorderColor = Color.Red;
                    txt_nick_alt_02.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_02.Texts))
                {
                    txt_level_alt_02.BorderColor = Color.Red;
                    txt_level_alt_02.BorderSize = 3;
                }
                else if (txt_classe_alt_02.SelectedIndex == 0)
                {
                    txt_classe_alt_02.BorderColor = Color.Red;
                    txt_classe_alt_02.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_02.Texts))
                {
                    txt_foi_alt_02.BorderColor = Color.Red;
                    txt_foi_alt_02.BorderSize = 3;
                }

                // ALT 03
                else if (String.IsNullOrEmpty(txt_nick_alt_03.Texts))
                {
                    txt_nick_alt_03.BorderColor = Color.Red;
                    txt_nick_alt_03.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_03.Texts))
                {
                    txt_level_alt_03.BorderColor = Color.Red;
                    txt_level_alt_03.BorderSize = 3;
                }
                else if (txt_classe_alt_03.SelectedIndex == 0)
                {
                    txt_classe_alt_03.BorderColor = Color.Red;
                    txt_classe_alt_03.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_03.Texts))
                {
                    txt_foi_alt_03.BorderColor = Color.Red;
                    txt_foi_alt_03.BorderSize = 3;
                }

                // ALT 04
                else if (String.IsNullOrEmpty(txt_nick_alt_04.Texts))
                {
                    txt_nick_alt_04.BorderColor = Color.Red;
                    txt_nick_alt_04.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_04.Texts))
                {
                    txt_level_alt_04.BorderColor = Color.Red;
                    txt_level_alt_04.BorderSize = 3;
                }
                else if (txt_classe_alt_04.SelectedIndex == 0)
                {
                    txt_classe_alt_04.BorderColor = Color.Red;
                    txt_classe_alt_04.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_04.Texts))
                {
                    txt_foi_alt_04.BorderColor = Color.Red;
                    txt_foi_alt_04.BorderSize = 3;
                }

                // ALT 05
                else if (String.IsNullOrEmpty(txt_nick_alt_05.Texts))
                {
                    txt_nick_alt_05.BorderColor = Color.Red;
                    txt_nick_alt_05.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_level_alt_05.Texts))
                {
                    txt_level_alt_05.BorderColor = Color.Red;
                    txt_level_alt_05.BorderSize = 3;
                }
                else if (txt_classe_alt_05.SelectedIndex == 0)
                {
                    txt_classe_alt_05.BorderColor = Color.Red;
                    txt_classe_alt_05.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_foi_alt_05.Texts))
                {
                    txt_foi_alt_05.BorderColor = Color.Red;
                    txt_foi_alt_05.BorderSize = 3;
                }
                else
                {
                    try
                    {
                        Cadastro();
                        DialogResult dr = MessageBox.Show("Salvo Com Sucesso !", "Membros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        LimparCadastro();
                        rd_nao.Checked = true;
                    }
                }
            }
            #endregion
        }

        private void txt_nick_Leave(object sender, EventArgs e)
        {
            txt_nick.BorderColor = Color.Transparent;
            txt_nick.BorderSize = 0;
        }

        private void txt_level_Leave(object sender, EventArgs e)
        {
            txt_level.BorderColor = Color.Transparent;
            txt_level.BorderSize = 0;
        }

        private void txt_poder_Leave(object sender, EventArgs e)
        {
            txt_poder.BorderColor = Color.Transparent;
            txt_poder.BorderSize = 0;
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

        private void txt_vem_Leave(object sender, EventArgs e)
        {
            txt_vem.BorderColor = Color.Transparent;
            txt_vem.BorderSize = 0;
        }

        private void txt_foi_Leave(object sender, EventArgs e)
        {
            txt_foi.BorderColor = Color.Transparent;
            txt_foi.BorderSize = 0;
        }

        private void txt_nick_alt_01_Leave(object sender, EventArgs e)
        {
            txt_nick_alt_01.BorderColor = Color.Transparent;
            txt_nick_alt_01.BorderSize = 0;
        }

        private void txt_level_alt_01_Leave(object sender, EventArgs e)
        {
            txt_level_alt_01.BorderColor = Color.Transparent;
            txt_level_alt_01.BorderSize = 0;
        }

        private void txt_classe_alt_01_Leave(object sender, EventArgs e)
        {
            txt_classe_alt_01.BorderColor = Color.Transparent;
            txt_classe_alt_01.BorderSize = 0;
        }

        private void txt_foi_alt_01_Leave(object sender, EventArgs e)
        {
            txt_foi_alt_01.BorderColor = Color.Transparent;
            txt_foi_alt_01.BorderSize = 0;
        }

        private void txt_nick_alt_02_Leave(object sender, EventArgs e)
        {
            txt_nick_alt_02.BorderColor = Color.Transparent;
            txt_nick_alt_02.BorderSize = 0;
        }

        private void txt_level_alt_02_Leave(object sender, EventArgs e)
        {
            txt_level_alt_02.BorderColor = Color.Transparent;
            txt_level_alt_02.BorderSize = 0;
        }

        private void txt_classe_alt_02_Leave(object sender, EventArgs e)
        {
            txt_classe_alt_02.BorderColor = Color.Transparent;
            txt_classe_alt_02.BorderSize = 0;
        }

        private void txt_foi_alt_02_Leave(object sender, EventArgs e)
        {
            txt_foi_alt_02.BorderColor = Color.Transparent;
            txt_foi_alt_02.BorderSize = 0;
        }

        private void txt_nick_alt_03_Leave(object sender, EventArgs e)
        {
            txt_nick_alt_03.BorderColor = Color.Transparent;
            txt_nick_alt_03.BorderSize = 0;
        }

        private void txt_level_alt_03_Leave(object sender, EventArgs e)
        {
            txt_level_alt_03.BorderColor = Color.Transparent;
            txt_level_alt_03.BorderSize = 0;
        }

        private void txt_classe_alt_03_Leave(object sender, EventArgs e)
        {
            txt_classe_alt_03.BorderColor = Color.Transparent;
            txt_classe_alt_03.BorderSize = 0;
        }

        private void txt_foi_alt_03_Leave(object sender, EventArgs e)
        {
            txt_foi_alt_03.BorderColor = Color.Transparent;
            txt_foi_alt_03.BorderSize = 0;
        }

        private void txt_nick_alt_04_Leave(object sender, EventArgs e)
        {
            txt_nick_alt_04.BorderColor = Color.Transparent;
            txt_nick_alt_04.BorderSize = 0;
        }

        private void txt_level_alt_04_Leave(object sender, EventArgs e)
        {
            txt_level_alt_04.BorderColor = Color.Transparent;
            txt_level_alt_04.BorderSize = 0;
        }

        private void txt_classe_alt_04_Leave(object sender, EventArgs e)
        {
            txt_classe_alt_04.BorderColor = Color.Transparent;
            txt_classe_alt_04.BorderSize = 0;
        }

        private void txt_foi_alt_04_Leave(object sender, EventArgs e)
        {
            txt_foi_alt_04.BorderColor = Color.Transparent;
            txt_foi_alt_04.BorderSize = 0;
        }

        private void txt_nick_alt_05_Leave(object sender, EventArgs e)
        {
            txt_nick_alt_05.BorderColor = Color.Transparent;
            txt_nick_alt_05.BorderSize = 0;
        }

        private void txt_level_alt_05_Leave(object sender, EventArgs e)
        {
            txt_level_alt_05.BorderColor = Color.Transparent;
            txt_level_alt_05.BorderSize = 0;
        }

        private void txt_classe_alt_05_Leave(object sender, EventArgs e)
        {
            txt_classe_alt_05.BorderColor = Color.Transparent;
            txt_classe_alt_05.BorderSize = 0;
        }

        private void txt_foi_alt_05_Leave(object sender, EventArgs e)
        {
            txt_foi_alt_05.BorderColor = Color.Transparent;
            txt_foi_alt_05.BorderSize = 0;
        }
        #endregion

        #region PAINEIS DOS CADASTROS
        private void PainelAlt_00()
        {
            PainelContaALT();
        }

        private void PainelContaALT()
        {
            if (txt_quantidade_alt.SelectedIndex == 0)
                rd_nao.Checked = true;

            CampoTextoAltDesativado(this.pl_conta_alt_01.Controls);
            CampoTextoAltDesativado(this.pl_conta_alt_02.Controls);
            CampoTextoAltDesativado(this.pl_conta_alt_03.Controls);
            CampoTextoAltDesativado(this.pl_conta_alt_04.Controls);
            CampoTextoAltDesativado(this.pl_conta_alt_05.Controls);
        }

        private void PainelAlt_01()
        {
            txt_nick_alt_01.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_01.PlaceholderText = "Level";
            txt_foi_alt_01.PlaceholderText = "Foi para o clã";

            CampoTextoAltHabilitado(this.pl_conta_alt_01.Controls);        

            CampoTextoAltDesativado(this.pl_conta_alt_02.Controls);
            CampoTextoAltDesativado(this.pl_conta_alt_03.Controls);
            CampoTextoAltDesativado(this.pl_conta_alt_04.Controls);
            CampoTextoAltDesativado(this.pl_conta_alt_05.Controls);
        }

        private void PainelAlt_02()
        {
            txt_nick_alt_01.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_01.PlaceholderText = "Level";
            txt_foi_alt_01.PlaceholderText = "Foi para o clã";

            txt_nick_alt_02.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_02.PlaceholderText = "Level";
            txt_foi_alt_02.PlaceholderText = "Foi para o clã";

            CampoTextoAltHabilitado(this.pl_conta_alt_01.Controls);
            CampoTextoAltHabilitado(this.pl_conta_alt_02.Controls);

            CampoTextoAltDesativado(this.pl_conta_alt_03.Controls);
            CampoTextoAltDesativado(this.pl_conta_alt_04.Controls);
            CampoTextoAltDesativado(this.pl_conta_alt_05.Controls);
        }

        private void PainelAlt_03()
        {
            txt_nick_alt_01.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_01.PlaceholderText = "Level";
            txt_foi_alt_01.PlaceholderText = "Foi para o clã";

            txt_nick_alt_02.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_02.PlaceholderText = "Level";
            txt_foi_alt_02.PlaceholderText = "Foi para o clã";

            txt_nick_alt_03.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_03.PlaceholderText = "Level";
            txt_foi_alt_03.PlaceholderText = "Foi para o clã";

            CampoTextoAltHabilitado(this.pl_conta_alt_01.Controls);
            CampoTextoAltHabilitado(this.pl_conta_alt_02.Controls);
            CampoTextoAltHabilitado(this.pl_conta_alt_03.Controls);

            CampoTextoAltDesativado(this.pl_conta_alt_04.Controls);
            CampoTextoAltDesativado(this.pl_conta_alt_05.Controls);

        }

        private void PainelAlt_04()
        {
            txt_nick_alt_01.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_01.PlaceholderText = "Level";
            txt_foi_alt_01.PlaceholderText = "Foi para o clã";

            txt_nick_alt_02.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_02.PlaceholderText = "Level";
            txt_foi_alt_02.PlaceholderText = "Foi para o clã";

            txt_nick_alt_03.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_03.PlaceholderText = "Level";
            txt_foi_alt_03.PlaceholderText = "Foi para o clã";

            txt_nick_alt_04.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_04.PlaceholderText = "Level";
            txt_foi_alt_04.PlaceholderText = "Foi para o clã";

            CampoTextoAltHabilitado(this.pl_conta_alt_01.Controls);
            CampoTextoAltHabilitado(this.pl_conta_alt_02.Controls);
            CampoTextoAltHabilitado(this.pl_conta_alt_03.Controls);
            CampoTextoAltHabilitado(this.pl_conta_alt_04.Controls);

            CampoTextoAltDesativado(this.pl_conta_alt_05.Controls);
        }

        private void PainelAlt_05()
        {
            txt_nick_alt_01.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_01.PlaceholderText = "Level";
            txt_foi_alt_01.PlaceholderText = "Foi para o clã";

            txt_nick_alt_02.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_02.PlaceholderText = "Level";
            txt_foi_alt_02.PlaceholderText = "Foi para o clã";

            txt_nick_alt_03.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_03.PlaceholderText = "Level";
            txt_foi_alt_03.PlaceholderText = "Foi para o clã";

            txt_nick_alt_04.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_04.PlaceholderText = "Level";
            txt_foi_alt_04.PlaceholderText = "Foi para o clã";

            txt_nick_alt_05.PlaceholderText = "Qual é o Nick ?";
            txt_level_alt_05.PlaceholderText = "Level";
            txt_foi_alt_05.PlaceholderText = "Foi para o clã";

            CampoTextoAltHabilitado(this.pl_conta_alt_01.Controls);
            CampoTextoAltHabilitado(this.pl_conta_alt_02.Controls);
            CampoTextoAltHabilitado(this.pl_conta_alt_03.Controls);
            CampoTextoAltHabilitado(this.pl_conta_alt_04.Controls);
            CampoTextoAltHabilitado(this.pl_conta_alt_05.Controls);
        }
        #endregion
    }
}
