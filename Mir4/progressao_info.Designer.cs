
namespace Mir4
{
    partial class progressao_info
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
            this.pl_dados = new System.Windows.Forms.Panel();
            this.pl_todos = new System.Windows.Forms.Panel();
            this.pl_top = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.txt_classe = new Mir4.painel.RJTextBox();
            this.lb_classe = new System.Windows.Forms.Label();
            this.txt_patente = new Mir4.painel.RJTextBox();
            this.txt_level = new Mir4.painel.RJTextBox();
            this.lb_poder = new System.Windows.Forms.Label();
            this.lb_nick = new System.Windows.Forms.Label();
            this.lb_patente = new System.Windows.Forms.Label();
            this.txt_nick = new Mir4.painel.RJTextBox();
            this.txt_poder = new Mir4.painel.RJTextBox();
            this.lb_level = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new Mir4.painel.RJTextBox();
            this.pl_dados.SuspendLayout();
            this.pl_todos.SuspendLayout();
            this.pl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_dados
            // 
            this.pl_dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_dados.Controls.Add(this.pl_top);
            this.pl_dados.Controls.Add(this.pl_todos);
            this.pl_dados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_dados.Location = new System.Drawing.Point(0, 0);
            this.pl_dados.Name = "pl_dados";
            this.pl_dados.Size = new System.Drawing.Size(748, 588);
            this.pl_dados.TabIndex = 5;
            // 
            // pl_todos
            // 
            this.pl_todos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_todos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_todos.Controls.Add(this.rjTextBox1);
            this.pl_todos.Controls.Add(this.label1);
            this.pl_todos.Controls.Add(this.bt_cancelar);
            this.pl_todos.Controls.Add(this.bt_excluir);
            this.pl_todos.Controls.Add(this.txt_classe);
            this.pl_todos.Controls.Add(this.lb_classe);
            this.pl_todos.Controls.Add(this.txt_patente);
            this.pl_todos.Controls.Add(this.txt_level);
            this.pl_todos.Controls.Add(this.lb_poder);
            this.pl_todos.Controls.Add(this.lb_nick);
            this.pl_todos.Controls.Add(this.lb_patente);
            this.pl_todos.Controls.Add(this.txt_nick);
            this.pl_todos.Controls.Add(this.txt_poder);
            this.pl_todos.Controls.Add(this.lb_level);
            this.pl_todos.Location = new System.Drawing.Point(12, 17);
            this.pl_todos.Name = "pl_todos";
            this.pl_todos.Size = new System.Drawing.Size(725, 534);
            this.pl_todos.TabIndex = 22;
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.Black;
            this.pl_top.Controls.Add(this.bt_fechar);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(748, 34);
            this.pl_top.TabIndex = 23;
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
            this.bt_fechar.Location = new System.Drawing.Point(717, 3);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(27, 26);
            this.bt_fechar.TabIndex = 44;
            this.bt_fechar.Text = "X";
            this.bt_fechar.UseVisualStyleBackColor = false;
            // 
            // txt_classe
            // 
            this.txt_classe.BackColor = System.Drawing.Color.Lavender;
            this.txt_classe.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txt_classe.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_classe.BorderRadius = 0;
            this.txt_classe.BorderSize = 1;
            this.txt_classe.Enabled = false;
            this.txt_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_classe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_classe.Location = new System.Drawing.Point(425, 42);
            this.txt_classe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_classe.Multiline = false;
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_classe.PasswordChar = false;
            this.txt_classe.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_classe.PlaceholderText = "";
            this.txt_classe.Size = new System.Drawing.Size(119, 31);
            this.txt_classe.TabIndex = 85;
            this.txt_classe.Texts = "";
            this.txt_classe.UnderlinedStyle = false;
            // 
            // lb_classe
            // 
            this.lb_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_classe.ForeColor = System.Drawing.Color.White;
            this.lb_classe.Location = new System.Drawing.Point(427, 21);
            this.lb_classe.Name = "lb_classe";
            this.lb_classe.Size = new System.Drawing.Size(117, 17);
            this.lb_classe.TabIndex = 84;
            this.lb_classe.Text = "Classe";
            this.lb_classe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_patente
            // 
            this.txt_patente.BackColor = System.Drawing.Color.Lavender;
            this.txt_patente.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txt_patente.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_patente.BorderRadius = 0;
            this.txt_patente.BorderSize = 1;
            this.txt_patente.Enabled = false;
            this.txt_patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_patente.Location = new System.Drawing.Point(552, 42);
            this.txt_patente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_patente.Multiline = false;
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_patente.PasswordChar = false;
            this.txt_patente.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_patente.PlaceholderText = "";
            this.txt_patente.Size = new System.Drawing.Size(119, 31);
            this.txt_patente.TabIndex = 83;
            this.txt_patente.Texts = "";
            this.txt_patente.UnderlinedStyle = false;
            // 
            // txt_level
            // 
            this.txt_level.BackColor = System.Drawing.Color.Lavender;
            this.txt_level.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txt_level.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_level.BorderRadius = 0;
            this.txt_level.BorderSize = 1;
            this.txt_level.Enabled = false;
            this.txt_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_level.Location = new System.Drawing.Point(222, 42);
            this.txt_level.Margin = new System.Windows.Forms.Padding(4);
            this.txt_level.Multiline = false;
            this.txt_level.Name = "txt_level";
            this.txt_level.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_level.PasswordChar = false;
            this.txt_level.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_level.PlaceholderText = "";
            this.txt_level.Size = new System.Drawing.Size(68, 31);
            this.txt_level.TabIndex = 82;
            this.txt_level.Texts = "";
            this.txt_level.UnderlinedStyle = false;
            // 
            // lb_poder
            // 
            this.lb_poder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_poder.ForeColor = System.Drawing.Color.White;
            this.lb_poder.Location = new System.Drawing.Point(297, 21);
            this.lb_poder.Name = "lb_poder";
            this.lb_poder.Size = new System.Drawing.Size(120, 17);
            this.lb_poder.TabIndex = 81;
            this.lb_poder.Text = "Poder";
            this.lb_poder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_nick
            // 
            this.lb_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nick.ForeColor = System.Drawing.Color.White;
            this.lb_nick.Location = new System.Drawing.Point(53, 21);
            this.lb_nick.Name = "lb_nick";
            this.lb_nick.Size = new System.Drawing.Size(162, 17);
            this.lb_nick.TabIndex = 80;
            this.lb_nick.Text = "Nick";
            this.lb_nick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_patente
            // 
            this.lb_patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patente.ForeColor = System.Drawing.Color.White;
            this.lb_patente.Location = new System.Drawing.Point(554, 21);
            this.lb_patente.Name = "lb_patente";
            this.lb_patente.Size = new System.Drawing.Size(117, 17);
            this.lb_patente.TabIndex = 79;
            this.lb_patente.Text = "Patente";
            this.lb_patente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nick
            // 
            this.txt_nick.BackColor = System.Drawing.Color.Lavender;
            this.txt_nick.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txt_nick.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_nick.BorderRadius = 0;
            this.txt_nick.BorderSize = 1;
            this.txt_nick.Enabled = false;
            this.txt_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nick.Location = new System.Drawing.Point(53, 42);
            this.txt_nick.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nick.Multiline = false;
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nick.PasswordChar = false;
            this.txt_nick.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_nick.PlaceholderText = "";
            this.txt_nick.Size = new System.Drawing.Size(162, 31);
            this.txt_nick.TabIndex = 76;
            this.txt_nick.Texts = "";
            this.txt_nick.UnderlinedStyle = false;
            // 
            // txt_poder
            // 
            this.txt_poder.BackColor = System.Drawing.Color.Lavender;
            this.txt_poder.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txt_poder.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_poder.BorderRadius = 0;
            this.txt_poder.BorderSize = 1;
            this.txt_poder.Enabled = false;
            this.txt_poder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_poder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_poder.Location = new System.Drawing.Point(298, 42);
            this.txt_poder.Margin = new System.Windows.Forms.Padding(4);
            this.txt_poder.Multiline = false;
            this.txt_poder.Name = "txt_poder";
            this.txt_poder.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_poder.PasswordChar = false;
            this.txt_poder.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_poder.PlaceholderText = "";
            this.txt_poder.Size = new System.Drawing.Size(119, 31);
            this.txt_poder.TabIndex = 77;
            this.txt_poder.Texts = "";
            this.txt_poder.UnderlinedStyle = false;
            // 
            // lb_level
            // 
            this.lb_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_level.ForeColor = System.Drawing.Color.White;
            this.lb_level.Location = new System.Drawing.Point(222, 21);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(68, 17);
            this.lb_level.TabIndex = 78;
            this.lb_level.Text = "Level";
            this.lb_level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(549, 495);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 36);
            this.bt_cancelar.TabIndex = 86;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            // 
            // bt_excluir
            // 
            this.bt_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_excluir.BackColor = System.Drawing.Color.Crimson;
            this.bt_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_excluir.FlatAppearance.BorderSize = 0;
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.ForeColor = System.Drawing.Color.White;
            this.bt_excluir.Location = new System.Drawing.Point(416, 495);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(122, 36);
            this.bt_excluir.TabIndex = 87;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.Lavender;
            this.rjTextBox1.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Enabled = false;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(119, 153);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.Black;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(68, 31);
            this.rjTextBox1.TabIndex = 89;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // progressao_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 588);
            this.Controls.Add(this.pl_dados);
            this.Name = "progressao_info";
            this.Text = "progressao_info";
            this.pl_dados.ResumeLayout(false);
            this.pl_todos.ResumeLayout(false);
            this.pl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_dados;
        private System.Windows.Forms.Panel pl_todos;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Button bt_fechar;
        private painel.RJTextBox txt_classe;
        private System.Windows.Forms.Label lb_classe;
        private painel.RJTextBox txt_patente;
        private painel.RJTextBox txt_level;
        private System.Windows.Forms.Label lb_poder;
        private System.Windows.Forms.Label lb_nick;
        private System.Windows.Forms.Label lb_patente;
        private painel.RJTextBox txt_nick;
        private painel.RJTextBox txt_poder;
        private System.Windows.Forms.Label lb_level;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_excluir;
        private painel.RJTextBox rjTextBox1;
        private System.Windows.Forms.Label label1;
    }
}