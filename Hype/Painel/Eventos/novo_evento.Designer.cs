
namespace Hype.Painel.Eventos
{
    partial class novo_evento
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pl_evento_doacoes = new System.Windows.Forms.Panel();
            this.pl_espaco_02 = new System.Windows.Forms.Panel();
            this.pl_doacao = new System.Windows.Forms.Panel();
            this.bt_buscar = new System.Windows.Forms.PictureBox();
            this.pl_evento_doacao = new System.Windows.Forms.Panel();
            this.bt_datas_esquerda = new System.Windows.Forms.Button();
            this.bt_datas_direita = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.lb_datas = new System.Windows.Forms.Label();
            this.lb_semana_02 = new System.Windows.Forms.Label();
            this.lb_semana_03 = new System.Windows.Forms.Label();
            this.lb_semana_01 = new System.Windows.Forms.Label();
            this.lb_semana_04 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pl_espaco_01 = new System.Windows.Forms.Panel();
            this.pl_top = new System.Windows.Forms.Panel();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.txt_data_evento = new System.Windows.Forms.Label();
            this.lb_data_entrada = new System.Windows.Forms.Label();
            this.txt_sem_dados = new System.Windows.Forms.Label();
            this.txt_ano_evento = new Hype.Painel.RJTextBox();
            this.txt_mes_evento = new Hype.script.RJComboBox();
            this.txt_buscar = new Hype.Painel.RJTextBox();
            this.txt_doacao_04 = new Hype.Painel.RJTextBox();
            this.txt_doacao_02 = new Hype.Painel.RJTextBox();
            this.txt_doacao_01 = new Hype.Painel.RJTextBox();
            this.txt_doacao_03 = new Hype.Painel.RJTextBox();
            this.pl_evento_doacoes.SuspendLayout();
            this.pl_doacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_buscar)).BeginInit();
            this.pl_evento_doacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_evento_doacoes
            // 
            this.pl_evento_doacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_evento_doacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_evento_doacoes.Controls.Add(this.pl_espaco_02);
            this.pl_evento_doacoes.Controls.Add(this.pl_doacao);
            this.pl_evento_doacoes.Controls.Add(this.pl_espaco_01);
            this.pl_evento_doacoes.Controls.Add(this.pl_top);
            this.pl_evento_doacoes.Location = new System.Drawing.Point(14, 3);
            this.pl_evento_doacoes.Name = "pl_evento_doacoes";
            this.pl_evento_doacoes.Size = new System.Drawing.Size(1172, 1008);
            this.pl_evento_doacoes.TabIndex = 78;
            // 
            // pl_espaco_02
            // 
            this.pl_espaco_02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_espaco_02.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_espaco_02.Location = new System.Drawing.Point(0, 803);
            this.pl_espaco_02.Name = "pl_espaco_02";
            this.pl_espaco_02.Size = new System.Drawing.Size(1172, 10);
            this.pl_espaco_02.TabIndex = 78;
            // 
            // pl_doacao
            // 
            this.pl_doacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_doacao.Controls.Add(this.txt_sem_dados);
            this.pl_doacao.Controls.Add(this.txt_ano_evento);
            this.pl_doacao.Controls.Add(this.txt_mes_evento);
            this.pl_doacao.Controls.Add(this.bt_buscar);
            this.pl_doacao.Controls.Add(this.txt_buscar);
            this.pl_doacao.Controls.Add(this.pl_evento_doacao);
            this.pl_doacao.Controls.Add(this.dataGridView1);
            this.pl_doacao.Controls.Add(this.lb_titulo);
            this.pl_doacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_doacao.Location = new System.Drawing.Point(0, 83);
            this.pl_doacao.Name = "pl_doacao";
            this.pl_doacao.Size = new System.Drawing.Size(1172, 720);
            this.pl_doacao.TabIndex = 64;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.bt_buscar.Image = global::Hype.Properties.Resources.buscar;
            this.bt_buscar.Location = new System.Drawing.Point(1079, 92);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(20, 20);
            this.bt_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_buscar.TabIndex = 195;
            this.bt_buscar.TabStop = false;
            // 
            // pl_evento_doacao
            // 
            this.pl_evento_doacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_evento_doacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_evento_doacao.Controls.Add(this.bt_datas_esquerda);
            this.pl_evento_doacao.Controls.Add(this.bt_datas_direita);
            this.pl_evento_doacao.Controls.Add(this.bt_salvar);
            this.pl_evento_doacao.Controls.Add(this.lb_datas);
            this.pl_evento_doacao.Controls.Add(this.txt_doacao_04);
            this.pl_evento_doacao.Controls.Add(this.lb_semana_02);
            this.pl_evento_doacao.Controls.Add(this.txt_doacao_02);
            this.pl_evento_doacao.Controls.Add(this.txt_doacao_01);
            this.pl_evento_doacao.Controls.Add(this.lb_semana_03);
            this.pl_evento_doacao.Controls.Add(this.lb_semana_01);
            this.pl_evento_doacao.Controls.Add(this.txt_doacao_03);
            this.pl_evento_doacao.Controls.Add(this.lb_semana_04);
            this.pl_evento_doacao.Location = new System.Drawing.Point(83, 594);
            this.pl_evento_doacao.Name = "pl_evento_doacao";
            this.pl_evento_doacao.Size = new System.Drawing.Size(1026, 80);
            this.pl_evento_doacao.TabIndex = 193;
            // 
            // bt_datas_esquerda
            // 
            this.bt_datas_esquerda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_datas_esquerda.BackColor = System.Drawing.Color.Goldenrod;
            this.bt_datas_esquerda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_datas_esquerda.FlatAppearance.BorderSize = 0;
            this.bt_datas_esquerda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_datas_esquerda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_datas_esquerda.ForeColor = System.Drawing.Color.White;
            this.bt_datas_esquerda.Location = new System.Drawing.Point(21, 15);
            this.bt_datas_esquerda.Name = "bt_datas_esquerda";
            this.bt_datas_esquerda.Size = new System.Drawing.Size(28, 52);
            this.bt_datas_esquerda.TabIndex = 264;
            this.bt_datas_esquerda.Text = "<";
            this.bt_datas_esquerda.UseVisualStyleBackColor = false;
            this.bt_datas_esquerda.Click += new System.EventHandler(this.bt_datas_esquerda_Click);
            // 
            // bt_datas_direita
            // 
            this.bt_datas_direita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_datas_direita.BackColor = System.Drawing.Color.Goldenrod;
            this.bt_datas_direita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_datas_direita.FlatAppearance.BorderSize = 0;
            this.bt_datas_direita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_datas_direita.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_datas_direita.ForeColor = System.Drawing.Color.White;
            this.bt_datas_direita.Location = new System.Drawing.Point(158, 15);
            this.bt_datas_direita.Name = "bt_datas_direita";
            this.bt_datas_direita.Size = new System.Drawing.Size(28, 52);
            this.bt_datas_direita.TabIndex = 263;
            this.bt_datas_direita.Text = ">";
            this.bt_datas_direita.UseVisualStyleBackColor = false;
            this.bt_datas_direita.Click += new System.EventHandler(this.bt_datas_direita_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_salvar.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvar.FlatAppearance.BorderSize = 0;
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.ForeColor = System.Drawing.Color.White;
            this.bt_salvar.Location = new System.Drawing.Point(565, 36);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(102, 31);
            this.bt_salvar.TabIndex = 262;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // lb_datas
            // 
            this.lb_datas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_datas.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lb_datas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_datas.ForeColor = System.Drawing.Color.White;
            this.lb_datas.Location = new System.Drawing.Point(22, 15);
            this.lb_datas.Name = "lb_datas";
            this.lb_datas.Size = new System.Drawing.Size(160, 52);
            this.lb_datas.TabIndex = 194;
            this.lb_datas.Text = "Janeiro";
            this.lb_datas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_semana_02
            // 
            this.lb_semana_02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_semana_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_semana_02.ForeColor = System.Drawing.Color.White;
            this.lb_semana_02.Location = new System.Drawing.Point(294, 15);
            this.lb_semana_02.Name = "lb_semana_02";
            this.lb_semana_02.Size = new System.Drawing.Size(81, 17);
            this.lb_semana_02.TabIndex = 185;
            this.lb_semana_02.Text = "Semana 2";
            this.lb_semana_02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_semana_03
            // 
            this.lb_semana_03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_semana_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_semana_03.ForeColor = System.Drawing.Color.White;
            this.lb_semana_03.Location = new System.Drawing.Point(380, 15);
            this.lb_semana_03.Name = "lb_semana_03";
            this.lb_semana_03.Size = new System.Drawing.Size(81, 17);
            this.lb_semana_03.TabIndex = 187;
            this.lb_semana_03.Text = "Semana 3";
            this.lb_semana_03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_semana_01
            // 
            this.lb_semana_01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_semana_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_semana_01.ForeColor = System.Drawing.Color.White;
            this.lb_semana_01.Location = new System.Drawing.Point(208, 15);
            this.lb_semana_01.Name = "lb_semana_01";
            this.lb_semana_01.Size = new System.Drawing.Size(81, 17);
            this.lb_semana_01.TabIndex = 183;
            this.lb_semana_01.Text = "Semana 1";
            this.lb_semana_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_semana_04
            // 
            this.lb_semana_04.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_semana_04.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_semana_04.ForeColor = System.Drawing.Color.White;
            this.lb_semana_04.Location = new System.Drawing.Point(466, 15);
            this.lb_semana_04.Name = "lb_semana_04";
            this.lb_semana_04.Size = new System.Drawing.Size(81, 17);
            this.lb_semana_04.TabIndex = 189;
            this.lb_semana_04.Text = "Semana 4";
            this.lb_semana_04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.dataGridView1.Location = new System.Drawing.Point(83, 123);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 465);
            this.dataGridView1.TabIndex = 192;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // lb_titulo
            // 
            this.lb_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(3, 3);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(1166, 31);
            this.lb_titulo.TabIndex = 96;
            this.lb_titulo.Text = "EVENTOS - DOAÇÃO";
            this.lb_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_espaco_01
            // 
            this.pl_espaco_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_espaco_01.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_espaco_01.Location = new System.Drawing.Point(0, 73);
            this.pl_espaco_01.Name = "pl_espaco_01";
            this.pl_espaco_01.Size = new System.Drawing.Size(1172, 10);
            this.pl_espaco_01.TabIndex = 77;
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_top.Controls.Add(this.bt_voltar);
            this.pl_top.Controls.Add(this.txt_data_evento);
            this.pl_top.Controls.Add(this.lb_data_entrada);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1172, 73);
            this.pl_top.TabIndex = 76;
            // 
            // bt_voltar
            // 
            this.bt_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_voltar.FlatAppearance.BorderSize = 0;
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltar.ForeColor = System.Drawing.Color.White;
            this.bt_voltar.Location = new System.Drawing.Point(0, 6);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(73, 36);
            this.bt_voltar.TabIndex = 59;
            this.bt_voltar.Text = "<<";
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // txt_data_evento
            // 
            this.txt_data_evento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_evento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_evento.ForeColor = System.Drawing.Color.White;
            this.txt_data_evento.Location = new System.Drawing.Point(1037, 6);
            this.txt_data_evento.Name = "txt_data_evento";
            this.txt_data_evento.Size = new System.Drawing.Size(132, 17);
            this.txt_data_evento.TabIndex = 73;
            this.txt_data_evento.Text = "Data do Evento";
            this.txt_data_evento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_data_entrada
            // 
            this.lb_data_entrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_data_entrada.AutoSize = true;
            this.lb_data_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_entrada.ForeColor = System.Drawing.Color.White;
            this.lb_data_entrada.Location = new System.Drawing.Point(1054, 23);
            this.lb_data_entrada.Name = "lb_data_entrada";
            this.lb_data_entrada.Size = new System.Drawing.Size(99, 20);
            this.lb_data_entrada.TabIndex = 70;
            this.lb_data_entrada.Text = "00/00/0000";
            // 
            // txt_sem_dados
            // 
            this.txt_sem_dados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sem_dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.txt_sem_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sem_dados.ForeColor = System.Drawing.Color.White;
            this.txt_sem_dados.Location = new System.Drawing.Point(95, 224);
            this.txt_sem_dados.Name = "txt_sem_dados";
            this.txt_sem_dados.Size = new System.Drawing.Size(1004, 31);
            this.txt_sem_dados.TabIndex = 265;
            this.txt_sem_dados.Text = "VOCÊ NÃO TEM NENHUMA DOAÇÃO";
            this.txt_sem_dados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ano_evento
            // 
            this.txt_ano_evento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ano_evento.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ano_evento.BorderColor = System.Drawing.Color.White;
            this.txt_ano_evento.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_ano_evento.BorderRadius = 0;
            this.txt_ano_evento.BorderSize = 1;
            this.txt_ano_evento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ano_evento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ano_evento.Location = new System.Drawing.Point(623, 85);
            this.txt_ano_evento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ano_evento.Multiline = false;
            this.txt_ano_evento.Name = "txt_ano_evento";
            this.txt_ano_evento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ano_evento.PasswordChar = false;
            this.txt_ano_evento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ano_evento.PlaceholderText = "Ano";
            this.txt_ano_evento.Size = new System.Drawing.Size(68, 31);
            this.txt_ano_evento.TabIndex = 197;
            this.txt_ano_evento.Texts = "";
            this.txt_ano_evento.UnderlinedStyle = false;
            // 
            // txt_mes_evento
            // 
            this.txt_mes_evento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mes_evento.BackColor = System.Drawing.Color.White;
            this.txt_mes_evento.BorderColor = System.Drawing.Color.Transparent;
            this.txt_mes_evento.BorderSize = 0;
            this.txt_mes_evento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_mes_evento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_mes_evento.ForeColor = System.Drawing.Color.DimGray;
            this.txt_mes_evento.IconColor = System.Drawing.Color.Black;
            this.txt_mes_evento.Items.AddRange(new object[] {
            "Mês",
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.txt_mes_evento.ListBackColor = System.Drawing.Color.White;
            this.txt_mes_evento.ListTextColor = System.Drawing.Color.DimGray;
            this.txt_mes_evento.Location = new System.Drawing.Point(698, 85);
            this.txt_mes_evento.MinimumSize = new System.Drawing.Size(50, 30);
            this.txt_mes_evento.Name = "txt_mes_evento";
            this.txt_mes_evento.Size = new System.Drawing.Size(130, 31);
            this.txt_mes_evento.TabIndex = 196;
            this.txt_mes_evento.Texts = "";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_buscar.BorderColor = System.Drawing.Color.Transparent;
            this.txt_buscar.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_buscar.BorderRadius = 15;
            this.txt_buscar.BorderSize = 2;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_buscar.Location = new System.Drawing.Point(835, 85);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Multiline = false;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_buscar.PasswordChar = false;
            this.txt_buscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_buscar.PlaceholderText = "O que você procura ?";
            this.txt_buscar.Size = new System.Drawing.Size(274, 31);
            this.txt_buscar.TabIndex = 194;
            this.txt_buscar.Texts = "";
            this.txt_buscar.UnderlinedStyle = false;
            // 
            // txt_doacao_04
            // 
            this.txt_doacao_04.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_doacao_04.BackColor = System.Drawing.SystemColors.Window;
            this.txt_doacao_04.BorderColor = System.Drawing.Color.Transparent;
            this.txt_doacao_04.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_doacao_04.BorderRadius = 0;
            this.txt_doacao_04.BorderSize = 1;
            this.txt_doacao_04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doacao_04.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_doacao_04.Location = new System.Drawing.Point(469, 36);
            this.txt_doacao_04.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doacao_04.Multiline = false;
            this.txt_doacao_04.Name = "txt_doacao_04";
            this.txt_doacao_04.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_doacao_04.PasswordChar = false;
            this.txt_doacao_04.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_doacao_04.PlaceholderText = "";
            this.txt_doacao_04.Size = new System.Drawing.Size(78, 31);
            this.txt_doacao_04.TabIndex = 188;
            this.txt_doacao_04.Texts = "";
            this.txt_doacao_04.UnderlinedStyle = false;
            this.txt_doacao_04.Enter += new System.EventHandler(this.txt_doacao_04_Enter);
            // 
            // txt_doacao_02
            // 
            this.txt_doacao_02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_doacao_02.BackColor = System.Drawing.SystemColors.Window;
            this.txt_doacao_02.BorderColor = System.Drawing.Color.Transparent;
            this.txt_doacao_02.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_doacao_02.BorderRadius = 0;
            this.txt_doacao_02.BorderSize = 1;
            this.txt_doacao_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doacao_02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_doacao_02.Location = new System.Drawing.Point(297, 36);
            this.txt_doacao_02.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doacao_02.Multiline = false;
            this.txt_doacao_02.Name = "txt_doacao_02";
            this.txt_doacao_02.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_doacao_02.PasswordChar = false;
            this.txt_doacao_02.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_doacao_02.PlaceholderText = "";
            this.txt_doacao_02.Size = new System.Drawing.Size(78, 31);
            this.txt_doacao_02.TabIndex = 184;
            this.txt_doacao_02.Texts = "";
            this.txt_doacao_02.UnderlinedStyle = false;
            this.txt_doacao_02.Enter += new System.EventHandler(this.txt_doacao_02_Enter);
            // 
            // txt_doacao_01
            // 
            this.txt_doacao_01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_doacao_01.BackColor = System.Drawing.SystemColors.Window;
            this.txt_doacao_01.BorderColor = System.Drawing.Color.Transparent;
            this.txt_doacao_01.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_doacao_01.BorderRadius = 0;
            this.txt_doacao_01.BorderSize = 1;
            this.txt_doacao_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doacao_01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_doacao_01.Location = new System.Drawing.Point(211, 36);
            this.txt_doacao_01.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doacao_01.Multiline = false;
            this.txt_doacao_01.Name = "txt_doacao_01";
            this.txt_doacao_01.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_doacao_01.PasswordChar = false;
            this.txt_doacao_01.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_doacao_01.PlaceholderText = "";
            this.txt_doacao_01.Size = new System.Drawing.Size(78, 31);
            this.txt_doacao_01.TabIndex = 181;
            this.txt_doacao_01.Texts = "";
            this.txt_doacao_01.UnderlinedStyle = false;
            this.txt_doacao_01.Enter += new System.EventHandler(this.txt_doacao_01_Enter);
            // 
            // txt_doacao_03
            // 
            this.txt_doacao_03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_doacao_03.BackColor = System.Drawing.SystemColors.Window;
            this.txt_doacao_03.BorderColor = System.Drawing.Color.Transparent;
            this.txt_doacao_03.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_doacao_03.BorderRadius = 0;
            this.txt_doacao_03.BorderSize = 1;
            this.txt_doacao_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doacao_03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_doacao_03.Location = new System.Drawing.Point(383, 36);
            this.txt_doacao_03.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doacao_03.Multiline = false;
            this.txt_doacao_03.Name = "txt_doacao_03";
            this.txt_doacao_03.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_doacao_03.PasswordChar = false;
            this.txt_doacao_03.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_doacao_03.PlaceholderText = "";
            this.txt_doacao_03.Size = new System.Drawing.Size(78, 31);
            this.txt_doacao_03.TabIndex = 186;
            this.txt_doacao_03.Texts = "";
            this.txt_doacao_03.UnderlinedStyle = false;
            this.txt_doacao_03.Enter += new System.EventHandler(this.txt_doacao_03_Enter);
            // 
            // novo_evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_evento_doacoes);
            this.Name = "novo_evento";
            this.Size = new System.Drawing.Size(1200, 1014);
            this.Load += new System.EventHandler(this.novo_evento_Load);
            this.pl_evento_doacoes.ResumeLayout(false);
            this.pl_doacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bt_buscar)).EndInit();
            this.pl_evento_doacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pl_top.ResumeLayout(false);
            this.pl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_evento_doacoes;
        private System.Windows.Forms.Panel pl_espaco_02;
        private System.Windows.Forms.Panel pl_doacao;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Panel pl_espaco_01;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.Label txt_data_evento;
        private System.Windows.Forms.Label lb_data_entrada;
        private System.Windows.Forms.Label lb_semana_01;
        private RJTextBox txt_doacao_01;
        private RJTextBox txt_doacao_04;
        private System.Windows.Forms.Label lb_semana_04;
        private RJTextBox txt_doacao_03;
        private System.Windows.Forms.Label lb_semana_03;
        private RJTextBox txt_doacao_02;
        private System.Windows.Forms.Label lb_semana_02;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pl_evento_doacao;
        private System.Windows.Forms.Label lb_datas;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_datas_esquerda;
        private System.Windows.Forms.Button bt_datas_direita;
        private System.Windows.Forms.PictureBox bt_buscar;
        private RJTextBox txt_buscar;
        private script.RJComboBox txt_mes_evento;
        private RJTextBox txt_ano_evento;
        private System.Windows.Forms.Label txt_sem_dados;
    }
}
