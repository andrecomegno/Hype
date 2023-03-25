
namespace Hype.Painel.Home
{
    partial class home
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
            this.pl_home = new System.Windows.Forms.Panel();
            this.pl_novo_cla = new System.Windows.Forms.Panel();
            this.pl_nome_clas = new System.Windows.Forms.Panel();
            this.bt_novo_cla = new FontAwesome.Sharp.IconButton();
            this.pl_espaco_01 = new System.Windows.Forms.Panel();
            this.pl_top = new System.Windows.Forms.Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.bt_cla_01 = new System.Windows.Forms.Panel();
            this.txt_cla_01 = new System.Windows.Forms.Label();
            this.bt_cla_02 = new System.Windows.Forms.Panel();
            this.txt_cla_02 = new System.Windows.Forms.Label();
            this.pl_home.SuspendLayout();
            this.pl_novo_cla.SuspendLayout();
            this.pl_nome_clas.SuspendLayout();
            this.pl_top.SuspendLayout();
            this.bt_cla_01.SuspendLayout();
            this.bt_cla_02.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_home
            // 
            this.pl_home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_home.Controls.Add(this.pl_novo_cla);
            this.pl_home.Controls.Add(this.pl_espaco_01);
            this.pl_home.Controls.Add(this.pl_top);
            this.pl_home.Location = new System.Drawing.Point(16, 3);
            this.pl_home.Name = "pl_home";
            this.pl_home.Size = new System.Drawing.Size(1172, 931);
            this.pl_home.TabIndex = 81;
            // 
            // pl_novo_cla
            // 
            this.pl_novo_cla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_novo_cla.Controls.Add(this.pl_nome_clas);
            this.pl_novo_cla.Controls.Add(this.bt_novo_cla);
            this.pl_novo_cla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_novo_cla.Location = new System.Drawing.Point(0, 83);
            this.pl_novo_cla.Name = "pl_novo_cla";
            this.pl_novo_cla.Size = new System.Drawing.Size(1172, 326);
            this.pl_novo_cla.TabIndex = 80;
            // 
            // pl_nome_clas
            // 
            this.pl_nome_clas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_nome_clas.Controls.Add(this.bt_cla_02);
            this.pl_nome_clas.Controls.Add(this.bt_cla_01);
            this.pl_nome_clas.Location = new System.Drawing.Point(278, 6);
            this.pl_nome_clas.Name = "pl_nome_clas";
            this.pl_nome_clas.Size = new System.Drawing.Size(878, 295);
            this.pl_nome_clas.TabIndex = 81;
            // 
            // bt_novo_cla
            // 
            this.bt_novo_cla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_novo_cla.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_novo_cla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_novo_cla.FlatAppearance.BorderSize = 0;
            this.bt_novo_cla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_novo_cla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo_cla.ForeColor = System.Drawing.Color.White;
            this.bt_novo_cla.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.bt_novo_cla.IconColor = System.Drawing.Color.White;
            this.bt_novo_cla.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_novo_cla.IconSize = 35;
            this.bt_novo_cla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_novo_cla.Location = new System.Drawing.Point(42, 27);
            this.bt_novo_cla.Name = "bt_novo_cla";
            this.bt_novo_cla.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_novo_cla.Size = new System.Drawing.Size(210, 46);
            this.bt_novo_cla.TabIndex = 98;
            this.bt_novo_cla.Tag = "";
            this.bt_novo_cla.Text = "Novo Clã";
            this.bt_novo_cla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_novo_cla.UseVisualStyleBackColor = false;
            this.bt_novo_cla.Click += new System.EventHandler(this.bt_novo_cla_Click);
            // 
            // pl_espaco_01
            // 
            this.pl_espaco_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_espaco_01.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_espaco_01.Location = new System.Drawing.Point(0, 73);
            this.pl_espaco_01.Name = "pl_espaco_01";
            this.pl_espaco_01.Size = new System.Drawing.Size(1172, 10);
            this.pl_espaco_01.TabIndex = 79;
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_top.Controls.Add(this.lb_titulo);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1172, 73);
            this.pl_top.TabIndex = 78;
            // 
            // lb_titulo
            // 
            this.lb_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(3, 6);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(1162, 31);
            this.lb_titulo.TabIndex = 96;
            this.lb_titulo.Text = "HOME";
            this.lb_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_cla_01
            // 
            this.bt_cla_01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cla_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.bt_cla_01.Controls.Add(this.txt_cla_01);
            this.bt_cla_01.Enabled = false;
            this.bt_cla_01.Location = new System.Drawing.Point(21, 21);
            this.bt_cla_01.Name = "bt_cla_01";
            this.bt_cla_01.Size = new System.Drawing.Size(210, 46);
            this.bt_cla_01.TabIndex = 119;
            // 
            // txt_cla_01
            // 
            this.txt_cla_01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cla_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cla_01.ForeColor = System.Drawing.Color.White;
            this.txt_cla_01.Location = new System.Drawing.Point(1, 8);
            this.txt_cla_01.Name = "txt_cla_01";
            this.txt_cla_01.Size = new System.Drawing.Size(204, 30);
            this.txt_cla_01.TabIndex = 97;
            this.txt_cla_01.Text = "Cla_01";
            this.txt_cla_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_cla_02
            // 
            this.bt_cla_02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cla_02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.bt_cla_02.Controls.Add(this.txt_cla_02);
            this.bt_cla_02.Enabled = false;
            this.bt_cla_02.Location = new System.Drawing.Point(237, 21);
            this.bt_cla_02.Name = "bt_cla_02";
            this.bt_cla_02.Size = new System.Drawing.Size(210, 46);
            this.bt_cla_02.TabIndex = 120;
            // 
            // txt_cla_02
            // 
            this.txt_cla_02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cla_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cla_02.ForeColor = System.Drawing.Color.White;
            this.txt_cla_02.Location = new System.Drawing.Point(1, 8);
            this.txt_cla_02.Name = "txt_cla_02";
            this.txt_cla_02.Size = new System.Drawing.Size(204, 30);
            this.txt_cla_02.TabIndex = 97;
            this.txt_cla_02.Text = "Cla_02";
            this.txt_cla_02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_home);
            this.Name = "home";
            this.Size = new System.Drawing.Size(1200, 1014);
            this.pl_home.ResumeLayout(false);
            this.pl_novo_cla.ResumeLayout(false);
            this.pl_nome_clas.ResumeLayout(false);
            this.pl_top.ResumeLayout(false);
            this.bt_cla_01.ResumeLayout(false);
            this.bt_cla_02.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_home;
        private System.Windows.Forms.Panel pl_novo_cla;
        private System.Windows.Forms.Panel pl_espaco_01;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_titulo;
        private FontAwesome.Sharp.IconButton bt_novo_cla;
        private System.Windows.Forms.Panel pl_nome_clas;
        private System.Windows.Forms.Panel bt_cla_01;
        private System.Windows.Forms.Label txt_cla_01;
        private System.Windows.Forms.Panel bt_cla_02;
        private System.Windows.Forms.Label txt_cla_02;
    }
}
