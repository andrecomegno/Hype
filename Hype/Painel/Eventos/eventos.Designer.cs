
namespace Hype.Painel.Eventos
{
    partial class eventos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pl_eventos = new System.Windows.Forms.Panel();
            this.pl_conteudo = new System.Windows.Forms.Panel();
            this.pl_top = new System.Windows.Forms.Panel();
            this.bt_buscar = new System.Windows.Forms.PictureBox();
            this.bt_alts = new System.Windows.Forms.Button();
            this.bt_eventos = new System.Windows.Forms.Button();
            this.bt_membros = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new Hype.Painel.RJTextBox();
            this.pl_eventos.SuspendLayout();
            this.pl_conteudo.SuspendLayout();
            this.pl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_eventos
            // 
            this.pl_eventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_eventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_eventos.Controls.Add(this.pl_conteudo);
            this.pl_eventos.Controls.Add(this.pl_top);
            this.pl_eventos.Location = new System.Drawing.Point(14, 3);
            this.pl_eventos.Name = "pl_eventos";
            this.pl_eventos.Size = new System.Drawing.Size(1172, 714);
            this.pl_eventos.TabIndex = 80;
            // 
            // pl_conteudo
            // 
            this.pl_conteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_conteudo.Controls.Add(this.dataGridView1);
            this.pl_conteudo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_conteudo.Location = new System.Drawing.Point(0, 43);
            this.pl_conteudo.Name = "pl_conteudo";
            this.pl_conteudo.Size = new System.Drawing.Size(1172, 651);
            this.pl_conteudo.TabIndex = 79;
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_top.Controls.Add(this.bt_buscar);
            this.pl_top.Controls.Add(this.txt_buscar);
            this.pl_top.Controls.Add(this.bt_alts);
            this.pl_top.Controls.Add(this.bt_eventos);
            this.pl_top.Controls.Add(this.bt_membros);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1172, 43);
            this.pl_top.TabIndex = 76;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.bt_buscar.Image = global::Hype.Properties.Resources.buscar;
            this.bt_buscar.Location = new System.Drawing.Point(1067, 12);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(20, 20);
            this.bt_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_buscar.TabIndex = 68;
            this.bt_buscar.TabStop = false;
            // 
            // bt_alts
            // 
            this.bt_alts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_alts.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_alts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_alts.FlatAppearance.BorderSize = 0;
            this.bt_alts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alts.ForeColor = System.Drawing.Color.White;
            this.bt_alts.Location = new System.Drawing.Point(179, 3);
            this.bt_alts.Name = "bt_alts";
            this.bt_alts.Size = new System.Drawing.Size(122, 36);
            this.bt_alts.TabIndex = 66;
            this.bt_alts.Text = "Alts";
            this.bt_alts.UseVisualStyleBackColor = false;
            this.bt_alts.Click += new System.EventHandler(this.bt_alts_Click);
            // 
            // bt_eventos
            // 
            this.bt_eventos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_eventos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_eventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_eventos.FlatAppearance.BorderSize = 0;
            this.bt_eventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_eventos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eventos.ForeColor = System.Drawing.Color.White;
            this.bt_eventos.Location = new System.Drawing.Point(307, 3);
            this.bt_eventos.Name = "bt_eventos";
            this.bt_eventos.Size = new System.Drawing.Size(122, 36);
            this.bt_eventos.TabIndex = 65;
            this.bt_eventos.Text = "Eventos";
            this.bt_eventos.UseVisualStyleBackColor = false;
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
            this.bt_membros.Location = new System.Drawing.Point(71, 3);
            this.bt_membros.Name = "bt_membros";
            this.bt_membros.Size = new System.Drawing.Size(102, 36);
            this.bt_membros.TabIndex = 63;
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
            this.dataGridView1.Location = new System.Drawing.Point(71, 3);
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
            this.dataGridView1.TabIndex = 70;
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
            this.txt_buscar.Location = new System.Drawing.Point(436, 5);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Multiline = false;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_buscar.PasswordChar = false;
            this.txt_buscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_buscar.PlaceholderText = "O que você procura ?";
            this.txt_buscar.Size = new System.Drawing.Size(661, 31);
            this.txt_buscar.TabIndex = 67;
            this.txt_buscar.Texts = "";
            this.txt_buscar.UnderlinedStyle = false;
            // 
            // eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_eventos);
            this.Name = "eventos";
            this.Size = new System.Drawing.Size(1200, 720);
            this.Load += new System.EventHandler(this.eventos_Load);
            this.pl_eventos.ResumeLayout(false);
            this.pl_conteudo.ResumeLayout(false);
            this.pl_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bt_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_eventos;
        private System.Windows.Forms.Panel pl_conteudo;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.PictureBox bt_buscar;
        private RJTextBox txt_buscar;
        private System.Windows.Forms.Button bt_alts;
        private System.Windows.Forms.Button bt_eventos;
        private System.Windows.Forms.Button bt_membros;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
