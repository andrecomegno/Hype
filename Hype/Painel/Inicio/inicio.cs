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

        private void GraficoMembros()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select nick, level, poder, classe, patente from hypedb.cadastro_membro", database.getConnection());

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            chart_membros.DataSource = dt;
            chart_membros.Series[0].XValueMember = "nick";
            chart_membros.Series[0].YValueMembers = "level";

            chart_membros.DataBind();

            database.closeConnection();
        }

        private void GraficoDoacoes()
        {
            // colocar o ouro arrecadado do mes e se vai ter como fazer a expedicao 
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
            chart_progressao.Series[0].XValueMember = "nick";
            chart_progressao.Series[0].YValueMembers = "poder";

            chart_progressao.DataBind();

            database.closeConnection();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            GraficoMembros();
            GraficoDoacoes();
            GraficoProgressao();
        }
    }
}
