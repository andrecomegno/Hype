
namespace Hype.painel
{
    partial class progressao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pl_progressao = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_buscar = new Hype.painel.RJTextBox();
            this.bt_alts = new System.Windows.Forms.Button();
            this.bt_ouro = new System.Windows.Forms.Button();
            this.bt_progressao = new System.Windows.Forms.Button();
            this.bt_membros = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_add_progresso = new System.Windows.Forms.Label();
            this.pl_progressao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_progressao
            // 
            this.pl_progressao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_progressao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.pl_progressao.Controls.Add(this.bt_add_progresso);
            this.pl_progressao.Controls.Add(this.dataGridView1);
            this.pl_progressao.Controls.Add(this.pictureBox1);
            this.pl_progressao.Controls.Add(this.txt_buscar);
            this.pl_progressao.Controls.Add(this.bt_alts);
            this.pl_progressao.Controls.Add(this.bt_ouro);
            this.pl_progressao.Controls.Add(this.bt_progressao);
            this.pl_progressao.Controls.Add(this.bt_membros);
            this.pl_progressao.Location = new System.Drawing.Point(14, 3);
            this.pl_progressao.Name = "pl_progressao";
            this.pl_progressao.Size = new System.Drawing.Size(1172, 714);
            this.pl_progressao.TabIndex = 76;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::Hype.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(980, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_buscar.BorderColor = System.Drawing.Color.Transparent;
            this.txt_buscar.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_buscar.BorderRadius = 15;
            this.txt_buscar.BorderSize = 2;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_buscar.Location = new System.Drawing.Point(742, 9);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Multiline = false;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_buscar.PasswordChar = false;
            this.txt_buscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_buscar.PlaceholderText = "O que você procura ?";
            this.txt_buscar.Size = new System.Drawing.Size(268, 31);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.Texts = "";
            this.txt_buscar.UnderlinedStyle = false;
            // 
            // bt_alts
            // 
            this.bt_alts.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_alts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_alts.FlatAppearance.BorderSize = 0;
            this.bt_alts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alts.ForeColor = System.Drawing.Color.White;
            this.bt_alts.Location = new System.Drawing.Point(367, 4);
            this.bt_alts.Name = "bt_alts";
            this.bt_alts.Size = new System.Drawing.Size(122, 36);
            this.bt_alts.TabIndex = 62;
            this.bt_alts.Text = "Alts";
            this.bt_alts.UseVisualStyleBackColor = false;
            this.bt_alts.Click += new System.EventHandler(this.bt_alts_Click);
            // 
            // bt_ouro
            // 
            this.bt_ouro.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_ouro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ouro.FlatAppearance.BorderSize = 0;
            this.bt_ouro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ouro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ouro.ForeColor = System.Drawing.Color.White;
            this.bt_ouro.Location = new System.Drawing.Point(239, 4);
            this.bt_ouro.Name = "bt_ouro";
            this.bt_ouro.Size = new System.Drawing.Size(122, 36);
            this.bt_ouro.TabIndex = 61;
            this.bt_ouro.Text = "Ouro";
            this.bt_ouro.UseVisualStyleBackColor = false;
            this.bt_ouro.Click += new System.EventHandler(this.bt_ouro_Click);
            // 
            // bt_progressao
            // 
            this.bt_progressao.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_progressao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_progressao.FlatAppearance.BorderSize = 0;
            this.bt_progressao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_progressao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_progressao.ForeColor = System.Drawing.Color.White;
            this.bt_progressao.Location = new System.Drawing.Point(111, 4);
            this.bt_progressao.Name = "bt_progressao";
            this.bt_progressao.Size = new System.Drawing.Size(122, 36);
            this.bt_progressao.TabIndex = 60;
            this.bt_progressao.Text = "Progressão";
            this.bt_progressao.UseVisualStyleBackColor = false;
            // 
            // bt_membros
            // 
            this.bt_membros.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_membros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_membros.FlatAppearance.BorderSize = 0;
            this.bt_membros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_membros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_membros.ForeColor = System.Drawing.Color.White;
            this.bt_membros.Location = new System.Drawing.Point(3, 4);
            this.bt_membros.Name = "bt_membros";
            this.bt_membros.Size = new System.Drawing.Size(102, 36);
            this.bt_membros.TabIndex = 59;
            this.bt_membros.Text = "Membros";
            this.bt_membros.UseVisualStyleBackColor = false;
            this.bt_membros.Click += new System.EventHandler(this.bt_membros_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(3, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 670);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // bt_add_progresso
            // 
            this.bt_add_progresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_add_progresso.AutoSize = true;
            this.bt_add_progresso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.bt_add_progresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_progresso.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.bt_add_progresso.Location = new System.Drawing.Point(971, 602);
            this.bt_add_progresso.Name = "bt_add_progresso";
            this.bt_add_progresso.Size = new System.Drawing.Size(101, 107);
            this.bt_add_progresso.TabIndex = 67;
            this.bt_add_progresso.Text = "+";
            this.bt_add_progresso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_add_progresso.Click += new System.EventHandler(this.bt_add_progresso_Click);
            // 
            // progressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.pl_progressao);
            this.Name = "progressao";
            this.Size = new System.Drawing.Size(1200, 720);
            this.Load += new System.EventHandler(this.progressao_Load);
            this.pl_progressao.ResumeLayout(false);
            this.pl_progressao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_progressao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJTextBox txt_buscar;
        private System.Windows.Forms.Button bt_alts;
        private System.Windows.Forms.Button bt_ouro;
        private System.Windows.Forms.Button bt_progressao;
        private System.Windows.Forms.Button bt_membros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label bt_add_progresso;
    }
}
