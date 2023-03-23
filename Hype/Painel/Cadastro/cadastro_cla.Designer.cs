
namespace Hype.Painel.Cadastro
{
    partial class cadastro_cla
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
            this.pl_novo_cla = new System.Windows.Forms.Panel();
            this.lb_novo_cla = new System.Windows.Forms.Label();
            this.txt_nick_lider = new Hype.Painel.RJTextBox();
            this.pl_espaco_01 = new System.Windows.Forms.Panel();
            this.pl_top = new System.Windows.Forms.Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.txt_nome_cla = new Hype.Painel.RJTextBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.pl_novo_cla.SuspendLayout();
            this.pl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_novo_cla
            // 
            this.pl_novo_cla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_novo_cla.Controls.Add(this.bt_cancelar);
            this.pl_novo_cla.Controls.Add(this.bt_salvar);
            this.pl_novo_cla.Controls.Add(this.txt_nome_cla);
            this.pl_novo_cla.Controls.Add(this.lb_novo_cla);
            this.pl_novo_cla.Controls.Add(this.txt_nick_lider);
            this.pl_novo_cla.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_novo_cla.Location = new System.Drawing.Point(0, 83);
            this.pl_novo_cla.Name = "pl_novo_cla";
            this.pl_novo_cla.Size = new System.Drawing.Size(1200, 258);
            this.pl_novo_cla.TabIndex = 210;
            // 
            // lb_novo_cla
            // 
            this.lb_novo_cla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_novo_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_novo_cla.ForeColor = System.Drawing.Color.White;
            this.lb_novo_cla.Location = new System.Drawing.Point(3, 3);
            this.lb_novo_cla.Name = "lb_novo_cla";
            this.lb_novo_cla.Size = new System.Drawing.Size(1194, 31);
            this.lb_novo_cla.TabIndex = 97;
            this.lb_novo_cla.Text = "NOVO CLÃ";
            this.lb_novo_cla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nick_lider
            // 
            this.txt_nick_lider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nick_lider.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nick_lider.BorderColor = System.Drawing.Color.White;
            this.txt_nick_lider.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_nick_lider.BorderRadius = 0;
            this.txt_nick_lider.BorderSize = 1;
            this.txt_nick_lider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nick_lider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nick_lider.Location = new System.Drawing.Point(378, 94);
            this.txt_nick_lider.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nick_lider.Multiline = false;
            this.txt_nick_lider.Name = "txt_nick_lider";
            this.txt_nick_lider.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nick_lider.PasswordChar = false;
            this.txt_nick_lider.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nick_lider.PlaceholderText = "Nick Lider";
            this.txt_nick_lider.Size = new System.Drawing.Size(162, 31);
            this.txt_nick_lider.TabIndex = 155;
            this.txt_nick_lider.Texts = "";
            this.txt_nick_lider.UnderlinedStyle = false;
            this.txt_nick_lider.Enter += new System.EventHandler(this.txt_nick_lider_Enter);
            this.txt_nick_lider.Leave += new System.EventHandler(this.txt_nick_lider_Leave);
            // 
            // pl_espaco_01
            // 
            this.pl_espaco_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_espaco_01.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_espaco_01.Location = new System.Drawing.Point(0, 73);
            this.pl_espaco_01.Name = "pl_espaco_01";
            this.pl_espaco_01.Size = new System.Drawing.Size(1200, 10);
            this.pl_espaco_01.TabIndex = 209;
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_top.Controls.Add(this.lb_titulo);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1200, 73);
            this.pl_top.TabIndex = 208;
            // 
            // lb_titulo
            // 
            this.lb_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(-1, 6);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(1194, 31);
            this.lb_titulo.TabIndex = 96;
            this.lb_titulo.Text = "CADASTRO NOVO CLÃ";
            this.lb_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nome_cla
            // 
            this.txt_nome_cla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome_cla.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nome_cla.BorderColor = System.Drawing.Color.White;
            this.txt_nome_cla.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_nome_cla.BorderRadius = 0;
            this.txt_nome_cla.BorderSize = 1;
            this.txt_nome_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_cla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nome_cla.Location = new System.Drawing.Point(548, 94);
            this.txt_nome_cla.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome_cla.Multiline = false;
            this.txt_nome_cla.Name = "txt_nome_cla";
            this.txt_nome_cla.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nome_cla.PasswordChar = false;
            this.txt_nome_cla.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nome_cla.PlaceholderText = "Nome do Clã";
            this.txt_nome_cla.Size = new System.Drawing.Size(261, 31);
            this.txt_nome_cla.TabIndex = 156;
            this.txt_nome_cla.Texts = "";
            this.txt_nome_cla.UnderlinedStyle = false;
            this.txt_nome_cla.Enter += new System.EventHandler(this.txt_nome_cla_Enter);
            this.txt_nome_cla.Leave += new System.EventHandler(this.txt_nome_cla_Leave);
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
            this.bt_cancelar.Location = new System.Drawing.Point(687, 163);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 36);
            this.bt_cancelar.TabIndex = 158;
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
            this.bt_salvar.Location = new System.Drawing.Point(554, 163);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(122, 36);
            this.bt_salvar.TabIndex = 159;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // cadastro_cla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_novo_cla);
            this.Controls.Add(this.pl_espaco_01);
            this.Controls.Add(this.pl_top);
            this.Name = "cadastro_cla";
            this.Size = new System.Drawing.Size(1200, 1014);
            this.pl_novo_cla.ResumeLayout(false);
            this.pl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_novo_cla;
        private RJTextBox txt_nome_cla;
        private System.Windows.Forms.Label lb_novo_cla;
        private RJTextBox txt_nick_lider;
        private System.Windows.Forms.Panel pl_espaco_01;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_salvar;
    }
}
