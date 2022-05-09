
namespace Mir4.painel
{
    partial class doacoes
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
            this.pl_conteudo = new System.Windows.Forms.Panel();
            this.pl_botoes = new System.Windows.Forms.Panel();
            this.pl_procurar = new System.Windows.Forms.Panel();
            this.pl_tabela = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_procurar = new FontAwesome.Sharp.IconButton();
            this.txt_procurar = new System.Windows.Forms.TextBox();
            this.pl_conteudo.SuspendLayout();
            this.pl_procurar.SuspendLayout();
            this.pl_tabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_conteudo
            // 
            this.pl_conteudo.Controls.Add(this.pl_botoes);
            this.pl_conteudo.Controls.Add(this.pl_procurar);
            this.pl_conteudo.Controls.Add(this.pl_tabela);
            this.pl_conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_conteudo.Location = new System.Drawing.Point(0, 0);
            this.pl_conteudo.Name = "pl_conteudo";
            this.pl_conteudo.Size = new System.Drawing.Size(1200, 720);
            this.pl_conteudo.TabIndex = 0;
            // 
            // pl_botoes
            // 
            this.pl_botoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_botoes.Location = new System.Drawing.Point(27, 17);
            this.pl_botoes.Name = "pl_botoes";
            this.pl_botoes.Size = new System.Drawing.Size(1153, 48);
            this.pl_botoes.TabIndex = 71;
            // 
            // pl_procurar
            // 
            this.pl_procurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_procurar.Controls.Add(this.bt_procurar);
            this.pl_procurar.Controls.Add(this.txt_procurar);
            this.pl_procurar.Location = new System.Drawing.Point(24, 71);
            this.pl_procurar.Name = "pl_procurar";
            this.pl_procurar.Size = new System.Drawing.Size(1156, 61);
            this.pl_procurar.TabIndex = 70;
            // 
            // pl_tabela
            // 
            this.pl_tabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_tabela.Controls.Add(this.dataGridView1);
            this.pl_tabela.Location = new System.Drawing.Point(21, 134);
            this.pl_tabela.Name = "pl_tabela";
            this.pl_tabela.Size = new System.Drawing.Size(1159, 570);
            this.pl_tabela.TabIndex = 69;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1159, 570);
            this.dataGridView1.TabIndex = 1;
            // 
            // bt_procurar
            // 
            this.bt_procurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_procurar.BackColor = System.Drawing.Color.CadetBlue;
            this.bt_procurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_procurar.FlatAppearance.BorderSize = 0;
            this.bt_procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_procurar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_procurar.ForeColor = System.Drawing.Color.White;
            this.bt_procurar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bt_procurar.IconColor = System.Drawing.Color.White;
            this.bt_procurar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_procurar.IconSize = 30;
            this.bt_procurar.Location = new System.Drawing.Point(834, 14);
            this.bt_procurar.Name = "bt_procurar";
            this.bt_procurar.Size = new System.Drawing.Size(116, 33);
            this.bt_procurar.TabIndex = 75;
            this.bt_procurar.Tag = "";
            this.bt_procurar.Text = "Procurar";
            this.bt_procurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_procurar.UseVisualStyleBackColor = false;
            this.bt_procurar.Click += new System.EventHandler(this.bt_procurar_Click);
            // 
            // txt_procurar
            // 
            this.txt_procurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_procurar.Location = new System.Drawing.Point(207, 20);
            this.txt_procurar.Name = "txt_procurar";
            this.txt_procurar.Size = new System.Drawing.Size(621, 23);
            this.txt_procurar.TabIndex = 74;
            // 
            // doacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pl_conteudo);
            this.Name = "doacoes";
            this.Size = new System.Drawing.Size(1200, 720);
            this.pl_conteudo.ResumeLayout(false);
            this.pl_procurar.ResumeLayout(false);
            this.pl_procurar.PerformLayout();
            this.pl_tabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_conteudo;
        private System.Windows.Forms.Panel pl_botoes;
        private System.Windows.Forms.Panel pl_procurar;
        private System.Windows.Forms.Panel pl_tabela;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton bt_procurar;
        private System.Windows.Forms.TextBox txt_procurar;
    }
}
