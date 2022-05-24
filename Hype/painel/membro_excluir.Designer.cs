
namespace Hype.painel
{
    partial class membro_excluir
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
            this.pl_todos = new System.Windows.Forms.Panel();
            this.txt_data_excluir = new Hype.painel.RJTextBox();
            this.pl_botao = new System.Windows.Forms.Panel();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.pl_membro = new System.Windows.Forms.Panel();
            this.txt_level = new Hype.painel.RJTextBox();
            this.lb_poder = new System.Windows.Forms.Label();
            this.lb_nick = new System.Windows.Forms.Label();
            this.lb_patente = new System.Windows.Forms.Label();
            this.txt_nick = new Hype.painel.RJTextBox();
            this.txt_poder = new Hype.painel.RJTextBox();
            this.lb_level = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_patente = new Hype.painel.RJTextBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.txt_classe = new Hype.painel.RJTextBox();
            this.lb_classe = new System.Windows.Forms.Label();
            this.pl_todos.SuspendLayout();
            this.pl_botao.SuspendLayout();
            this.pl_membro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_todos
            // 
            this.pl_todos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_todos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_todos.Controls.Add(this.pl_botao);
            this.pl_todos.Controls.Add(this.pl_membro);
            this.pl_todos.Location = new System.Drawing.Point(20, 141);
            this.pl_todos.Name = "pl_todos";
            this.pl_todos.Size = new System.Drawing.Size(725, 344);
            this.pl_todos.TabIndex = 23;
            // 
            // txt_data_excluir
            // 
            this.txt_data_excluir.BackColor = System.Drawing.Color.Lavender;
            this.txt_data_excluir.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txt_data_excluir.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_data_excluir.BorderRadius = 0;
            this.txt_data_excluir.BorderSize = 1;
            this.txt_data_excluir.Enabled = false;
            this.txt_data_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_data_excluir.Location = new System.Drawing.Point(53, 126);
            this.txt_data_excluir.Margin = new System.Windows.Forms.Padding(4);
            this.txt_data_excluir.Multiline = false;
            this.txt_data_excluir.Name = "txt_data_excluir";
            this.txt_data_excluir.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_data_excluir.PasswordChar = false;
            this.txt_data_excluir.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_data_excluir.PlaceholderText = "";
            this.txt_data_excluir.Size = new System.Drawing.Size(111, 31);
            this.txt_data_excluir.TabIndex = 65;
            this.txt_data_excluir.Texts = "";
            this.txt_data_excluir.UnderlinedStyle = false;
            // 
            // pl_botao
            // 
            this.pl_botao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_botao.Controls.Add(this.bt_cancelar);
            this.pl_botao.Controls.Add(this.bt_excluir);
            this.pl_botao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_botao.Location = new System.Drawing.Point(0, 293);
            this.pl_botao.Name = "pl_botao";
            this.pl_botao.Size = new System.Drawing.Size(725, 51);
            this.pl_botao.TabIndex = 64;
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
            this.bt_cancelar.Location = new System.Drawing.Point(549, 12);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 36);
            this.bt_cancelar.TabIndex = 62;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
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
            this.bt_excluir.Location = new System.Drawing.Point(416, 12);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(122, 36);
            this.bt_excluir.TabIndex = 63;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // pl_membro
            // 
            this.pl_membro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_membro.Controls.Add(this.txt_classe);
            this.pl_membro.Controls.Add(this.lb_classe);
            this.pl_membro.Controls.Add(this.lb_data);
            this.pl_membro.Controls.Add(this.txt_patente);
            this.pl_membro.Controls.Add(this.textBox1);
            this.pl_membro.Controls.Add(this.txt_level);
            this.pl_membro.Controls.Add(this.lb_poder);
            this.pl_membro.Controls.Add(this.txt_data_excluir);
            this.pl_membro.Controls.Add(this.lb_nick);
            this.pl_membro.Controls.Add(this.lb_patente);
            this.pl_membro.Controls.Add(this.txt_nick);
            this.pl_membro.Controls.Add(this.txt_poder);
            this.pl_membro.Controls.Add(this.lb_level);
            this.pl_membro.Controls.Add(this.label1);
            this.pl_membro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_membro.Location = new System.Drawing.Point(0, 0);
            this.pl_membro.Name = "pl_membro";
            this.pl_membro.Size = new System.Drawing.Size(725, 288);
            this.pl_membro.TabIndex = 18;
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
            this.txt_level.Location = new System.Drawing.Point(222, 43);
            this.txt_level.Margin = new System.Windows.Forms.Padding(4);
            this.txt_level.Multiline = false;
            this.txt_level.Name = "txt_level";
            this.txt_level.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_level.PasswordChar = false;
            this.txt_level.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_level.PlaceholderText = "";
            this.txt_level.Size = new System.Drawing.Size(68, 31);
            this.txt_level.TabIndex = 69;
            this.txt_level.Texts = "";
            this.txt_level.UnderlinedStyle = false;
            // 
            // lb_poder
            // 
            this.lb_poder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_poder.ForeColor = System.Drawing.Color.White;
            this.lb_poder.Location = new System.Drawing.Point(297, 22);
            this.lb_poder.Name = "lb_poder";
            this.lb_poder.Size = new System.Drawing.Size(120, 17);
            this.lb_poder.TabIndex = 66;
            this.lb_poder.Text = "Poder";
            this.lb_poder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_nick
            // 
            this.lb_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nick.ForeColor = System.Drawing.Color.White;
            this.lb_nick.Location = new System.Drawing.Point(53, 22);
            this.lb_nick.Name = "lb_nick";
            this.lb_nick.Size = new System.Drawing.Size(162, 17);
            this.lb_nick.TabIndex = 65;
            this.lb_nick.Text = "Nick";
            this.lb_nick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_patente
            // 
            this.lb_patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patente.ForeColor = System.Drawing.Color.White;
            this.lb_patente.Location = new System.Drawing.Point(554, 22);
            this.lb_patente.Name = "lb_patente";
            this.lb_patente.Size = new System.Drawing.Size(117, 17);
            this.lb_patente.TabIndex = 13;
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
            this.txt_nick.Location = new System.Drawing.Point(53, 43);
            this.txt_nick.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nick.Multiline = false;
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nick.PasswordChar = false;
            this.txt_nick.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_nick.PlaceholderText = "";
            this.txt_nick.Size = new System.Drawing.Size(162, 31);
            this.txt_nick.TabIndex = 1;
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
            this.txt_poder.Location = new System.Drawing.Point(298, 43);
            this.txt_poder.Margin = new System.Windows.Forms.Padding(4);
            this.txt_poder.Multiline = false;
            this.txt_poder.Name = "txt_poder";
            this.txt_poder.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_poder.PasswordChar = false;
            this.txt_poder.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_poder.PlaceholderText = "";
            this.txt_poder.Size = new System.Drawing.Size(119, 31);
            this.txt_poder.TabIndex = 3;
            this.txt_poder.Texts = "";
            this.txt_poder.UnderlinedStyle = false;
            // 
            // lb_level
            // 
            this.lb_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_level.ForeColor = System.Drawing.Color.White;
            this.lb_level.Location = new System.Drawing.Point(222, 22);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(68, 17);
            this.lb_level.TabIndex = 5;
            this.lb_level.Text = "Level";
            this.lb_level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(53, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(618, 100);
            this.textBox1.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 31);
            this.label1.TabIndex = 71;
            this.label1.Text = "Motivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txt_patente.Location = new System.Drawing.Point(552, 43);
            this.txt_patente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_patente.Multiline = false;
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_patente.PasswordChar = false;
            this.txt_patente.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_patente.PlaceholderText = "";
            this.txt_patente.Size = new System.Drawing.Size(119, 31);
            this.txt_patente.TabIndex = 72;
            this.txt_patente.Texts = "";
            this.txt_patente.UnderlinedStyle = false;
            // 
            // lb_data
            // 
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.ForeColor = System.Drawing.Color.White;
            this.lb_data.Location = new System.Drawing.Point(53, 105);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(111, 17);
            this.lb_data.TabIndex = 73;
            this.lb_data.Text = "Data";
            this.lb_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txt_classe.Location = new System.Drawing.Point(425, 43);
            this.txt_classe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_classe.Multiline = false;
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_classe.PasswordChar = false;
            this.txt_classe.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_classe.PlaceholderText = "";
            this.txt_classe.Size = new System.Drawing.Size(119, 31);
            this.txt_classe.TabIndex = 75;
            this.txt_classe.Texts = "";
            this.txt_classe.UnderlinedStyle = false;
            // 
            // lb_classe
            // 
            this.lb_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_classe.ForeColor = System.Drawing.Color.White;
            this.lb_classe.Location = new System.Drawing.Point(427, 22);
            this.lb_classe.Name = "lb_classe";
            this.lb_classe.Size = new System.Drawing.Size(117, 17);
            this.lb_classe.TabIndex = 74;
            this.lb_classe.Text = "Classe";
            this.lb_classe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // membro_excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.pl_todos);
            this.Name = "membro_excluir";
            this.Size = new System.Drawing.Size(764, 627);
            this.Load += new System.EventHandler(this.membro_excluir_Load);
            this.pl_todos.ResumeLayout(false);
            this.pl_botao.ResumeLayout(false);
            this.pl_membro.ResumeLayout(false);
            this.pl_membro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_todos;
        private RJTextBox txt_data_excluir;
        private System.Windows.Forms.Panel pl_botao;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Panel pl_membro;
        private RJTextBox txt_level;
        private System.Windows.Forms.Label lb_poder;
        private System.Windows.Forms.Label lb_nick;
        private System.Windows.Forms.Label lb_patente;
        private RJTextBox txt_nick;
        private RJTextBox txt_poder;
        private System.Windows.Forms.Label lb_level;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_data;
        private RJTextBox txt_patente;
        private RJTextBox txt_classe;
        private System.Windows.Forms.Label lb_classe;
    }
}
