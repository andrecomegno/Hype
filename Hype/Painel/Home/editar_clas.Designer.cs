
namespace Hype.Painel.Home
{
    partial class editar_clas
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
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.txt_nome_cla = new Hype.Painel.RJTextBox();
            this.txt_nick_lider = new Hype.Painel.RJTextBox();
            this.pl_botoes = new System.Windows.Forms.Panel();
            this.lb_nick_lider = new System.Windows.Forms.Label();
            this.lb_nome_cla = new System.Windows.Forms.Label();
            this.pl_botoes.SuspendLayout();
            this.SuspendLayout();
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
            this.bt_cancelar.Location = new System.Drawing.Point(526, 152);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 36);
            this.bt_cancelar.TabIndex = 162;
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
            this.bt_salvar.Location = new System.Drawing.Point(393, 152);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(122, 36);
            this.bt_salvar.TabIndex = 163;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
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
            this.txt_nome_cla.Location = new System.Drawing.Point(387, 83);
            this.txt_nome_cla.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome_cla.Multiline = false;
            this.txt_nome_cla.Name = "txt_nome_cla";
            this.txt_nome_cla.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nome_cla.PasswordChar = false;
            this.txt_nome_cla.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nome_cla.PlaceholderText = "";
            this.txt_nome_cla.Size = new System.Drawing.Size(261, 31);
            this.txt_nome_cla.TabIndex = 161;
            this.txt_nome_cla.Texts = "";
            this.txt_nome_cla.UnderlinedStyle = false;
            this.txt_nome_cla.Enter += new System.EventHandler(this.txt_nome_cla_Enter);
            this.txt_nome_cla.Leave += new System.EventHandler(this.txt_nome_cla_Leave);
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
            this.txt_nick_lider.Location = new System.Drawing.Point(217, 83);
            this.txt_nick_lider.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nick_lider.Multiline = false;
            this.txt_nick_lider.Name = "txt_nick_lider";
            this.txt_nick_lider.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nick_lider.PasswordChar = false;
            this.txt_nick_lider.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nick_lider.PlaceholderText = "";
            this.txt_nick_lider.Size = new System.Drawing.Size(162, 31);
            this.txt_nick_lider.TabIndex = 160;
            this.txt_nick_lider.Texts = "";
            this.txt_nick_lider.UnderlinedStyle = false;
            this.txt_nick_lider.Enter += new System.EventHandler(this.txt_nick_lider_Enter);
            this.txt_nick_lider.Leave += new System.EventHandler(this.txt_nick_lider_Leave);
            // 
            // pl_botoes
            // 
            this.pl_botoes.Controls.Add(this.lb_nome_cla);
            this.pl_botoes.Controls.Add(this.lb_nick_lider);
            this.pl_botoes.Controls.Add(this.txt_nome_cla);
            this.pl_botoes.Controls.Add(this.bt_cancelar);
            this.pl_botoes.Controls.Add(this.txt_nick_lider);
            this.pl_botoes.Controls.Add(this.bt_salvar);
            this.pl_botoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_botoes.Location = new System.Drawing.Point(0, 0);
            this.pl_botoes.Name = "pl_botoes";
            this.pl_botoes.Size = new System.Drawing.Size(880, 300);
            this.pl_botoes.TabIndex = 164;
            // 
            // lb_nick_lider
            // 
            this.lb_nick_lider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nick_lider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nick_lider.ForeColor = System.Drawing.Color.White;
            this.lb_nick_lider.Location = new System.Drawing.Point(214, 62);
            this.lb_nick_lider.Name = "lb_nick_lider";
            this.lb_nick_lider.Size = new System.Drawing.Size(165, 17);
            this.lb_nick_lider.TabIndex = 164;
            this.lb_nick_lider.Text = "Nick Lider";
            this.lb_nick_lider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_nome_cla
            // 
            this.lb_nome_cla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nome_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_cla.ForeColor = System.Drawing.Color.White;
            this.lb_nome_cla.Location = new System.Drawing.Point(386, 62);
            this.lb_nome_cla.Name = "lb_nome_cla";
            this.lb_nome_cla.Size = new System.Drawing.Size(262, 17);
            this.lb_nome_cla.TabIndex = 165;
            this.lb_nome_cla.Text = "Nome do Clã";
            this.lb_nome_cla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editar_clas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_botoes);
            this.Name = "editar_clas";
            this.Size = new System.Drawing.Size(880, 515);
            this.Load += new System.EventHandler(this.editar_clas_Load);
            this.pl_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_salvar;
        private RJTextBox txt_nome_cla;
        private RJTextBox txt_nick_lider;
        private System.Windows.Forms.Panel pl_botoes;
        private System.Windows.Forms.Label lb_nome_cla;
        private System.Windows.Forms.Label lb_nick_lider;
    }
}
