
namespace Hype.Painel.Cadastro
{
    partial class cadastro_login
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
            this.pl_cadastro_login = new System.Windows.Forms.Panel();
            this.pl_login = new System.Windows.Forms.Panel();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.txt_email_conf = new Hype.Painel.RJTextBox();
            this.txt_email = new Hype.Painel.RJTextBox();
            this.txt_login = new Hype.Painel.RJTextBox();
            this.txt_senha_conf = new Hype.Painel.RJTextBox();
            this.txt_senha = new Hype.Painel.RJTextBox();
            this.pl_espaco_01 = new System.Windows.Forms.Panel();
            this.pl_top = new System.Windows.Forms.Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pl_cadastro_login.SuspendLayout();
            this.pl_login.SuspendLayout();
            this.pl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_cadastro_login
            // 
            this.pl_cadastro_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_cadastro_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_cadastro_login.Controls.Add(this.pl_login);
            this.pl_cadastro_login.Controls.Add(this.pl_espaco_01);
            this.pl_cadastro_login.Controls.Add(this.pl_top);
            this.pl_cadastro_login.Location = new System.Drawing.Point(16, 3);
            this.pl_cadastro_login.Name = "pl_cadastro_login";
            this.pl_cadastro_login.Size = new System.Drawing.Size(1172, 931);
            this.pl_cadastro_login.TabIndex = 80;
            // 
            // pl_login
            // 
            this.pl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_login.Controls.Add(this.bt_cancelar);
            this.pl_login.Controls.Add(this.bt_salvar);
            this.pl_login.Controls.Add(this.txt_email_conf);
            this.pl_login.Controls.Add(this.txt_email);
            this.pl_login.Controls.Add(this.txt_login);
            this.pl_login.Controls.Add(this.txt_senha_conf);
            this.pl_login.Controls.Add(this.txt_senha);
            this.pl_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_login.Location = new System.Drawing.Point(0, 83);
            this.pl_login.Name = "pl_login";
            this.pl_login.Size = new System.Drawing.Size(1172, 385);
            this.pl_login.TabIndex = 80;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(586, 264);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 36);
            this.bt_cancelar.TabIndex = 66;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
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
            this.bt_salvar.Location = new System.Drawing.Point(458, 264);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(122, 36);
            this.bt_salvar.TabIndex = 67;
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
            this.txt_email_conf.Location = new System.Drawing.Point(458, 128);
            this.txt_email_conf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email_conf.Multiline = false;
            this.txt_email_conf.Name = "txt_email_conf";
            this.txt_email_conf.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_email_conf.PasswordChar = false;
            this.txt_email_conf.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_email_conf.PlaceholderText = "Confirmar E-Mail";
            this.txt_email_conf.Size = new System.Drawing.Size(250, 31);
            this.txt_email_conf.TabIndex = 13;
            this.txt_email_conf.Texts = "";
            this.txt_email_conf.UnderlinedStyle = false;
            this.txt_email_conf.Enter += new System.EventHandler(this.txt_email_conf_Enter);
            this.txt_email_conf.Leave += new System.EventHandler(this.txt_email_conf_Leave);
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
            this.txt_email.Location = new System.Drawing.Point(458, 89);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_email.PasswordChar = false;
            this.txt_email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_email.PlaceholderText = "E-Mail";
            this.txt_email.Size = new System.Drawing.Size(250, 31);
            this.txt_email.TabIndex = 12;
            this.txt_email.Texts = "";
            this.txt_email.UnderlinedStyle = false;
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_login
            // 
            this.txt_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_login.BackColor = System.Drawing.SystemColors.Window;
            this.txt_login.BorderColor = System.Drawing.Color.White;
            this.txt_login.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_login.BorderRadius = 0;
            this.txt_login.BorderSize = 2;
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_login.Location = new System.Drawing.Point(458, 50);
            this.txt_login.Margin = new System.Windows.Forms.Padding(4);
            this.txt_login.Multiline = false;
            this.txt_login.Name = "txt_login";
            this.txt_login.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_login.PasswordChar = false;
            this.txt_login.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_login.PlaceholderText = "Login";
            this.txt_login.Size = new System.Drawing.Size(250, 31);
            this.txt_login.TabIndex = 9;
            this.txt_login.Texts = "";
            this.txt_login.UnderlinedStyle = false;
            this.txt_login.Enter += new System.EventHandler(this.txt_login_Enter);
            this.txt_login.Leave += new System.EventHandler(this.txt_login_Leave);
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
            this.txt_senha_conf.Location = new System.Drawing.Point(458, 214);
            this.txt_senha_conf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha_conf.Multiline = false;
            this.txt_senha_conf.Name = "txt_senha_conf";
            this.txt_senha_conf.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_senha_conf.PasswordChar = false;
            this.txt_senha_conf.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_senha_conf.PlaceholderText = "Confirmar Senha";
            this.txt_senha_conf.Size = new System.Drawing.Size(250, 31);
            this.txt_senha_conf.TabIndex = 11;
            this.txt_senha_conf.Texts = "";
            this.txt_senha_conf.UnderlinedStyle = false;
            this.txt_senha_conf.Enter += new System.EventHandler(this.txt_senha_conf_Enter);
            this.txt_senha_conf.Leave += new System.EventHandler(this.txt_senha_conf_Leave);
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
            this.txt_senha.Location = new System.Drawing.Point(458, 175);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha.Multiline = false;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_senha.PasswordChar = false;
            this.txt_senha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_senha.PlaceholderText = "Senha";
            this.txt_senha.Size = new System.Drawing.Size(250, 31);
            this.txt_senha.TabIndex = 10;
            this.txt_senha.Texts = "";
            this.txt_senha.UnderlinedStyle = false;
            this.txt_senha.Enter += new System.EventHandler(this.txt_senha_Enter);
            this.txt_senha.Leave += new System.EventHandler(this.txt_senha_Leave);
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
            this.lb_titulo.Text = "CADASTRO LOGIN";
            this.lb_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cadastro_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_cadastro_login);
            this.Name = "cadastro_login";
            this.Size = new System.Drawing.Size(1200, 1014);
            this.pl_cadastro_login.ResumeLayout(false);
            this.pl_login.ResumeLayout(false);
            this.pl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_cadastro_login;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Panel pl_espaco_01;
        private System.Windows.Forms.Panel pl_login;
        private RJTextBox txt_email_conf;
        private RJTextBox txt_email;
        private RJTextBox txt_login;
        private RJTextBox txt_senha_conf;
        private RJTextBox txt_senha;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_salvar;
    }
}
