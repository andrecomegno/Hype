
namespace Mir4
{
    partial class membros
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
            this.bt_procurar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gp_geral = new System.Windows.Forms.GroupBox();
            this.gp_secundario = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gp_geral.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rodape
            // 
            this.rodape.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rodape.Location = new System.Drawing.Point(0, 600);
            this.rodape.Name = "rodape";
            this.rodape.Size = new System.Drawing.Size(1032, 42);
            this.rodape.TabIndex = 18;
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
            this.bt_procurar.Location = new System.Drawing.Point(693, 19);
            this.bt_procurar.Name = "bt_procurar";
            this.bt_procurar.Size = new System.Drawing.Size(117, 28);
            this.bt_procurar.TabIndex = 44;
            this.bt_procurar.Text = "Procurar";
            this.bt_procurar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(178, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(509, 23);
            this.textBox1.TabIndex = 43;
            // 
            // gp_geral
            // 
            this.gp_geral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gp_geral.Controls.Add(this.gp_secundario);
            this.gp_geral.Controls.Add(this.bt_procurar);
            this.gp_geral.Controls.Add(this.textBox1);
            this.gp_geral.Location = new System.Drawing.Point(12, 59);
            this.gp_geral.Name = "gp_geral";
            this.gp_geral.Size = new System.Drawing.Size(1008, 509);
            this.gp_geral.TabIndex = 45;
            this.gp_geral.TabStop = false;
            // 
            // gp_secundario
            // 
            this.gp_secundario.Location = new System.Drawing.Point(21, 84);
            this.gp_secundario.Name = "gp_secundario";
            this.gp_secundario.Size = new System.Drawing.Size(967, 390);
            this.gp_secundario.TabIndex = 45;
            this.gp_secundario.TabStop = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 46;
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
            // membros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 642);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gp_geral);
            this.Controls.Add(this.rodape);
            this.MaximizeBox = false;
            this.Name = "membros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "membros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gp_geral.ResumeLayout(false);
            this.gp_geral.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel rodape;
        private System.Windows.Forms.Button bt_procurar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gp_geral;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox gp_secundario;
    }
}