﻿
namespace Hype.painel
{
    partial class alts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.membro = new System.Windows.Forms.Panel();
            this.pl_conta_excluir = new System.Windows.Forms.Panel();
            this.pl_conteudo_02 = new System.Windows.Forms.Panel();
            this.txt_clique_aqui = new System.Windows.Forms.Label();
            this.txt_sem_dados = new System.Windows.Forms.Label();
            this.bt_add_membro = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pl_top = new System.Windows.Forms.Panel();
            this.bt_buscar = new System.Windows.Forms.PictureBox();
            this.bt_alts = new System.Windows.Forms.Button();
            this.bt_ouro = new System.Windows.Forms.Button();
            this.bt_progressao = new System.Windows.Forms.Button();
            this.bt_membros = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_buscar = new Hype.painel.RJTextBox();
            this.membro.SuspendLayout();
            this.pl_conta_excluir.SuspendLayout();
            this.pl_conteudo_02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // membro
            // 
            this.membro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.membro.Controls.Add(this.pl_conta_excluir);
            this.membro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membro.Location = new System.Drawing.Point(0, 0);
            this.membro.Name = "membro";
            this.membro.Size = new System.Drawing.Size(1200, 720);
            this.membro.TabIndex = 1;
            // 
            // pl_conta_excluir
            // 
            this.pl_conta_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_conta_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_conta_excluir.Controls.Add(this.pl_conteudo_02);
            this.pl_conta_excluir.Controls.Add(this.pl_top);
            this.pl_conta_excluir.Location = new System.Drawing.Point(14, 3);
            this.pl_conta_excluir.Name = "pl_conta_excluir";
            this.pl_conta_excluir.Size = new System.Drawing.Size(1172, 714);
            this.pl_conta_excluir.TabIndex = 79;
            // 
            // pl_conteudo_02
            // 
            this.pl_conteudo_02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_conteudo_02.Controls.Add(this.txt_clique_aqui);
            this.pl_conteudo_02.Controls.Add(this.txt_sem_dados);
            this.pl_conteudo_02.Controls.Add(this.bt_add_membro);
            this.pl_conteudo_02.Controls.Add(this.dataGridView1);
            this.pl_conteudo_02.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_conteudo_02.Location = new System.Drawing.Point(0, 43);
            this.pl_conteudo_02.Name = "pl_conteudo_02";
            this.pl_conteudo_02.Size = new System.Drawing.Size(1172, 651);
            this.pl_conteudo_02.TabIndex = 79;
            // 
            // txt_clique_aqui
            // 
            this.txt_clique_aqui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_clique_aqui.AutoSize = true;
            this.txt_clique_aqui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.txt_clique_aqui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_clique_aqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clique_aqui.ForeColor = System.Drawing.Color.White;
            this.txt_clique_aqui.Location = new System.Drawing.Point(485, 118);
            this.txt_clique_aqui.Name = "txt_clique_aqui";
            this.txt_clique_aqui.Size = new System.Drawing.Size(201, 31);
            this.txt_clique_aqui.TabIndex = 69;
            this.txt_clique_aqui.Text = "CLIQUE AQUI";
            this.txt_clique_aqui.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txt_clique_aqui.Click += new System.EventHandler(this.txt_clique_aqui_Click);
            // 
            // txt_sem_dados
            // 
            this.txt_sem_dados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sem_dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.txt_sem_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sem_dados.ForeColor = System.Drawing.Color.White;
            this.txt_sem_dados.Location = new System.Drawing.Point(82, 87);
            this.txt_sem_dados.Name = "txt_sem_dados";
            this.txt_sem_dados.Size = new System.Drawing.Size(1004, 31);
            this.txt_sem_dados.TabIndex = 68;
            this.txt_sem_dados.Text = "VOCÊ NÃO TEM NENHUM CADASTRO";
            this.txt_sem_dados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_add_membro
            // 
            this.bt_add_membro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_add_membro.AutoSize = true;
            this.bt_add_membro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.bt_add_membro.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_membro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.bt_add_membro.Location = new System.Drawing.Point(985, 518);
            this.bt_add_membro.Name = "bt_add_membro";
            this.bt_add_membro.Size = new System.Drawing.Size(101, 107);
            this.bt_add_membro.TabIndex = 67;
            this.bt_add_membro.Text = "+";
            this.bt_add_membro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_add_membro.Click += new System.EventHandler(this.bt_add_membro_Click);
            this.bt_add_membro.MouseEnter += new System.EventHandler(this.bt_add_membro_MouseEnter);
            this.bt_add_membro.MouseLeave += new System.EventHandler(this.bt_add_membro_MouseLeave);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.dataGridView1.Location = new System.Drawing.Point(71, 17);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 616);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_top.Controls.Add(this.bt_buscar);
            this.pl_top.Controls.Add(this.txt_buscar);
            this.pl_top.Controls.Add(this.bt_alts);
            this.pl_top.Controls.Add(this.bt_ouro);
            this.pl_top.Controls.Add(this.bt_progressao);
            this.pl_top.Controls.Add(this.bt_membros);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1172, 43);
            this.pl_top.TabIndex = 76;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.bt_buscar.Image = global::Hype.Properties.Resources.buscar;
            this.bt_buscar.Location = new System.Drawing.Point(1127, 14);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(20, 20);
            this.bt_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_buscar.TabIndex = 68;
            this.bt_buscar.TabStop = false;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_alts
            // 
            this.bt_alts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_alts.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_alts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_alts.FlatAppearance.BorderSize = 0;
            this.bt_alts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alts.ForeColor = System.Drawing.Color.White;
            this.bt_alts.Location = new System.Drawing.Point(685, 4);
            this.bt_alts.Name = "bt_alts";
            this.bt_alts.Size = new System.Drawing.Size(122, 36);
            this.bt_alts.TabIndex = 66;
            this.bt_alts.Text = "Alts";
            this.bt_alts.UseVisualStyleBackColor = false;
            // 
            // bt_ouro
            // 
            this.bt_ouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_ouro.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_ouro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ouro.FlatAppearance.BorderSize = 0;
            this.bt_ouro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ouro.ForeColor = System.Drawing.Color.White;
            this.bt_ouro.Location = new System.Drawing.Point(557, 4);
            this.bt_ouro.Name = "bt_ouro";
            this.bt_ouro.Size = new System.Drawing.Size(122, 36);
            this.bt_ouro.TabIndex = 65;
            this.bt_ouro.Text = "Ouro";
            this.bt_ouro.UseVisualStyleBackColor = false;
            this.bt_ouro.Click += new System.EventHandler(this.bt_ouro_Click);
            // 
            // bt_progressao
            // 
            this.bt_progressao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_progressao.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_progressao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_progressao.FlatAppearance.BorderSize = 0;
            this.bt_progressao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_progressao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_progressao.ForeColor = System.Drawing.Color.White;
            this.bt_progressao.Location = new System.Drawing.Point(429, 4);
            this.bt_progressao.Name = "bt_progressao";
            this.bt_progressao.Size = new System.Drawing.Size(122, 36);
            this.bt_progressao.TabIndex = 64;
            this.bt_progressao.Text = "Progressão";
            this.bt_progressao.UseVisualStyleBackColor = false;
            this.bt_progressao.Click += new System.EventHandler(this.bt_progressao_Click);
            // 
            // bt_membros
            // 
            this.bt_membros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_membros.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_membros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_membros.FlatAppearance.BorderSize = 0;
            this.bt_membros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_membros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_membros.ForeColor = System.Drawing.Color.White;
            this.bt_membros.Location = new System.Drawing.Point(321, 4);
            this.bt_membros.Name = "bt_membros";
            this.bt_membros.Size = new System.Drawing.Size(102, 36);
            this.bt_membros.TabIndex = 63;
            this.bt_membros.Text = "Membros";
            this.bt_membros.UseVisualStyleBackColor = false;
            this.bt_membros.Click += new System.EventHandler(this.bt_membros_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_buscar.BorderColor = System.Drawing.Color.Transparent;
            this.txt_buscar.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_buscar.BorderRadius = 15;
            this.txt_buscar.BorderSize = 2;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_buscar.Location = new System.Drawing.Point(889, 8);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Multiline = false;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_buscar.PasswordChar = false;
            this.txt_buscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_buscar.PlaceholderText = "O que você procura ?";
            this.txt_buscar.Size = new System.Drawing.Size(268, 31);
            this.txt_buscar.TabIndex = 67;
            this.txt_buscar.Texts = "";
            this.txt_buscar.UnderlinedStyle = false;
            this.txt_buscar._TextChanged += new System.EventHandler(this.txt_buscar__TextChanged);
            // 
            // alts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.membro);
            this.Name = "alts";
            this.Size = new System.Drawing.Size(1200, 720);
            this.Load += new System.EventHandler(this.alts_Load);
            this.membro.ResumeLayout(false);
            this.pl_conta_excluir.ResumeLayout(false);
            this.pl_conteudo_02.ResumeLayout(false);
            this.pl_conteudo_02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pl_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bt_buscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel membro;
        private System.Windows.Forms.Panel pl_conta_excluir;
        private System.Windows.Forms.Panel pl_conteudo_02;
        private System.Windows.Forms.Label txt_clique_aqui;
        private System.Windows.Forms.Label txt_sem_dados;
        private System.Windows.Forms.Label bt_add_membro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.PictureBox bt_buscar;
        private RJTextBox txt_buscar;
        private System.Windows.Forms.Button bt_alts;
        private System.Windows.Forms.Button bt_ouro;
        private System.Windows.Forms.Button bt_progressao;
        private System.Windows.Forms.Button bt_membros;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
