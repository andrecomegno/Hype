
namespace Mir4
{
    partial class relatorio
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
            this.rodape = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gp_geral = new System.Windows.Forms.GroupBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.gp_secundario = new System.Windows.Forms.GroupBox();
            this.bt_procurar = new System.Windows.Forms.Button();
            this.txt_procurar = new System.Windows.Forms.TextBox();
            this.bt_relatorio = new System.Windows.Forms.Button();
            this.bt_membros = new System.Windows.Forms.Button();
            this.bt_cadastro = new System.Windows.Forms.Button();
            this.bt_controle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gp_geral.SuspendLayout();
            this.gp_secundario.SuspendLayout();
            this.SuspendLayout();
            // 
            // rodape
            // 
            this.rodape.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodape.Location = new System.Drawing.Point(0, 730);
            this.rodape.Name = "rodape";
            this.rodape.Size = new System.Drawing.Size(1252, 42);
            this.rodape.TabIndex = 46;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // gp_geral
            // 
            this.gp_geral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_geral.Controls.Add(this.bt_sair);
            this.gp_geral.Controls.Add(this.gp_secundario);
            this.gp_geral.Controls.Add(this.bt_procurar);
            this.gp_geral.Controls.Add(this.txt_procurar);
            this.gp_geral.Location = new System.Drawing.Point(12, 67);
            this.gp_geral.Name = "gp_geral";
            this.gp_geral.Size = new System.Drawing.Size(1228, 638);
            this.gp_geral.TabIndex = 48;
            this.gp_geral.TabStop = false;
            // 
            // bt_sair
            // 
            this.bt_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_sair.BackColor = System.Drawing.Color.Tomato;
            this.bt_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sair.FlatAppearance.BorderSize = 0;
            this.bt_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.bt_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.White;
            this.bt_sair.Location = new System.Drawing.Point(1079, 581);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(128, 42);
            this.bt_sair.TabIndex = 46;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = false;
            // 
            // gp_secundario
            // 
            this.gp_secundario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_secundario.Controls.Add(this.bt_relatorio);
            this.gp_secundario.Controls.Add(this.bt_membros);
            this.gp_secundario.Controls.Add(this.bt_cadastro);
            this.gp_secundario.Controls.Add(this.bt_controle);
            this.gp_secundario.Location = new System.Drawing.Point(21, 84);
            this.gp_secundario.Name = "gp_secundario";
            this.gp_secundario.Size = new System.Drawing.Size(1186, 459);
            this.gp_secundario.TabIndex = 45;
            this.gp_secundario.TabStop = false;
            // 
            // bt_procurar
            // 
            this.bt_procurar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_procurar.BackColor = System.Drawing.Color.Gold;
            this.bt_procurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_procurar.FlatAppearance.BorderSize = 0;
            this.bt_procurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bt_procurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bt_procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_procurar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_procurar.ForeColor = System.Drawing.Color.White;
            this.bt_procurar.Location = new System.Drawing.Point(803, 37);
            this.bt_procurar.Name = "bt_procurar";
            this.bt_procurar.Size = new System.Drawing.Size(117, 28);
            this.bt_procurar.TabIndex = 44;
            this.bt_procurar.Text = "Procurar";
            this.bt_procurar.UseVisualStyleBackColor = false;
            // 
            // txt_procurar
            // 
            this.txt_procurar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_procurar.Location = new System.Drawing.Point(288, 41);
            this.txt_procurar.Name = "txt_procurar";
            this.txt_procurar.Size = new System.Drawing.Size(509, 23);
            this.txt_procurar.TabIndex = 43;
            // 
            // bt_relatorio
            // 
            this.bt_relatorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_relatorio.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_relatorio.FlatAppearance.BorderSize = 0;
            this.bt_relatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.bt_relatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.bt_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_relatorio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_relatorio.ForeColor = System.Drawing.Color.White;
            this.bt_relatorio.Location = new System.Drawing.Point(195, 268);
            this.bt_relatorio.Name = "bt_relatorio";
            this.bt_relatorio.Size = new System.Drawing.Size(193, 69);
            this.bt_relatorio.TabIndex = 46;
            this.bt_relatorio.Text = "  RELATÓRIO";
            this.bt_relatorio.UseVisualStyleBackColor = false;
            // 
            // bt_membros
            // 
            this.bt_membros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_membros.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_membros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_membros.FlatAppearance.BorderSize = 0;
            this.bt_membros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood;
            this.bt_membros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.bt_membros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_membros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_membros.ForeColor = System.Drawing.Color.White;
            this.bt_membros.Location = new System.Drawing.Point(195, 193);
            this.bt_membros.Name = "bt_membros";
            this.bt_membros.Size = new System.Drawing.Size(193, 69);
            this.bt_membros.TabIndex = 43;
            this.bt_membros.Text = "   MEMBROS";
            this.bt_membros.UseVisualStyleBackColor = false;
            // 
            // bt_cadastro
            // 
            this.bt_cadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_cadastro.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastro.FlatAppearance.BorderSize = 0;
            this.bt_cadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bt_cadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bt_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastro.ForeColor = System.Drawing.Color.White;
            this.bt_cadastro.Location = new System.Drawing.Point(195, 43);
            this.bt_cadastro.Name = "bt_cadastro";
            this.bt_cadastro.Size = new System.Drawing.Size(193, 69);
            this.bt_cadastro.TabIndex = 44;
            this.bt_cadastro.Text = "  CADASTRO";
            this.bt_cadastro.UseVisualStyleBackColor = false;
            // 
            // bt_controle
            // 
            this.bt_controle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_controle.BackColor = System.Drawing.Color.Gold;
            this.bt_controle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_controle.FlatAppearance.BorderSize = 0;
            this.bt_controle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.bt_controle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.bt_controle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_controle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_controle.ForeColor = System.Drawing.Color.White;
            this.bt_controle.Location = new System.Drawing.Point(195, 118);
            this.bt_controle.Name = "bt_controle";
            this.bt_controle.Size = new System.Drawing.Size(193, 69);
            this.bt_controle.TabIndex = 45;
            this.bt_controle.Text = "  CONTROLE";
            this.bt_controle.UseVisualStyleBackColor = false;
            // 
            // relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 772);
            this.Controls.Add(this.gp_geral);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rodape);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "relatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gp_geral.ResumeLayout(false);
            this.gp_geral.PerformLayout();
            this.gp_secundario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel rodape;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox gp_geral;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.GroupBox gp_secundario;
        private System.Windows.Forms.Button bt_procurar;
        private System.Windows.Forms.TextBox txt_procurar;
        private System.Windows.Forms.Button bt_relatorio;
        private System.Windows.Forms.Button bt_membros;
        private System.Windows.Forms.Button bt_cadastro;
        private System.Windows.Forms.Button bt_controle;
    }
}