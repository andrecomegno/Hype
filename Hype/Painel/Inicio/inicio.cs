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

namespace Hype.Painel
{
    public partial class inicio : UserControl
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.DATA_RECRUTAMENTO, c.NICK, c.LEVEL, c.PODER, c.CLASSE, c.PATENTE, alt.ID_ALT, alt.DATA_ALT, alt.NICK_ALT, alt.LEVEL_ALT, alt.CLASSE_ALT, alt.CLA_ALT, pro.ID_PROGRESSAO, pro.DATA_PROGRESSAO, pro.ANTIGO_LEVEL, pro.ANTIGO_PODER, pro.NOVO_LEVEL, pro.NOVO_PODER, re.ID_RECRUTAMENTO, re.VEM_DO_CLA, re.FOI_PARA_CLA from hypedb.cadastro_membro c left join hypedb.cadastro_alt alt on c.ID_MEMBROS = alt.ID_ALT left join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS left join hypedb.progressao pro on pro.ID_PROGRESSAO = c.ID_MEMBROS ", database.getConnection());

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            chart3.DataSource = dt;
            chart3.Series[0].XValueMember = "PATENTE";
            chart3.Series[0].YValueMembers = "NICK";

            chart3.DataBind();

            chart1.DataSource = dt;
            chart1.Series[0].XValueMember = "CLASSE";
            chart1.Series[0].YValueMembers = "NICK";

            chart1.DataBind();

            database.closeConnection(); 
        }
    }
}
