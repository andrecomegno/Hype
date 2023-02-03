using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hype.Properties;
using Hype.painel;
using Hype.script;
using MySql.Data.MySqlClient;

namespace Hype.painel
{
    public partial class membro_excluir : UserControl
    {
        string id = string.Empty;

        public membro_excluir()
        {
            InitializeComponent();
        }

        public void DadosMembros()
        {
            id = membros.Instance.id_membro;
            txt_nick.Texts = membros.Instance.nick;
            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Texts = membros.Instance.patente;
            txt_classe.Texts = membros.Instance.classe;
            txt_data_excluir.Texts = DateTime.Now.Date.ToShortDateString();
        }


        private void membro_excluir_Load(object sender, EventArgs e)
        {
            DadosMembros();            
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            perfil_membros uc = new perfil_membros();
            informacao.Instance.addControl(uc);
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                configdb database = new configdb();
                database.openConnection();

                MySqlCommand objCmdRecrutamento = new MySqlCommand("delete from cadastro_membro where ID=@id", database.getConnection());
                objCmdRecrutamento.Parameters.AddWithValue("@id", id);

                objCmdRecrutamento.ExecuteNonQuery();

                MessageBox.Show(id);


                /*
                // CAMPO ANOTAÇÃO
                MySqlCommand objCmdSaidaDoCla = new MySqlCommand("insert into hypedb.saida_do_cla (id, data_saida, nick, level, poder, classe, patente, anotacao) values (null, ?, ?, ?, ?, ?, ?, ?)", database.getConnection());

                objCmdSaidaDoCla.Parameters.Add("@data_saida", MySqlDbType.Date).Value = DateTime.Now;
                objCmdSaidaDoCla.Parameters.Add("@nick", MySqlDbType.VarChar, 256).Value = txt_nick.Texts;
                objCmdSaidaDoCla.Parameters.Add("@level", MySqlDbType.Int32, 256).Value = txt_level.Texts;
                objCmdSaidaDoCla.Parameters.Add("@poder", MySqlDbType.Decimal, 256).Value = txt_poder.Texts;
                objCmdSaidaDoCla.Parameters.Add("@classe", MySqlDbType.VarChar, 256).Value = txt_classe.Texts;
                objCmdSaidaDoCla.Parameters.Add("@patente", MySqlDbType.VarChar, 256).Value = txt_patente.Texts;
                objCmdSaidaDoCla.Parameters.Add("@anotacao", MySqlDbType.VarChar, 256).Value = txt_motivo.Text;

                objCmdSaidaDoCla.ExecuteNonQuery();
                */

                database.closeConnection();

                DialogResult dr = MessageBox.Show("Deletado Com Sucesso !", "DELETADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Código" + erro + "de Erro Interno ", "ERRO FATAL");
            }
        }




    }
}
