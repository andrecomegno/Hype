
namespace Hype.Painel.Eventos
{
    partial class novo_evento
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
            this.pl_conta_principal = new System.Windows.Forms.Panel();
            this.pl_progressao = new System.Windows.Forms.Panel();
            this.pl_espaco_02 = new System.Windows.Forms.Panel();
            this.pl_conta = new System.Windows.Forms.Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pl_espaco_01 = new System.Windows.Forms.Panel();
            this.pl_top = new System.Windows.Forms.Panel();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.txt_data_evento = new System.Windows.Forms.Label();
            this.lb_data_entrada = new System.Windows.Forms.Label();
            this.txt_classe = new Hype.script.RJComboBox();
            this.txt_nick = new Hype.Painel.RJTextBox();
            this.pl_conta_principal.SuspendLayout();
            this.pl_conta.SuspendLayout();
            this.pl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_conta_principal
            // 
            this.pl_conta_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_conta_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_conta_principal.Controls.Add(this.pl_progressao);
            this.pl_conta_principal.Controls.Add(this.pl_espaco_02);
            this.pl_conta_principal.Controls.Add(this.pl_conta);
            this.pl_conta_principal.Controls.Add(this.pl_espaco_01);
            this.pl_conta_principal.Controls.Add(this.pl_top);
            this.pl_conta_principal.Location = new System.Drawing.Point(14, 3);
            this.pl_conta_principal.Name = "pl_conta_principal";
            this.pl_conta_principal.Size = new System.Drawing.Size(1172, 1008);
            this.pl_conta_principal.TabIndex = 78;
            // 
            // pl_progressao
            // 
            this.pl_progressao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_progressao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_progressao.Location = new System.Drawing.Point(0, 516);
            this.pl_progressao.Name = "pl_progressao";
            this.pl_progressao.Size = new System.Drawing.Size(1172, 167);
            this.pl_progressao.TabIndex = 86;
            // 
            // pl_espaco_02
            // 
            this.pl_espaco_02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_espaco_02.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_espaco_02.Location = new System.Drawing.Point(0, 506);
            this.pl_espaco_02.Name = "pl_espaco_02";
            this.pl_espaco_02.Size = new System.Drawing.Size(1172, 10);
            this.pl_espaco_02.TabIndex = 78;
            // 
            // pl_conta
            // 
            this.pl_conta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_conta.Controls.Add(this.txt_classe);
            this.pl_conta.Controls.Add(this.txt_nick);
            this.pl_conta.Controls.Add(this.lb_titulo);
            this.pl_conta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_conta.Location = new System.Drawing.Point(0, 83);
            this.pl_conta.Name = "pl_conta";
            this.pl_conta.Size = new System.Drawing.Size(1172, 423);
            this.pl_conta.TabIndex = 64;
            // 
            // lb_titulo
            // 
            this.lb_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(3, 3);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(1166, 31);
            this.lb_titulo.TabIndex = 96;
            this.lb_titulo.Text = "NOVO EVENTO";
            this.lb_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_espaco_01
            // 
            this.pl_espaco_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_espaco_01.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_espaco_01.Location = new System.Drawing.Point(0, 73);
            this.pl_espaco_01.Name = "pl_espaco_01";
            this.pl_espaco_01.Size = new System.Drawing.Size(1172, 10);
            this.pl_espaco_01.TabIndex = 77;
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_top.Controls.Add(this.bt_voltar);
            this.pl_top.Controls.Add(this.txt_data_evento);
            this.pl_top.Controls.Add(this.lb_data_entrada);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1172, 73);
            this.pl_top.TabIndex = 76;
            // 
            // bt_voltar
            // 
            this.bt_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_voltar.FlatAppearance.BorderSize = 0;
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltar.ForeColor = System.Drawing.Color.White;
            this.bt_voltar.Location = new System.Drawing.Point(0, 6);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(73, 36);
            this.bt_voltar.TabIndex = 59;
            this.bt_voltar.Text = "<<";
            this.bt_voltar.UseVisualStyleBackColor = false;
            // 
            // txt_data_evento
            // 
            this.txt_data_evento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_evento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_evento.ForeColor = System.Drawing.Color.White;
            this.txt_data_evento.Location = new System.Drawing.Point(1037, 6);
            this.txt_data_evento.Name = "txt_data_evento";
            this.txt_data_evento.Size = new System.Drawing.Size(132, 17);
            this.txt_data_evento.TabIndex = 73;
            this.txt_data_evento.Text = "Data do Evento";
            this.txt_data_evento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_data_entrada
            // 
            this.lb_data_entrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_data_entrada.AutoSize = true;
            this.lb_data_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_entrada.ForeColor = System.Drawing.Color.White;
            this.lb_data_entrada.Location = new System.Drawing.Point(1054, 23);
            this.lb_data_entrada.Name = "lb_data_entrada";
            this.lb_data_entrada.Size = new System.Drawing.Size(99, 20);
            this.lb_data_entrada.TabIndex = 70;
            this.lb_data_entrada.Text = "00/00/0000";
            // 
            // txt_classe
            // 
            this.txt_classe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_classe.BackColor = System.Drawing.Color.White;
            this.txt_classe.BorderColor = System.Drawing.Color.Transparent;
            this.txt_classe.BorderSize = 0;
            this.txt_classe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_classe.ForeColor = System.Drawing.Color.DimGray;
            this.txt_classe.IconColor = System.Drawing.Color.Black;
            this.txt_classe.Items.AddRange(new object[] {
            "Classe",
            "Besteira",
            "Feiticeira",
            "Guerreiro",
            "Lanceiro",
            "Taoista"});
            this.txt_classe.ListBackColor = System.Drawing.Color.White;
            this.txt_classe.ListTextColor = System.Drawing.Color.DimGray;
            this.txt_classe.Location = new System.Drawing.Point(517, 53);
            this.txt_classe.MinimumSize = new System.Drawing.Size(50, 30);
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.Size = new System.Drawing.Size(170, 31);
            this.txt_classe.TabIndex = 177;
            this.txt_classe.Texts = "";
            // 
            // txt_nick
            // 
            this.txt_nick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nick.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nick.BorderColor = System.Drawing.Color.White;
            this.txt_nick.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_nick.BorderRadius = 0;
            this.txt_nick.BorderSize = 1;
            this.txt_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nick.Location = new System.Drawing.Point(275, 53);
            this.txt_nick.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nick.Multiline = false;
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nick.PasswordChar = false;
            this.txt_nick.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nick.PlaceholderText = "Nome do Evento";
            this.txt_nick.Size = new System.Drawing.Size(235, 31);
            this.txt_nick.TabIndex = 171;
            this.txt_nick.Texts = "";
            this.txt_nick.UnderlinedStyle = false;
            // 
            // novo_evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_conta_principal);
            this.Name = "novo_evento";
            this.Size = new System.Drawing.Size(1200, 1014);
            this.pl_conta_principal.ResumeLayout(false);
            this.pl_conta.ResumeLayout(false);
            this.pl_top.ResumeLayout(false);
            this.pl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_conta_principal;
        private System.Windows.Forms.Panel pl_progressao;
        private System.Windows.Forms.Panel pl_espaco_02;
        private System.Windows.Forms.Panel pl_conta;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Panel pl_espaco_01;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.Label txt_data_evento;
        private System.Windows.Forms.Label lb_data_entrada;
        private script.RJComboBox txt_classe;
        private RJTextBox txt_nick;
    }
}
