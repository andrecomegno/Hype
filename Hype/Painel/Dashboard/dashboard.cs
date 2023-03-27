using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hype.script;
using Hype.Painel.Home;

namespace Hype.Painel
{
    public partial class dashboard : UserControl
    {
        public static dashboard Instance;

        public string nome_cla = home.Instance.nome_cla;

        public dashboard()
        {
            InitializeComponent();

            Instance = this;            
        }

        #region GRAFICO
        private void GraficoMembros()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, c.NICK, c.LEVEL, re.VEM_DO_CLA from hypedb.cadastro_membro c join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS where re.VEM_DO_CLA like @VEM_DO_CLA '%' ", database.getConnection());
            cmd.Parameters.AddWithValue("@VEM_DO_CLA", nome_cla);

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                chart_membros.DataSource = dt;

                chart_membros.Series["Level"].XValueMember = "nick";
                chart_membros.Series["Level"].YValueMembers = "level";

                chart_membros.DataBind();
            }

            database.closeConnection();
        }

        private void GraficoDoacoes()
        {
            configdb database = new configdb();
            database.openConnection();            

            MySqlCommand cmd = new MySqlCommand("select c.ID_MEMBROS, re.ID_RECRUTAMENTO, d.ID_DOACAO, eve.ID_EVENTOS, re.VEM_DO_CLA, c.CLASSE, c.PATENTE, eve.ANO_EVENTO, eve.MES_EVENTO, c.NICK, d.SEMANA_01, d.SEMANA_02, d.SEMANA_03, d.SEMANA_04, d.TOTAL, d.ANOTACAO from hypedb.cadastro_membro c join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS join hypedb.doacao d on d.ID_MEMBROS = c.ID_MEMBROS join hypedb.eventos eve on eve.ID_EVENTOS = d.ID_EVENTOS where re.VEM_DO_CLA like @VEM_DO_CLA '%' and eve.MES_EVENTO like @MES_EVENTO '%' ", database.getConnection());
            cmd.Parameters.AddWithValue("@VEM_DO_CLA", nome_cla);
            cmd.Parameters.AddWithValue("@MES_EVENTO", DateTime.Now.ToString("MMMM"));

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                chart_doacao.DataSource = dt;

                chart_doacao.Series["doacao"].XValueMember = "nick";
                chart_doacao.Series["doacao"].YValueMembers = "total";

                chart_doacao.DataBind();
            }

            database.closeConnection();
        }

        private void GraficoProgressao()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.NICK, c.PODER, re.VEM_DO_CLA from hypedb.cadastro_membro c join hypedb.recrutamento re on re.ID_RECRUTAMENTO = c.ID_MEMBROS where re.VEM_DO_CLA like @VEM_DO_CLA '%'", database.getConnection());
            cmd.Parameters.AddWithValue("@VEM_DO_CLA", nome_cla);

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                chart_progressao.DataSource = dt;

                chart_progressao.Series["Poder Clã"].XValueMember = "nick";
                chart_progressao.Series["Poder Clã"].YValueMembers = "poder";

                chart_progressao.DataBind();
            }

            database.closeConnection();
        }
        #endregion

        #region GRAFICO TOPO
        private void Membros()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select c.NICK, cl.NOME_CLA, c.STATUS from hypedb.cadastro_membro c join hypedb.cadastro_cla cl on cl.ID_CLA = c.ID_MEMBROS where cl.NOME_CLA like @NOME_CLA '%' and c.STATUS like @STATUS '%'", database.getConnection());
            cmd.Parameters.AddWithValue("@NOME_CLA", nome_cla);
            cmd.Parameters.AddWithValue("@STATUS", "Ativo");

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int membros = dataGridView1.RowCount;
                lb_membros_valor.Text = membros.ToString();
            }

            database.closeConnection();
        }

        private void Ouro()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select sum(d.TOTAL) as TOTAL, cl.NOME_CLA from hypedb.cadastro_membro c join hypedb.doacao d on d.ID_MEMBROS = c.ID_MEMBROS join hypedb.cadastro_cla cl on cl.ID_CLA = c.ID_MEMBROS where cl.NOME_CLA like @NOME_CLA '%' and c.STATUS like @STATUS '%' ", database.getConnection());
            cmd.Parameters.AddWithValue("@NOME_CLA", nome_cla);
            cmd.Parameters.AddWithValue("@STATUS", "Ativo");

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;
            }

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lb_ouro_valor.Text = dr["TOTAL"].ToString();
            }

            database.closeConnection();
        }

        private void Poder()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select sum(c.poder) as TOTAL, cl.NOME_CLA from hypedb.cadastro_membro c join hypedb.cadastro_cla cl on cl.ID_CLA = c.ID_MEMBROS where cl.NOME_CLA like @NOME_CLA '%' and c.STATUS like @STATUS '%'", database.getConnection());
            cmd.Parameters.AddWithValue("@NOME_CLA", nome_cla);
            cmd.Parameters.AddWithValue("@STATUS", "Ativo");

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
            }

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lb_poder_valor.Text = dr["TOTAL"].ToString();
            }

            database.closeConnection();
        }
        #endregion

        private void inicio_Load(object sender, EventArgs e)
        {
            Membros();
            Ouro();
            Poder();

            GraficoMembros();
            GraficoDoacoes();
            GraficoProgressao();

            // COLORIR O TITULO DA TABELA
            dataGridView1.EnableHeadersVisualStyles = false;
        }
    }
}
