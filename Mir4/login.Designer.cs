
namespace Mir4
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
            this.pl_login = new System.Windows.Forms.Panel();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.txt_login = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_versao = new System.Windows.Forms.Label();
            this.pl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_login
            // 
            this.pl_login.BackColor = System.Drawing.SystemColors.Control;
            this.pl_login.Controls.Add(this.bt_entrar);
            this.pl_login.Controls.Add(this.txt_login);
            this.pl_login.Controls.Add(this.textBox1);
            this.pl_login.Controls.Add(this.txt_senha);
            this.pl_login.Location = new System.Drawing.Point(12, 12);
            this.pl_login.Name = "pl_login";
            this.pl_login.Size = new System.Drawing.Size(322, 329);
            this.pl_login.TabIndex = 0;
            // 
            // bt_entrar
            // 
            this.bt_entrar.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_entrar.FlatAppearance.BorderSize = 0;
            this.bt_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bt_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bt_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_entrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_entrar.ForeColor = System.Drawing.Color.White;
            this.bt_entrar.Location = new System.Drawing.Point(70, 213);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(184, 58);
            this.bt_entrar.TabIndex = 41;
            this.bt_entrar.Text = "ENTRAR";
            this.bt_entrar.UseVisualStyleBackColor = false;
            this.bt_entrar.Click += new System.EventHandler(this.bt_entrar_Click_1);
            // 
            // txt_login
            // 
            this.txt_login.AutoSize = true;
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(115, 50);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(99, 31);
            this.txt_login.TabIndex = 4;
            this.txt_login.Text = "LOGIN";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 26);
            this.textBox1.TabIndex = 3;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(70, 123);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(184, 26);
            this.txt_senha.TabIndex = 1;
            // 
            // txt_versao
            // 
            this.txt_versao.AutoSize = true;
            this.txt_versao.Location = new System.Drawing.Point(278, 370);
            this.txt_versao.Name = "txt_versao";
            this.txt_versao.Size = new System.Drawing.Size(56, 13);
            this.txt_versao.TabIndex = 5;
            this.txt_versao.Text = "V.  0.0.1 a";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(343, 389);
            this.Controls.Add(this.txt_versao);
            this.Controls.Add(this.pl_login);
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mir4";
            this.pl_login.ResumeLayout(false);
            this.pl_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label txt_login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_versao;
        private System.Windows.Forms.Button bt_entrar;
    }
}

