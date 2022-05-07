
namespace Mir4.painel
{
    partial class configuracao
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
            this.pl_central = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pl_conta = new System.Windows.Forms.Panel();
            this.foto_perfil = new Mir4.script.RJCircularPictureBox();
            this.lb_patente = new System.Windows.Forms.Label();
            this.lb_nick = new System.Windows.Forms.Label();
            this.pl_nome_cla = new System.Windows.Forms.Panel();
            this.txt_conf_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lb_conf_senha = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_patente_cla = new System.Windows.Forms.ComboBox();
            this.txt_nome_cla = new System.Windows.Forms.TextBox();
            this.lb_patente_cla = new System.Windows.Forms.Label();
            this.lb_nome_cla = new System.Windows.Forms.Label();
            this.pl_central.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pl_conta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).BeginInit();
            this.pl_nome_cla.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_central
            // 
            this.pl_central.Controls.Add(this.panel1);
            this.pl_central.Controls.Add(this.panel2);
            this.pl_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_central.Location = new System.Drawing.Point(0, 0);
            this.pl_central.Name = "pl_central";
            this.pl_central.Size = new System.Drawing.Size(1200, 720);
            this.pl_central.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONFIGURAÇÃO";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pl_conta);
            this.panel2.Controls.Add(this.pl_nome_cla);
            this.panel2.Location = new System.Drawing.Point(59, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 240);
            this.panel2.TabIndex = 1;
            // 
            // pl_conta
            // 
            this.pl_conta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_conta.BackColor = System.Drawing.SystemColors.Control;
            this.pl_conta.Controls.Add(this.foto_perfil);
            this.pl_conta.Controls.Add(this.lb_patente);
            this.pl_conta.Controls.Add(this.lb_nick);
            this.pl_conta.Location = new System.Drawing.Point(96, 3);
            this.pl_conta.Name = "pl_conta";
            this.pl_conta.Size = new System.Drawing.Size(365, 174);
            this.pl_conta.TabIndex = 39;
            // 
            // foto_perfil
            // 
            this.foto_perfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.foto_perfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.foto_perfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.foto_perfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.foto_perfil.BorderSize = 2;
            this.foto_perfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foto_perfil.GradientAngle = 50F;
            this.foto_perfil.Image = global::Mir4.Properties.Resources.HYPE_03;
            this.foto_perfil.Location = new System.Drawing.Point(233, 26);
            this.foto_perfil.Name = "foto_perfil";
            this.foto_perfil.Size = new System.Drawing.Size(94, 94);
            this.foto_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto_perfil.TabIndex = 0;
            this.foto_perfil.TabStop = false;
            // 
            // lb_patente
            // 
            this.lb_patente.AutoSize = true;
            this.lb_patente.BackColor = System.Drawing.Color.Transparent;
            this.lb_patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patente.ForeColor = System.Drawing.Color.Gray;
            this.lb_patente.Location = new System.Drawing.Point(255, 146);
            this.lb_patente.Name = "lb_patente";
            this.lb_patente.Size = new System.Drawing.Size(49, 20);
            this.lb_patente.TabIndex = 50;
            this.lb_patente.Text = "Lider";
            // 
            // lb_nick
            // 
            this.lb_nick.AutoSize = true;
            this.lb_nick.BackColor = System.Drawing.Color.Transparent;
            this.lb_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nick.ForeColor = System.Drawing.Color.Black;
            this.lb_nick.Location = new System.Drawing.Point(230, 126);
            this.lb_nick.Name = "lb_nick";
            this.lb_nick.Size = new System.Drawing.Size(107, 20);
            this.lb_nick.TabIndex = 48;
            this.lb_nick.Text = "Andy Makler";
            // 
            // pl_nome_cla
            // 
            this.pl_nome_cla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_nome_cla.Controls.Add(this.txt_conf_senha);
            this.pl_nome_cla.Controls.Add(this.txt_login);
            this.pl_nome_cla.Controls.Add(this.lb_conf_senha);
            this.pl_nome_cla.Controls.Add(this.lb_login);
            this.pl_nome_cla.Controls.Add(this.lb_senha);
            this.pl_nome_cla.Controls.Add(this.txt_senha);
            this.pl_nome_cla.Controls.Add(this.txt_patente_cla);
            this.pl_nome_cla.Controls.Add(this.txt_nome_cla);
            this.pl_nome_cla.Controls.Add(this.lb_patente_cla);
            this.pl_nome_cla.Controls.Add(this.lb_nome_cla);
            this.pl_nome_cla.Location = new System.Drawing.Point(467, 3);
            this.pl_nome_cla.Name = "pl_nome_cla";
            this.pl_nome_cla.Size = new System.Drawing.Size(513, 174);
            this.pl_nome_cla.TabIndex = 38;
            // 
            // txt_conf_senha
            // 
            this.txt_conf_senha.Location = new System.Drawing.Point(141, 134);
            this.txt_conf_senha.Name = "txt_conf_senha";
            this.txt_conf_senha.Size = new System.Drawing.Size(167, 20);
            this.txt_conf_senha.TabIndex = 25;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(141, 82);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(167, 20);
            this.txt_login.TabIndex = 21;
            // 
            // lb_conf_senha
            // 
            this.lb_conf_senha.AutoSize = true;
            this.lb_conf_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_conf_senha.ForeColor = System.Drawing.Color.Black;
            this.lb_conf_senha.Location = new System.Drawing.Point(21, 135);
            this.lb_conf_senha.Name = "lb_conf_senha";
            this.lb_conf_senha.Size = new System.Drawing.Size(114, 17);
            this.lb_conf_senha.TabIndex = 24;
            this.lb_conf_senha.Text = "Confirmar Senha";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.Black;
            this.lb_login.Location = new System.Drawing.Point(92, 85);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(43, 17);
            this.lb_login.TabIndex = 20;
            this.lb_login.Text = "Login";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.ForeColor = System.Drawing.Color.Black;
            this.lb_senha.Location = new System.Drawing.Point(86, 111);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(49, 17);
            this.lb_senha.TabIndex = 22;
            this.lb_senha.Text = "Senha";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(141, 108);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(167, 20);
            this.txt_senha.TabIndex = 23;
            // 
            // txt_patente_cla
            // 
            this.txt_patente_cla.FormattingEnabled = true;
            this.txt_patente_cla.Items.AddRange(new object[] {
            "Ancião",
            "Égide Sombria",
            "Lider"});
            this.txt_patente_cla.Location = new System.Drawing.Point(141, 55);
            this.txt_patente_cla.Name = "txt_patente_cla";
            this.txt_patente_cla.Size = new System.Drawing.Size(167, 21);
            this.txt_patente_cla.TabIndex = 13;
            // 
            // txt_nome_cla
            // 
            this.txt_nome_cla.Location = new System.Drawing.Point(141, 26);
            this.txt_nome_cla.Name = "txt_nome_cla";
            this.txt_nome_cla.Size = new System.Drawing.Size(167, 20);
            this.txt_nome_cla.TabIndex = 1;
            // 
            // lb_patente_cla
            // 
            this.lb_patente_cla.AutoSize = true;
            this.lb_patente_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patente_cla.ForeColor = System.Drawing.Color.Black;
            this.lb_patente_cla.Location = new System.Drawing.Point(78, 55);
            this.lb_patente_cla.Name = "lb_patente_cla";
            this.lb_patente_cla.Size = new System.Drawing.Size(57, 17);
            this.lb_patente_cla.TabIndex = 12;
            this.lb_patente_cla.Text = "Patente";
            // 
            // lb_nome_cla
            // 
            this.lb_nome_cla.AutoSize = true;
            this.lb_nome_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_cla.ForeColor = System.Drawing.Color.Black;
            this.lb_nome_cla.Location = new System.Drawing.Point(46, 29);
            this.lb_nome_cla.Name = "lb_nome_cla";
            this.lb_nome_cla.Size = new System.Drawing.Size(89, 17);
            this.lb_nome_cla.TabIndex = 0;
            this.lb_nome_cla.Text = "Nome do Cla";
            // 
            // configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_central);
            this.Name = "configuracao";
            this.Size = new System.Drawing.Size(1200, 720);
            this.pl_central.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pl_conta.ResumeLayout(false);
            this.pl_conta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).EndInit();
            this.pl_nome_cla.ResumeLayout(false);
            this.pl_nome_cla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_central;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pl_conta;
        private script.RJCircularPictureBox foto_perfil;
        private System.Windows.Forms.Label lb_patente;
        private System.Windows.Forms.Label lb_nick;
        private System.Windows.Forms.Panel pl_nome_cla;
        private System.Windows.Forms.TextBox txt_conf_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lb_conf_senha;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.ComboBox txt_patente_cla;
        private System.Windows.Forms.TextBox txt_nome_cla;
        private System.Windows.Forms.Label lb_patente_cla;
        private System.Windows.Forms.Label lb_nome_cla;
    }
}
