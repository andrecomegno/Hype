
namespace Hype.Painel
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
            this.pl_configuracao = new System.Windows.Forms.Panel();
            this.pl_conteudo = new System.Windows.Forms.Panel();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.txt_email_conf = new Hype.Painel.RJTextBox();
            this.txt_email = new Hype.Painel.RJTextBox();
            this.txt_usuario = new Hype.Painel.RJTextBox();
            this.txt_senha_conf = new Hype.Painel.RJTextBox();
            this.txt_senha = new Hype.Painel.RJTextBox();
            this.pl_espaco_01 = new System.Windows.Forms.Panel();
            this.pl_top = new System.Windows.Forms.Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_login_usuario = new System.Windows.Forms.Label();
            this.pl_configuracao.SuspendLayout();
            this.pl_conteudo.SuspendLayout();
            this.pl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_configuracao
            // 
            this.pl_configuracao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_configuracao.Controls.Add(this.pl_conteudo);
            this.pl_configuracao.Controls.Add(this.pl_espaco_01);
            this.pl_configuracao.Controls.Add(this.pl_top);
            this.pl_configuracao.Location = new System.Drawing.Point(28, 3);
            this.pl_configuracao.Name = "pl_configuracao";
            this.pl_configuracao.Size = new System.Drawing.Size(1146, 690);
            this.pl_configuracao.TabIndex = 0;
            // 
            // pl_conteudo
            // 
            this.pl_conteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_conteudo.Controls.Add(this.lb_login_usuario);
            this.pl_conteudo.Controls.Add(this.bt_salvar);
            this.pl_conteudo.Controls.Add(this.txt_email_conf);
            this.pl_conteudo.Controls.Add(this.txt_email);
            this.pl_conteudo.Controls.Add(this.txt_usuario);
            this.pl_conteudo.Controls.Add(this.txt_senha_conf);
            this.pl_conteudo.Controls.Add(this.txt_senha);
            this.pl_conteudo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_conteudo.Location = new System.Drawing.Point(0, 110);
            this.pl_conteudo.Name = "pl_conteudo";
            this.pl_conteudo.Size = new System.Drawing.Size(1146, 422);
            this.pl_conteudo.TabIndex = 5;
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
            this.bt_salvar.Location = new System.Drawing.Point(582, 284);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(122, 36);
            this.bt_salvar.TabIndex = 65;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // txt_email_conf
            // 
            this.txt_email_conf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email_conf.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email_conf.BorderColor = System.Drawing.Color.White;
            this.txt_email_conf.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_email_conf.BorderRadius = 0;
            this.txt_email_conf.BorderSize = 2;
            this.txt_email_conf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_conf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_email_conf.Location = new System.Drawing.Point(454, 168);
            this.txt_email_conf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email_conf.Multiline = false;
            this.txt_email_conf.Name = "txt_email_conf";
            this.txt_email_conf.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_email_conf.PasswordChar = false;
            this.txt_email_conf.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_email_conf.PlaceholderText = "Confirmar E-Mail";
            this.txt_email_conf.Size = new System.Drawing.Size(250, 31);
            this.txt_email_conf.TabIndex = 7;
            this.txt_email_conf.Texts = "";
            this.txt_email_conf.UnderlinedStyle = false;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email.BorderColor = System.Drawing.Color.White;
            this.txt_email.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_email.BorderRadius = 0;
            this.txt_email.BorderSize = 2;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_email.Location = new System.Drawing.Point(454, 129);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_email.PasswordChar = false;
            this.txt_email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_email.PlaceholderText = "E-Mail";
            this.txt_email.Size = new System.Drawing.Size(250, 31);
            this.txt_email.TabIndex = 6;
            this.txt_email.Texts = "";
            this.txt_email.UnderlinedStyle = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_usuario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_usuario.BorderColor = System.Drawing.Color.Transparent;
            this.txt_usuario.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_usuario.BorderRadius = 0;
            this.txt_usuario.BorderSize = 2;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_usuario.Location = new System.Drawing.Point(454, 70);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.Multiline = false;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_usuario.PasswordChar = false;
            this.txt_usuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_usuario.PlaceholderText = "";
            this.txt_usuario.Size = new System.Drawing.Size(250, 31);
            this.txt_usuario.TabIndex = 3;
            this.txt_usuario.Texts = "";
            this.txt_usuario.UnderlinedStyle = false;
            // 
            // txt_senha_conf
            // 
            this.txt_senha_conf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_senha_conf.BackColor = System.Drawing.SystemColors.Window;
            this.txt_senha_conf.BorderColor = System.Drawing.Color.White;
            this.txt_senha_conf.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_senha_conf.BorderRadius = 0;
            this.txt_senha_conf.BorderSize = 2;
            this.txt_senha_conf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha_conf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_senha_conf.Location = new System.Drawing.Point(454, 246);
            this.txt_senha_conf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha_conf.Multiline = false;
            this.txt_senha_conf.Name = "txt_senha_conf";
            this.txt_senha_conf.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_senha_conf.PasswordChar = false;
            this.txt_senha_conf.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_senha_conf.PlaceholderText = "Confirmar Senha";
            this.txt_senha_conf.Size = new System.Drawing.Size(250, 31);
            this.txt_senha_conf.TabIndex = 5;
            this.txt_senha_conf.Texts = "";
            this.txt_senha_conf.UnderlinedStyle = false;
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_senha.BackColor = System.Drawing.SystemColors.Window;
            this.txt_senha.BorderColor = System.Drawing.Color.White;
            this.txt_senha.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_senha.BorderRadius = 0;
            this.txt_senha.BorderSize = 2;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_senha.Location = new System.Drawing.Point(454, 207);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha.Multiline = false;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_senha.PasswordChar = false;
            this.txt_senha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_senha.PlaceholderText = "Senha";
            this.txt_senha.Size = new System.Drawing.Size(250, 31);
            this.txt_senha.TabIndex = 4;
            this.txt_senha.Texts = "";
            this.txt_senha.UnderlinedStyle = false;
            // 
            // pl_espaco_01
            // 
            this.pl_espaco_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_espaco_01.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_espaco_01.Location = new System.Drawing.Point(0, 100);
            this.pl_espaco_01.Name = "pl_espaco_01";
            this.pl_espaco_01.Size = new System.Drawing.Size(1146, 10);
            this.pl_espaco_01.TabIndex = 6;
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_top.Controls.Add(this.lb_titulo);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1146, 100);
            this.pl_top.TabIndex = 4;
            // 
            // lb_titulo
            // 
            this.lb_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(313, 16);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(532, 69);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "CONFIGURAÇÃO";
            // 
            // lb_login_usuario
            // 
            this.lb_login_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_login_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login_usuario.ForeColor = System.Drawing.Color.White;
            this.lb_login_usuario.Location = new System.Drawing.Point(451, 49);
            this.lb_login_usuario.Name = "lb_login_usuario";
            this.lb_login_usuario.Size = new System.Drawing.Size(253, 17);
            this.lb_login_usuario.TabIndex = 66;
            this.lb_login_usuario.Text = "Login / Usuario";
            this.lb_login_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_configuracao);
            this.Name = "configuracao";
            this.Size = new System.Drawing.Size(1200, 720);
            this.Load += new System.EventHandler(this.configuracao_Load);
            this.pl_configuracao.ResumeLayout(false);
            this.pl_conteudo.ResumeLayout(false);
            this.pl_top.ResumeLayout(false);
            this.pl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_configuracao;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Panel pl_conteudo;
        private System.Windows.Forms.Button bt_salvar;
        private RJTextBox txt_email_conf;
        private RJTextBox txt_email;
        private RJTextBox txt_usuario;
        private RJTextBox txt_senha_conf;
        private RJTextBox txt_senha;
        private System.Windows.Forms.Panel pl_espaco_01;
        private System.Windows.Forms.Label lb_login_usuario;
    }
}
