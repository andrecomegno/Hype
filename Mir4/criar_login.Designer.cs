
namespace Mir4
{
    partial class criar_login
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
            this.lb_cadastramento = new System.Windows.Forms.Label();
            this.bt_minimizar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.pl_geral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pl_login = new System.Windows.Forms.Panel();
            this.txt_conf_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lb_conf_senha = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.pl_nome_cla = new System.Windows.Forms.Panel();
            this.txt_patente_cla = new System.Windows.Forms.ComboBox();
            this.txt_nome_cla = new System.Windows.Forms.TextBox();
            this.lb_patente_cla = new System.Windows.Forms.Label();
            this.lb_nome_cla = new System.Windows.Forms.Label();
            this.pl_espaco = new System.Windows.Forms.Panel();
            this.pl_conta = new System.Windows.Forms.Panel();
            this.foto_perfil = new Mir4.script.RJCircularPictureBox();
            this.lb_patente = new System.Windows.Forms.Label();
            this.lb_nick = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.pl_top.SuspendLayout();
            this.pl_geral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pl_login.SuspendLayout();
            this.pl_nome_cla.SuspendLayout();
            this.pl_conta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.pl_top.Controls.Add(this.lb_cadastramento);
            this.pl_top.Controls.Add(this.bt_minimizar);
            this.pl_top.Controls.Add(this.bt_fechar);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(699, 36);
            this.pl_top.TabIndex = 49;
            this.pl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_top_MouseDown);
            // 
            // lb_cadastramento
            // 
            this.lb_cadastramento.AutoSize = true;
            this.lb_cadastramento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastramento.ForeColor = System.Drawing.Color.White;
            this.lb_cadastramento.Location = new System.Drawing.Point(12, 5);
            this.lb_cadastramento.Name = "lb_cadastramento";
            this.lb_cadastramento.Size = new System.Drawing.Size(146, 25);
            this.lb_cadastramento.TabIndex = 14;
            this.lb_cadastramento.Text = "Cadastramento";
            // 
            // bt_minimizar
            // 
            this.bt_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_minimizar.BackColor = System.Drawing.Color.Gray;
            this.bt_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_minimizar.FlatAppearance.BorderSize = 0;
            this.bt_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimizar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minimizar.ForeColor = System.Drawing.Color.White;
            this.bt_minimizar.Location = new System.Drawing.Point(629, 5);
            this.bt_minimizar.Name = "bt_minimizar";
            this.bt_minimizar.Size = new System.Drawing.Size(29, 21);
            this.bt_minimizar.TabIndex = 55;
            this.bt_minimizar.Text = "-";
            this.bt_minimizar.UseVisualStyleBackColor = false;
            this.bt_minimizar.Click += new System.EventHandler(this.bt_minimizar_Click);
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
            this.bt_fechar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fechar.ForeColor = System.Drawing.Color.White;
            this.bt_fechar.Location = new System.Drawing.Point(664, 5);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(29, 21);
            this.bt_fechar.TabIndex = 54;
            this.bt_fechar.Text = "X";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // pl_geral
            // 
            this.pl_geral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_geral.Controls.Add(this.bt_cancelar);
            this.pl_geral.Controls.Add(this.panel2);
            this.pl_geral.Controls.Add(this.bt_cadastrar);
            this.pl_geral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_geral.Location = new System.Drawing.Point(0, 36);
            this.pl_geral.Name = "pl_geral";
            this.pl_geral.Size = new System.Drawing.Size(699, 301);
            this.pl_geral.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.pl_conta);
            this.panel2.Controls.Add(this.pl_espaco);
            this.panel2.Controls.Add(this.pl_login);
            this.panel2.Controls.Add(this.pl_nome_cla);
            this.panel2.Location = new System.Drawing.Point(17, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 238);
            this.panel2.TabIndex = 0;
            // 
            // pl_login
            // 
            this.pl_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_login.Controls.Add(this.txt_conf_senha);
            this.pl_login.Controls.Add(this.txt_login);
            this.pl_login.Controls.Add(this.lb_conf_senha);
            this.pl_login.Controls.Add(this.lb_login);
            this.pl_login.Controls.Add(this.lb_senha);
            this.pl_login.Controls.Add(this.txt_senha);
            this.pl_login.Location = new System.Drawing.Point(222, 89);
            this.pl_login.Name = "pl_login";
            this.pl_login.Size = new System.Drawing.Size(428, 88);
            this.pl_login.TabIndex = 27;
            // 
            // txt_conf_senha
            // 
            this.txt_conf_senha.Location = new System.Drawing.Point(178, 59);
            this.txt_conf_senha.Name = "txt_conf_senha";
            this.txt_conf_senha.Size = new System.Drawing.Size(167, 20);
            this.txt_conf_senha.TabIndex = 19;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(178, 7);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(167, 20);
            this.txt_login.TabIndex = 1;
            // 
            // lb_conf_senha
            // 
            this.lb_conf_senha.AutoSize = true;
            this.lb_conf_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_conf_senha.ForeColor = System.Drawing.Color.White;
            this.lb_conf_senha.Location = new System.Drawing.Point(58, 60);
            this.lb_conf_senha.Name = "lb_conf_senha";
            this.lb_conf_senha.Size = new System.Drawing.Size(114, 17);
            this.lb_conf_senha.TabIndex = 18;
            this.lb_conf_senha.Text = "Confirmar Senha";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.White;
            this.lb_login.Location = new System.Drawing.Point(129, 10);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(43, 17);
            this.lb_login.TabIndex = 0;
            this.lb_login.Text = "Login";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.ForeColor = System.Drawing.Color.White;
            this.lb_senha.Location = new System.Drawing.Point(123, 36);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(49, 17);
            this.lb_senha.TabIndex = 12;
            this.lb_senha.Text = "Senha";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(178, 33);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(167, 20);
            this.txt_senha.TabIndex = 17;
            // 
            // pl_nome_cla
            // 
            this.pl_nome_cla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_nome_cla.Controls.Add(this.txt_patente_cla);
            this.pl_nome_cla.Controls.Add(this.txt_nome_cla);
            this.pl_nome_cla.Controls.Add(this.lb_patente_cla);
            this.pl_nome_cla.Controls.Add(this.lb_nome_cla);
            this.pl_nome_cla.Location = new System.Drawing.Point(222, 3);
            this.pl_nome_cla.Name = "pl_nome_cla";
            this.pl_nome_cla.Size = new System.Drawing.Size(428, 87);
            this.pl_nome_cla.TabIndex = 26;
            // 
            // txt_patente_cla
            // 
            this.txt_patente_cla.FormattingEnabled = true;
            this.txt_patente_cla.Items.AddRange(new object[] {
            "Ancião",
            "Égide Sombria",
            "Lider"});
            this.txt_patente_cla.Location = new System.Drawing.Point(181, 58);
            this.txt_patente_cla.Name = "txt_patente_cla";
            this.txt_patente_cla.Size = new System.Drawing.Size(167, 21);
            this.txt_patente_cla.TabIndex = 13;
            // 
            // txt_nome_cla
            // 
            this.txt_nome_cla.Location = new System.Drawing.Point(181, 29);
            this.txt_nome_cla.Name = "txt_nome_cla";
            this.txt_nome_cla.Size = new System.Drawing.Size(167, 20);
            this.txt_nome_cla.TabIndex = 1;
            // 
            // lb_patente_cla
            // 
            this.lb_patente_cla.AutoSize = true;
            this.lb_patente_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patente_cla.ForeColor = System.Drawing.Color.White;
            this.lb_patente_cla.Location = new System.Drawing.Point(118, 58);
            this.lb_patente_cla.Name = "lb_patente_cla";
            this.lb_patente_cla.Size = new System.Drawing.Size(57, 17);
            this.lb_patente_cla.TabIndex = 12;
            this.lb_patente_cla.Text = "Patente";
            // 
            // lb_nome_cla
            // 
            this.lb_nome_cla.AutoSize = true;
            this.lb_nome_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_cla.ForeColor = System.Drawing.Color.White;
            this.lb_nome_cla.Location = new System.Drawing.Point(86, 32);
            this.lb_nome_cla.Name = "lb_nome_cla";
            this.lb_nome_cla.Size = new System.Drawing.Size(89, 17);
            this.lb_nome_cla.TabIndex = 0;
            this.lb_nome_cla.Text = "Nome do Cla";
            // 
            // pl_espaco
            // 
            this.pl_espaco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_espaco.Location = new System.Drawing.Point(7, 183);
            this.pl_espaco.Name = "pl_espaco";
            this.pl_espaco.Size = new System.Drawing.Size(643, 42);
            this.pl_espaco.TabIndex = 27;
            // 
            // pl_conta
            // 
            this.pl_conta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pl_conta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_conta.Controls.Add(this.foto_perfil);
            this.pl_conta.Controls.Add(this.lb_patente);
            this.pl_conta.Controls.Add(this.lb_nick);
            this.pl_conta.Location = new System.Drawing.Point(7, 3);
            this.pl_conta.Name = "pl_conta";
            this.pl_conta.Size = new System.Drawing.Size(206, 174);
            this.pl_conta.TabIndex = 29;
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
            this.foto_perfil.Location = new System.Drawing.Point(53, 26);
            this.foto_perfil.Name = "foto_perfil";
            this.foto_perfil.Size = new System.Drawing.Size(94, 94);
            this.foto_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto_perfil.TabIndex = 0;
            this.foto_perfil.TabStop = false;
            this.foto_perfil.Click += new System.EventHandler(this.foto_perfil_Click);
            // 
            // lb_patente
            // 
            this.lb_patente.AutoSize = true;
            this.lb_patente.BackColor = System.Drawing.Color.Transparent;
            this.lb_patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patente.ForeColor = System.Drawing.Color.Gray;
            this.lb_patente.Location = new System.Drawing.Point(75, 146);
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
            this.lb_nick.ForeColor = System.Drawing.Color.White;
            this.lb_nick.Location = new System.Drawing.Point(50, 126);
            this.lb_nick.Name = "lb_nick";
            this.lb_nick.Size = new System.Drawing.Size(107, 20);
            this.lb_nick.TabIndex = 48;
            this.lb_nick.Text = "Andy Makler";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancelar.BackColor = System.Drawing.Color.Tomato;
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(559, 247);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(128, 42);
            this.bt_cancelar.TabIndex = 43;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cadastrar.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar.FlatAppearance.BorderSize = 0;
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.ForeColor = System.Drawing.Color.White;
            this.bt_cadastrar.Location = new System.Drawing.Point(417, 247);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(128, 42);
            this.bt_cadastrar.TabIndex = 44;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            // 
            // criar_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 337);
            this.Controls.Add(this.pl_geral);
            this.Controls.Add(this.pl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "criar_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HYPE - Criar Novo Login";
            this.pl_top.ResumeLayout(false);
            this.pl_top.PerformLayout();
            this.pl_geral.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pl_login.ResumeLayout(false);
            this.pl_login.PerformLayout();
            this.pl_nome_cla.ResumeLayout(false);
            this.pl_nome_cla.PerformLayout();
            this.pl_conta.ResumeLayout(false);
            this.pl_conta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Button bt_minimizar;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Label lb_cadastramento;
        private System.Windows.Forms.Panel pl_geral;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pl_login;
        private System.Windows.Forms.TextBox txt_conf_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lb_conf_senha;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Panel pl_nome_cla;
        private System.Windows.Forms.ComboBox txt_patente_cla;
        private System.Windows.Forms.TextBox txt_nome_cla;
        private System.Windows.Forms.Label lb_patente_cla;
        private System.Windows.Forms.Label lb_nome_cla;
        private System.Windows.Forms.Panel pl_espaco;
        private System.Windows.Forms.Panel pl_conta;
        private script.RJCircularPictureBox foto_perfil;
        private System.Windows.Forms.Label lb_patente;
        private System.Windows.Forms.Label lb_nick;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_cadastrar;
    }
}