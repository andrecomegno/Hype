
namespace Mir4
{
    partial class membros_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_top = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.pl_nick = new System.Windows.Forms.Panel();
            this.lb_patente = new System.Windows.Forms.Label();
            this.lb_nick = new System.Windows.Forms.Label();
            this.im_logo_cla = new Mir4.script.RJCircularPictureBox();
            this.pl_dados = new System.Windows.Forms.Panel();
            this.txt_strike = new System.Windows.Forms.TextBox();
            this.txt_doacao = new System.Windows.Forms.TextBox();
            this.txt_veio_cla = new System.Windows.Forms.TextBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.lb_strike = new System.Windows.Forms.Label();
            this.lb_doacao = new System.Windows.Forms.Label();
            this.lb_veio_cla = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.pl_top.SuspendLayout();
            this.pl_nick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_logo_cla)).BeginInit();
            this.pl_dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.pl_top.Controls.Add(this.bt_fechar);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(241, 34);
            this.pl_top.TabIndex = 2;
            this.pl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_top_MouseDown);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_fechar.BackColor = System.Drawing.Color.Gray;
            this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_fechar.FlatAppearance.BorderSize = 0;
            this.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fechar.ForeColor = System.Drawing.Color.White;
            this.bt_fechar.Location = new System.Drawing.Point(210, 3);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(27, 26);
            this.bt_fechar.TabIndex = 44;
            this.bt_fechar.Text = "X";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // pl_nick
            // 
            this.pl_nick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_nick.Controls.Add(this.im_logo_cla);
            this.pl_nick.Controls.Add(this.lb_patente);
            this.pl_nick.Controls.Add(this.lb_nick);
            this.pl_nick.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_nick.Location = new System.Drawing.Point(0, 34);
            this.pl_nick.Name = "pl_nick";
            this.pl_nick.Size = new System.Drawing.Size(241, 140);
            this.pl_nick.TabIndex = 3;
            // 
            // lb_patente
            // 
            this.lb_patente.AutoSize = true;
            this.lb_patente.BackColor = System.Drawing.Color.Transparent;
            this.lb_patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patente.ForeColor = System.Drawing.Color.Gray;
            this.lb_patente.Location = new System.Drawing.Point(95, 111);
            this.lb_patente.Name = "lb_patente";
            this.lb_patente.Size = new System.Drawing.Size(49, 20);
            this.lb_patente.TabIndex = 54;
            this.lb_patente.Text = "Lider";
            // 
            // lb_nick
            // 
            this.lb_nick.AutoSize = true;
            this.lb_nick.BackColor = System.Drawing.Color.Transparent;
            this.lb_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nick.ForeColor = System.Drawing.Color.White;
            this.lb_nick.Location = new System.Drawing.Point(67, 91);
            this.lb_nick.Name = "lb_nick";
            this.lb_nick.Size = new System.Drawing.Size(107, 20);
            this.lb_nick.TabIndex = 53;
            this.lb_nick.Text = "Andy Makler";
            // 
            // im_logo_cla
            // 
            this.im_logo_cla.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.im_logo_cla.BorderColor = System.Drawing.Color.RoyalBlue;
            this.im_logo_cla.BorderColor2 = System.Drawing.Color.HotPink;
            this.im_logo_cla.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.im_logo_cla.BorderSize = 2;
            this.im_logo_cla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.im_logo_cla.GradientAngle = 50F;
            this.im_logo_cla.Image = global::Mir4.Properties.Resources.HYPE_03;
            this.im_logo_cla.Location = new System.Drawing.Point(81, 9);
            this.im_logo_cla.Name = "im_logo_cla";
            this.im_logo_cla.Size = new System.Drawing.Size(80, 80);
            this.im_logo_cla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.im_logo_cla.TabIndex = 55;
            this.im_logo_cla.TabStop = false;
            // 
            // pl_dados
            // 
            this.pl_dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_dados.Controls.Add(this.txt_strike);
            this.pl_dados.Controls.Add(this.txt_doacao);
            this.pl_dados.Controls.Add(this.txt_veio_cla);
            this.pl_dados.Controls.Add(this.txt_data);
            this.pl_dados.Controls.Add(this.lb_strike);
            this.pl_dados.Controls.Add(this.lb_doacao);
            this.pl_dados.Controls.Add(this.lb_veio_cla);
            this.pl_dados.Controls.Add(this.lb_data);
            this.pl_dados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_dados.Location = new System.Drawing.Point(0, 174);
            this.pl_dados.Name = "pl_dados";
            this.pl_dados.Size = new System.Drawing.Size(241, 147);
            this.pl_dados.TabIndex = 4;
            // 
            // txt_strike
            // 
            this.txt_strike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_strike.BackColor = System.Drawing.Color.White;
            this.txt_strike.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_strike.Location = new System.Drawing.Point(197, 127);
            this.txt_strike.Name = "txt_strike";
            this.txt_strike.Size = new System.Drawing.Size(36, 13);
            this.txt_strike.TabIndex = 7;
            // 
            // txt_doacao
            // 
            this.txt_doacao.BackColor = System.Drawing.Color.White;
            this.txt_doacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_doacao.Location = new System.Drawing.Point(129, 85);
            this.txt_doacao.Name = "txt_doacao";
            this.txt_doacao.Size = new System.Drawing.Size(100, 13);
            this.txt_doacao.TabIndex = 6;
            // 
            // txt_veio_cla
            // 
            this.txt_veio_cla.BackColor = System.Drawing.Color.White;
            this.txt_veio_cla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_veio_cla.Location = new System.Drawing.Point(129, 53);
            this.txt_veio_cla.Name = "txt_veio_cla";
            this.txt_veio_cla.Size = new System.Drawing.Size(100, 13);
            this.txt_veio_cla.TabIndex = 5;
            // 
            // txt_data
            // 
            this.txt_data.BackColor = System.Drawing.Color.White;
            this.txt_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_data.Location = new System.Drawing.Point(129, 22);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(100, 13);
            this.txt_data.TabIndex = 4;
            // 
            // lb_strike
            // 
            this.lb_strike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_strike.AutoSize = true;
            this.lb_strike.BackColor = System.Drawing.Color.Transparent;
            this.lb_strike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_strike.ForeColor = System.Drawing.Color.White;
            this.lb_strike.Location = new System.Drawing.Point(151, 127);
            this.lb_strike.Name = "lb_strike";
            this.lb_strike.Size = new System.Drawing.Size(40, 13);
            this.lb_strike.TabIndex = 3;
            this.lb_strike.Text = "Strike";
            // 
            // lb_doacao
            // 
            this.lb_doacao.AutoSize = true;
            this.lb_doacao.BackColor = System.Drawing.Color.Transparent;
            this.lb_doacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doacao.ForeColor = System.Drawing.Color.White;
            this.lb_doacao.Location = new System.Drawing.Point(18, 85);
            this.lb_doacao.Name = "lb_doacao";
            this.lb_doacao.Size = new System.Drawing.Size(90, 13);
            this.lb_doacao.TabIndex = 2;
            this.lb_doacao.Text = "Ultima Doação";
            // 
            // lb_veio_cla
            // 
            this.lb_veio_cla.AutoSize = true;
            this.lb_veio_cla.BackColor = System.Drawing.Color.Transparent;
            this.lb_veio_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_veio_cla.ForeColor = System.Drawing.Color.White;
            this.lb_veio_cla.Location = new System.Drawing.Point(18, 53);
            this.lb_veio_cla.Name = "lb_veio_cla";
            this.lb_veio_cla.Size = new System.Drawing.Size(72, 13);
            this.lb_veio_cla.TabIndex = 1;
            this.lb_veio_cla.Text = "Veio do Clã";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.BackColor = System.Drawing.Color.Transparent;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.ForeColor = System.Drawing.Color.White;
            this.lb_data.Location = new System.Drawing.Point(18, 22);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(98, 13);
            this.lb_data.TabIndex = 0;
            this.lb_data.Text = "Data de Adesão";
            // 
            // membros_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 321);
            this.Controls.Add(this.pl_dados);
            this.Controls.Add(this.pl_nick);
            this.Controls.Add(this.pl_top);
            this.MaximumSize = new System.Drawing.Size(257, 360);
            this.MinimumSize = new System.Drawing.Size(257, 360);
            this.Name = "membros_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "membros_info";
            this.pl_top.ResumeLayout(false);
            this.pl_nick.ResumeLayout(false);
            this.pl_nick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_logo_cla)).EndInit();
            this.pl_dados.ResumeLayout(false);
            this.pl_dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Panel pl_nick;
        private script.RJCircularPictureBox im_logo_cla;
        private System.Windows.Forms.Label lb_patente;
        private System.Windows.Forms.Label lb_nick;
        private System.Windows.Forms.Panel pl_dados;
        private System.Windows.Forms.TextBox txt_strike;
        private System.Windows.Forms.TextBox txt_doacao;
        private System.Windows.Forms.TextBox txt_veio_cla;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label lb_strike;
        private System.Windows.Forms.Label lb_doacao;
        private System.Windows.Forms.Label lb_veio_cla;
        private System.Windows.Forms.Label lb_data;
    }
}