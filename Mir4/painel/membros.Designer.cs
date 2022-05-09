
namespace Mir4.painel
{
    partial class membros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_novo = new FontAwesome.Sharp.IconButton();
            this.bt_deletar = new FontAwesome.Sharp.IconButton();
            this.bt_editar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_procurar = new System.Windows.Forms.Button();
            this.txt_procurar = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 720);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.bt_novo);
            this.panel2.Controls.Add(this.bt_deletar);
            this.panel2.Controls.Add(this.bt_editar);
            this.panel2.Location = new System.Drawing.Point(27, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 48);
            this.panel2.TabIndex = 77;
            // 
            // bt_novo
            // 
            this.bt_novo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_novo.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_novo.FlatAppearance.BorderSize = 0;
            this.bt_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_novo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo.ForeColor = System.Drawing.Color.White;
            this.bt_novo.IconChar = FontAwesome.Sharp.IconChar.User;
            this.bt_novo.IconColor = System.Drawing.Color.White;
            this.bt_novo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_novo.IconSize = 35;
            this.bt_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_novo.Location = new System.Drawing.Point(388, 4);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_novo.Size = new System.Drawing.Size(120, 40);
            this.bt_novo.TabIndex = 63;
            this.bt_novo.Tag = "";
            this.bt_novo.Text = "Novo";
            this.bt_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_novo.UseVisualStyleBackColor = false;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_deletar
            // 
            this.bt_deletar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_deletar.BackColor = System.Drawing.Color.DarkSalmon;
            this.bt_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_deletar.FlatAppearance.BorderSize = 0;
            this.bt_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_deletar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_deletar.ForeColor = System.Drawing.Color.White;
            this.bt_deletar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.bt_deletar.IconColor = System.Drawing.Color.White;
            this.bt_deletar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_deletar.IconSize = 35;
            this.bt_deletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_deletar.Location = new System.Drawing.Point(640, 4);
            this.bt_deletar.Name = "bt_deletar";
            this.bt_deletar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_deletar.Size = new System.Drawing.Size(125, 40);
            this.bt_deletar.TabIndex = 64;
            this.bt_deletar.Tag = "";
            this.bt_deletar.Text = "Deletar";
            this.bt_deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_deletar.UseVisualStyleBackColor = false;
            this.bt_deletar.Click += new System.EventHandler(this.bt_deletar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_editar.BackColor = System.Drawing.Color.Gold;
            this.bt_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editar.FlatAppearance.BorderSize = 0;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.bt_editar.IconColor = System.Drawing.Color.White;
            this.bt_editar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_editar.IconSize = 35;
            this.bt_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_editar.Location = new System.Drawing.Point(514, 4);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_editar.Size = new System.Drawing.Size(120, 40);
            this.bt_editar.TabIndex = 65;
            this.bt_editar.Tag = "";
            this.bt_editar.Text = "Editar";
            this.bt_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.bt_procurar);
            this.panel3.Controls.Add(this.txt_procurar);
            this.panel3.Location = new System.Drawing.Point(24, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1156, 61);
            this.panel3.TabIndex = 76;
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
            this.bt_procurar.Location = new System.Drawing.Point(764, 18);
            this.bt_procurar.Name = "bt_procurar";
            this.bt_procurar.Size = new System.Drawing.Size(117, 28);
            this.bt_procurar.TabIndex = 61;
            this.bt_procurar.Text = "Procurar";
            this.bt_procurar.UseVisualStyleBackColor = false;
            this.bt_procurar.Click += new System.EventHandler(this.bt_procurar_Click);
            // 
            // txt_procurar
            // 
            this.txt_procurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_procurar.Location = new System.Drawing.Point(249, 23);
            this.txt_procurar.Name = "txt_procurar";
            this.txt_procurar.Size = new System.Drawing.Size(509, 23);
            this.txt_procurar.TabIndex = 60;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(21, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1159, 570);
            this.panel4.TabIndex = 75;
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
            // membros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "membros";
            this.Size = new System.Drawing.Size(1200, 720);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton bt_novo;
        private FontAwesome.Sharp.IconButton bt_deletar;
        private FontAwesome.Sharp.IconButton bt_editar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_procurar;
        private System.Windows.Forms.TextBox txt_procurar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
