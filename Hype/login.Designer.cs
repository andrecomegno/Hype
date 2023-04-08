
namespace Hype
{
    partial class login
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txt_versao = new System.Windows.Forms.Label();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.lb_login = new System.Windows.Forms.Label();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.lb_novo_cad = new System.Windows.Forms.Label();
            this.pl_login = new System.Windows.Forms.Panel();
            this.txt_senha = new Hype.Painel.RJTextBox();
            this.txt_login = new Hype.Painel.RJTextBox();
            this.pl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_versao
            // 
            this.txt_versao.AutoSize = true;
            this.txt_versao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_versao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_versao.Location = new System.Drawing.Point(267, 367);
            this.txt_versao.Name = "txt_versao";
            this.txt_versao.Size = new System.Drawing.Size(56, 13);
            this.txt_versao.TabIndex = 0;
            this.txt_versao.Text = "V.  3.0.1";
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
            this.bt_fechar.Location = new System.Drawing.Point(312, 4);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(27, 26);
            this.bt_fechar.TabIndex = 0;
            this.bt_fechar.Text = "X";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.White;
            this.lb_login.Location = new System.Drawing.Point(116, 13);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(99, 31);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "LOGIN";
            // 
            // bt_entrar
            // 
            this.bt_entrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_entrar.FlatAppearance.BorderSize = 0;
            this.bt_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_entrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_entrar.ForeColor = System.Drawing.Color.White;
            this.bt_entrar.Location = new System.Drawing.Point(71, 176);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(184, 58);
            this.bt_entrar.TabIndex = 4;
            this.bt_entrar.Text = "ENTRAR";
            this.bt_entrar.UseVisualStyleBackColor = false;
            this.bt_entrar.Click += new System.EventHandler(this.bt_entrar_Click);
            // 
            // lb_novo_cad
            // 
            this.lb_novo_cad.AutoSize = true;
            this.lb_novo_cad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_novo_cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_novo_cad.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_novo_cad.Location = new System.Drawing.Point(106, 247);
            this.lb_novo_cad.Name = "lb_novo_cad";
            this.lb_novo_cad.Size = new System.Drawing.Size(121, 13);
            this.lb_novo_cad.TabIndex = 5;
            this.lb_novo_cad.Text = "Criar Novo Cadastro";
            this.lb_novo_cad.Click += new System.EventHandler(this.lb_novo_cad_Click);
            this.lb_novo_cad.MouseEnter += new System.EventHandler(this.lb_novo_cad_MouseEnter);
            this.lb_novo_cad.MouseLeave += new System.EventHandler(this.lb_novo_cad_MouseLeave);
            // 
            // pl_login
            // 
            this.pl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_login.Controls.Add(this.txt_senha);
            this.pl_login.Controls.Add(this.txt_login);
            this.pl_login.Controls.Add(this.lb_novo_cad);
            this.pl_login.Controls.Add(this.bt_entrar);
            this.pl_login.Controls.Add(this.lb_login);
            this.pl_login.Location = new System.Drawing.Point(1, 54);
            this.pl_login.Name = "pl_login";
            this.pl_login.Size = new System.Drawing.Size(340, 287);
            this.pl_login.TabIndex = 1;
            this.pl_login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_top_MouseDown);
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_senha.BackColor = System.Drawing.SystemColors.Window;
            this.txt_senha.BorderColor = System.Drawing.Color.Transparent;
            this.txt_senha.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txt_senha.BorderRadius = 0;
            this.txt_senha.BorderSize = 2;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_senha.Location = new System.Drawing.Point(71, 128);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha.Multiline = false;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_senha.PasswordChar = true;
            this.txt_senha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_senha.PlaceholderText = "Senha";
            this.txt_senha.Size = new System.Drawing.Size(184, 31);
            this.txt_senha.TabIndex = 3;
            this.txt_senha.Texts = "";
            this.txt_senha.UnderlinedStyle = false;
            this.txt_senha.Enter += new System.EventHandler(this.txt_senha_Enter);
            this.txt_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_senha_KeyPress);
            this.txt_senha.Leave += new System.EventHandler(this.txt_senha_Leave);
            // 
            // txt_login
            // 
            this.txt_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_login.BackColor = System.Drawing.SystemColors.Window;
            this.txt_login.BorderColor = System.Drawing.Color.Transparent;
            this.txt_login.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txt_login.BorderRadius = 0;
            this.txt_login.BorderSize = 2;
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_login.Location = new System.Drawing.Point(71, 76);
            this.txt_login.Margin = new System.Windows.Forms.Padding(4);
            this.txt_login.Multiline = false;
            this.txt_login.Name = "txt_login";
            this.txt_login.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_login.PasswordChar = false;
            this.txt_login.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_login.PlaceholderText = "Nick";
            this.txt_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_login.Size = new System.Drawing.Size(184, 31);
            this.txt_login.TabIndex = 2;
            this.txt_login.Texts = "";
            this.txt_login.UnderlinedStyle = false;
            this.txt_login.Enter += new System.EventHandler(this.txt_login_Enter);
            this.txt_login.Leave += new System.EventHandler(this.txt_login_Leave);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(343, 389);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.txt_versao);
            this.Controls.Add(this.pl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_top_MouseDown);
            this.pl_login.ResumeLayout(false);
            this.pl_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_versao;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.Label lb_novo_cad;
        private System.Windows.Forms.Panel pl_login;
        private Painel.RJTextBox txt_login;
        private Painel.RJTextBox txt_senha;
    }
}

