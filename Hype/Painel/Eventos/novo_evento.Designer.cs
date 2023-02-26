
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
            this.pl_espaco_02 = new System.Windows.Forms.Panel();
            this.pl_conta = new System.Windows.Forms.Panel();
            this.txt_classe = new Hype.script.RJComboBox();
            this.txt_nick = new Hype.Painel.RJTextBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pl_espaco_01 = new System.Windows.Forms.Panel();
            this.pl_top = new System.Windows.Forms.Panel();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.txt_data_evento = new System.Windows.Forms.Label();
            this.lb_data_entrada = new System.Windows.Forms.Label();
            this.lb_nome_evento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new Hype.Painel.RJTextBox();
            this.rjTextBox2 = new Hype.Painel.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_buscar = new System.Windows.Forms.PictureBox();
            this.txt_buscar = new Hype.Painel.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pl_conta_principal.SuspendLayout();
            this.pl_conta.SuspendLayout();
            this.pl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_buscar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_conta_principal
            // 
            this.pl_conta_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_conta_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_conta_principal.Controls.Add(this.panel3);
            this.pl_conta_principal.Controls.Add(this.panel2);
            this.pl_conta_principal.Controls.Add(this.panel1);
            this.pl_conta_principal.Controls.Add(this.pl_espaco_02);
            this.pl_conta_principal.Controls.Add(this.pl_conta);
            this.pl_conta_principal.Controls.Add(this.pl_espaco_01);
            this.pl_conta_principal.Controls.Add(this.pl_top);
            this.pl_conta_principal.Location = new System.Drawing.Point(14, 3);
            this.pl_conta_principal.Name = "pl_conta_principal";
            this.pl_conta_principal.Size = new System.Drawing.Size(1172, 1008);
            this.pl_conta_principal.TabIndex = 78;
            // 
            // pl_espaco_02
            // 
            this.pl_espaco_02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_espaco_02.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_espaco_02.Location = new System.Drawing.Point(0, 222);
            this.pl_espaco_02.Name = "pl_espaco_02";
            this.pl_espaco_02.Size = new System.Drawing.Size(1172, 10);
            this.pl_espaco_02.TabIndex = 78;
            // 
            // pl_conta
            // 
            this.pl_conta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_conta.Controls.Add(this.bt_buscar);
            this.pl_conta.Controls.Add(this.lb_titulo);
            this.pl_conta.Controls.Add(this.txt_buscar);
            this.pl_conta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_conta.Location = new System.Drawing.Point(0, 83);
            this.pl_conta.Name = "pl_conta";
            this.pl_conta.Size = new System.Drawing.Size(1172, 139);
            this.pl_conta.TabIndex = 64;
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
            this.txt_classe.Location = new System.Drawing.Point(583, 71);
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
            this.txt_nick.Location = new System.Drawing.Point(341, 71);
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
            // lb_nome_evento
            // 
            this.lb_nome_evento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nome_evento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_evento.ForeColor = System.Drawing.Color.White;
            this.lb_nome_evento.Location = new System.Drawing.Point(338, 50);
            this.lb_nome_evento.Name = "lb_nome_evento";
            this.lb_nome_evento.Size = new System.Drawing.Size(238, 17);
            this.lb_nome_evento.TabIndex = 178;
            this.lb_nome_evento.Text = "Nome Evento";
            this.lb_nome_evento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(583, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 179;
            this.label1.Text = "Clã Participante";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(142, 71);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "Nick";
            this.rjTextBox1.Size = new System.Drawing.Size(235, 31);
            this.rjTextBox1.TabIndex = 180;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.White;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.rjTextBox2.BorderRadius = 0;
            this.rjTextBox2.BorderSize = 1;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(386, 71);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "Ouro";
            this.rjTextBox2.Size = new System.Drawing.Size(78, 31);
            this.rjTextBox2.TabIndex = 181;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 17);
            this.label2.TabIndex = 182;
            this.label2.Text = "Nick";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(383, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 183;
            this.label3.Text = "Doação";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.bt_buscar.Image = global::Hype.Properties.Resources.buscar;
            this.bt_buscar.Location = new System.Drawing.Point(950, 93);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(20, 20);
            this.bt_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_buscar.TabIndex = 186;
            this.bt_buscar.TabStop = false;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_buscar.BorderColor = System.Drawing.Color.Transparent;
            this.txt_buscar.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_buscar.BorderRadius = 15;
            this.txt_buscar.BorderSize = 2;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_buscar.Location = new System.Drawing.Point(142, 86);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Multiline = false;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_buscar.PasswordChar = false;
            this.txt_buscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_buscar.PlaceholderText = "O que você procura ?";
            this.txt_buscar.Size = new System.Drawing.Size(838, 31);
            this.txt_buscar.TabIndex = 185;
            this.txt_buscar.Texts = "";
            this.txt_buscar.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_classe);
            this.panel1.Controls.Add(this.lb_nome_evento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_nick);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 139);
            this.panel1.TabIndex = 187;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1166, 31);
            this.label4.TabIndex = 96;
            this.label4.Text = "TITULO EVENTO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 10);
            this.panel2.TabIndex = 79;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rjTextBox2);
            this.panel3.Controls.Add(this.rjTextBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1172, 599);
            this.panel3.TabIndex = 188;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1166, 31);
            this.label5.TabIndex = 96;
            this.label5.Text = "TITULO EVENTO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // novo_evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_conta_principal);
            this.Name = "novo_evento";
            this.Size = new System.Drawing.Size(1200, 1014);
            this.Load += new System.EventHandler(this.novo_evento_Load);
            this.pl_conta_principal.ResumeLayout(false);
            this.pl_conta.ResumeLayout(false);
            this.pl_top.ResumeLayout(false);
            this.pl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_buscar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_conta_principal;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_nome_evento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJTextBox rjTextBox2;
        private RJTextBox rjTextBox1;
        private System.Windows.Forms.PictureBox bt_buscar;
        private RJTextBox txt_buscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}
