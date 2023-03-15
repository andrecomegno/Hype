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

        #region Graficos
        private void GraficoMembros()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select nick, level, poder, classe, patente from hypedb.cadastro_membro", database.getConnection());

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            chart_membros.DataSource = dt;
            chart_membros.Series["Level"].XValueMember = "nick";
            chart_membros.Series["Level"].YValueMembers = "level";

            chart_membros.DataBind();

            // MEMBROS TOTAL
            lb_membros_valor.Text = "30";


            database.closeConnection();
        }

        private void GraficoDoacoes()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.ID_RECRUTAMENTO, d.ID_DOACAO, eve.ID_EVENTOS, re.FOI_PARA_CLA, c.CLASSE, c.PATENTE, eve.ANO_EVENTO, eve.MES_EVENTO, c.NICK, d.SEMANA_01, d.SEMANA_02, d.SEMANA_03, d.SEMANA_04, d.TOTAL, d.ANOTACAO from hypedb.cadastro_membro c join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS join hypedb.doacao d on d.ID_MEMBROS = c.ID_MEMBROS join hypedb.eventos eve on eve.ID_EVENTOS = d.ID_EVENTOS ", database.getConnection());

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            chart_doacao.DataSource = dt;
            chart_doacao.Series["doacao"].XValueMember = "nick";
            chart_doacao.Series["doacao"].YValueMembers = "total";

            chart_doacao.DataBind();

            // OURO TOTAL
            lb_ouro_valor.Text = "8.000,00";


            database.closeConnection();
        }

        private void GraficoProgressao()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select nick, level, poder, classe, patente from hypedb.cadastro_membro", database.getConnection());

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            chart_progressao.DataSource = dt;
            chart_progressao.Series["Poder Clã"].XValueMember = "nick";
            chart_progressao.Series["Poder Clã"].YValueMembers = "poder";

            chart_progressao.DataBind();

            // PODER TOTAL
            lb_poder_valor.Text = "100.523,00";

            database.closeConnection();
        }
        #endregion

        private void inicio_Load(object sender, EventArgs e)
        {
            GraficoMembros();
            GraficoDoacoes();
            GraficoProgressao();
        }
    }
}
