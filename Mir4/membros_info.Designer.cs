
namespace Mir4
{
    partial class membros_info
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
            this.bt_fechar = new System.Windows.Forms.Button();
            this.pl_dados = new System.Windows.Forms.Panel();
            this.pl_todos = new System.Windows.Forms.Panel();
            this.pl_botao = new System.Windows.Forms.Panel();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.pl_remanejamento = new System.Windows.Forms.Panel();
            this.lb_data_rema = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_data_rema = new Mir4.painel.RJTextBox();
            this.lb_remanejamento = new System.Windows.Forms.Label();
            this.txt_vai_cla_rema = new Mir4.painel.RJTextBox();
            this.txt_esta_cla_rema = new Mir4.painel.RJTextBox();
            this.pl_membro = new System.Windows.Forms.Panel();
            this.txt_level = new Mir4.painel.RJTextBox();
            this.lb_esta_cla = new System.Windows.Forms.Label();
            this.lb_veio_cla = new System.Windows.Forms.Label();
            this.lb_poder = new System.Windows.Forms.Label();
            this.lb_nick = new System.Windows.Forms.Label();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.txt_data_entrada = new Mir4.painel.RJTextBox();
            this.foto_classe = new Mir4.script.RJCircularPictureBox();
            this.lb_patente = new System.Windows.Forms.Label();
            this.txt_patente = new System.Windows.Forms.ComboBox();
            this.txt_nick = new Mir4.painel.RJTextBox();
            this.txt_poder = new Mir4.painel.RJTextBox();
            this.lb_level = new System.Windows.Forms.Label();
            this.lb_classe = new System.Windows.Forms.Label();
            this.txt_classe = new System.Windows.Forms.ComboBox();
            this.txt_esta_cla = new Mir4.painel.RJTextBox();
            this.txt_veio_cla = new Mir4.painel.RJTextBox();
            this.pl_top.SuspendLayout();
            this.pl_dados.SuspendLayout();
            this.pl_todos.SuspendLayout();
            this.pl_botao.SuspendLayout();
            this.pl_remanejamento.SuspendLayout();
            this.pl_membro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_classe)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.Black;
            this.pl_top.Controls.Add(this.bt_fechar);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(748, 34);
            this.pl_top.TabIndex = 2;
            this.pl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_top_MouseDown);
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
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // pl_dados
            // 
            this.pl_dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_dados.Controls.Add(this.pl_todos);
            this.pl_dados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_dados.Location = new System.Drawing.Point(0, 34);
            this.pl_dados.Name = "pl_dados";
            this.pl_dados.Size = new System.Drawing.Size(748, 563);
            this.pl_dados.TabIndex = 4;
            // 
            // pl_todos
            // 
            this.pl_todos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_todos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_todos.Controls.Add(this.pl_botao);
            this.pl_todos.Controls.Add(this.pl_remanejamento);
            this.pl_todos.Controls.Add(this.pl_membro);
            this.pl_todos.Location = new System.Drawing.Point(12, 7);
            this.pl_todos.Name = "pl_todos";
            this.pl_todos.Size = new System.Drawing.Size(725, 551);
            this.pl_todos.TabIndex = 22;
            // 
            // pl_botao
            // 
            this.pl_botao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_botao.Controls.Add(this.bt_cancelar);
            this.pl_botao.Controls.Add(this.bt_salvar);
            this.pl_botao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_botao.Location = new System.Drawing.Point(0, 490);
            this.pl_botao.Name = "pl_botao";
            this.pl_botao.Size = new System.Drawing.Size(725, 61);
            this.pl_botao.TabIndex = 64;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancelar.BackColor = System.Drawing.Color.Crimson;
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(600, 22);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 36);
            this.bt_cancelar.TabIndex = 62;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_salvar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvar.FlatAppearance.BorderSize = 0;
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.ForeColor = System.Drawing.Color.White;
            this.bt_salvar.Location = new System.Drawing.Point(467, 22);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(122, 36);
            this.bt_salvar.TabIndex = 63;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            // 
            // pl_remanejamento
            // 
            this.pl_remanejamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_remanejamento.Controls.Add(this.lb_data_rema);
            this.pl_remanejamento.Controls.Add(this.label2);
            this.pl_remanejamento.Controls.Add(this.label1);
            this.pl_remanejamento.Controls.Add(this.txt_data_rema);
            this.pl_remanejamento.Controls.Add(this.lb_remanejamento);
            this.pl_remanejamento.Controls.Add(this.txt_vai_cla_rema);
            this.pl_remanejamento.Controls.Add(this.txt_esta_cla_rema);
            this.pl_remanejamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_remanejamento.Location = new System.Drawing.Point(0, 322);
            this.pl_remanejamento.Name = "pl_remanejamento";
            this.pl_remanejamento.Size = new System.Drawing.Size(725, 141);
            this.pl_remanejamento.TabIndex = 19;
            // 
            // lb_data_rema
            // 
            this.lb_data_rema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_rema.ForeColor = System.Drawing.Color.White;
            this.lb_data_rema.Location = new System.Drawing.Point(53, 60);
            this.lb_data_rema.Name = "lb_data_rema";
            this.lb_data_rema.Size = new System.Drawing.Size(111, 17);
            this.lb_data_rema.TabIndex = 69;
            this.lb_data_rema.Text = "Data";
            this.lb_data_rema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(416, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Vai para o Clã";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Está no Clã";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_data_rema
            // 
            this.txt_data_rema.BackColor = System.Drawing.Color.White;
            this.txt_data_rema.BorderColor = System.Drawing.Color.White;
            this.txt_data_rema.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_data_rema.BorderRadius = 0;
            this.txt_data_rema.BorderSize = 1;
            this.txt_data_rema.Enabled = false;
            this.txt_data_rema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_rema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_data_rema.Location = new System.Drawing.Point(53, 81);
            this.txt_data_rema.Margin = new System.Windows.Forms.Padding(4);
            this.txt_data_rema.Multiline = false;
            this.txt_data_rema.Name = "txt_data_rema";
            this.txt_data_rema.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_data_rema.PasswordChar = false;
            this.txt_data_rema.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_data_rema.PlaceholderText = "";
            this.txt_data_rema.Size = new System.Drawing.Size(111, 31);
            this.txt_data_rema.TabIndex = 65;
            this.txt_data_rema.Texts = "";
            this.txt_data_rema.UnderlinedStyle = false;
            // 
            // lb_remanejamento
            // 
            this.lb_remanejamento.AutoSize = true;
            this.lb_remanejamento.BackColor = System.Drawing.Color.Transparent;
            this.lb_remanejamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_remanejamento.ForeColor = System.Drawing.Color.White;
            this.lb_remanejamento.Location = new System.Drawing.Point(261, 11);
            this.lb_remanejamento.Name = "lb_remanejamento";
            this.lb_remanejamento.Size = new System.Drawing.Size(203, 29);
            this.lb_remanejamento.TabIndex = 65;
            this.lb_remanejamento.Text = "Remanejamento";
            this.lb_remanejamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_vai_cla_rema
            // 
            this.txt_vai_cla_rema.BackColor = System.Drawing.Color.White;
            this.txt_vai_cla_rema.BorderColor = System.Drawing.Color.White;
            this.txt_vai_cla_rema.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_vai_cla_rema.BorderRadius = 0;
            this.txt_vai_cla_rema.BorderSize = 1;
            this.txt_vai_cla_rema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vai_cla_rema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_vai_cla_rema.Location = new System.Drawing.Point(418, 81);
            this.txt_vai_cla_rema.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vai_cla_rema.Multiline = false;
            this.txt_vai_cla_rema.Name = "txt_vai_cla_rema";
            this.txt_vai_cla_rema.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_vai_cla_rema.PasswordChar = false;
            this.txt_vai_cla_rema.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_vai_cla_rema.PlaceholderText = "";
            this.txt_vai_cla_rema.Size = new System.Drawing.Size(254, 31);
            this.txt_vai_cla_rema.TabIndex = 66;
            this.txt_vai_cla_rema.Texts = "";
            this.txt_vai_cla_rema.UnderlinedStyle = false;
            // 
            // txt_esta_cla_rema
            // 
            this.txt_esta_cla_rema.BackColor = System.Drawing.Color.White;
            this.txt_esta_cla_rema.BorderColor = System.Drawing.Color.White;
            this.txt_esta_cla_rema.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_esta_cla_rema.BorderRadius = 0;
            this.txt_esta_cla_rema.BorderSize = 1;
            this.txt_esta_cla_rema.Enabled = false;
            this.txt_esta_cla_rema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_esta_cla_rema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_esta_cla_rema.Location = new System.Drawing.Point(172, 81);
            this.txt_esta_cla_rema.Margin = new System.Windows.Forms.Padding(4);
            this.txt_esta_cla_rema.Multiline = false;
            this.txt_esta_cla_rema.Name = "txt_esta_cla_rema";
            this.txt_esta_cla_rema.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_esta_cla_rema.PasswordChar = false;
            this.txt_esta_cla_rema.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_esta_cla_rema.PlaceholderText = "";
            this.txt_esta_cla_rema.Size = new System.Drawing.Size(238, 31);
            this.txt_esta_cla_rema.TabIndex = 65;
            this.txt_esta_cla_rema.Texts = "";
            this.txt_esta_cla_rema.UnderlinedStyle = false;
            // 
            // pl_membro
            // 
            this.pl_membro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_membro.Controls.Add(this.txt_level);
            this.pl_membro.Controls.Add(this.lb_esta_cla);
            this.pl_membro.Controls.Add(this.lb_veio_cla);
            this.pl_membro.Controls.Add(this.lb_poder);
            this.pl_membro.Controls.Add(this.lb_nick);
            this.pl_membro.Controls.Add(this.bt_excluir);
            this.pl_membro.Controls.Add(this.txt_data_entrada);
            this.pl_membro.Controls.Add(this.foto_classe);
            this.pl_membro.Controls.Add(this.lb_patente);
            this.pl_membro.Controls.Add(this.txt_patente);
            this.pl_membro.Controls.Add(this.txt_nick);
            this.pl_membro.Controls.Add(this.txt_poder);
            this.pl_membro.Controls.Add(this.lb_level);
            this.pl_membro.Controls.Add(this.lb_classe);
            this.pl_membro.Controls.Add(this.txt_classe);
            this.pl_membro.Controls.Add(this.txt_esta_cla);
            this.pl_membro.Controls.Add(this.txt_veio_cla);
            this.pl_membro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_membro.Location = new System.Drawing.Point(0, 0);
            this.pl_membro.Name = "pl_membro";
            this.pl_membro.Size = new System.Drawing.Size(725, 322);
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
            this.txt_level.Location = new System.Drawing.Point(281, 200);
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
            // lb_esta_cla
            // 
            this.lb_esta_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_esta_cla.ForeColor = System.Drawing.Color.White;
            this.lb_esta_cla.Location = new System.Drawing.Point(357, 244);
            this.lb_esta_cla.Name = "lb_esta_cla";
            this.lb_esta_cla.Size = new System.Drawing.Size(255, 17);
            this.lb_esta_cla.TabIndex = 68;
            this.lb_esta_cla.Text = "Está no Clã";
            this.lb_esta_cla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_veio_cla
            // 
            this.lb_veio_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_veio_cla.ForeColor = System.Drawing.Color.White;
            this.lb_veio_cla.Location = new System.Drawing.Point(112, 244);
            this.lb_veio_cla.Name = "lb_veio_cla";
            this.lb_veio_cla.Size = new System.Drawing.Size(238, 17);
            this.lb_veio_cla.TabIndex = 67;
            this.lb_veio_cla.Text = "Veio do Clã";
            this.lb_veio_cla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_poder
            // 
            this.lb_poder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_poder.ForeColor = System.Drawing.Color.White;
            this.lb_poder.Location = new System.Drawing.Point(356, 179);
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
            this.lb_nick.Location = new System.Drawing.Point(112, 179);
            this.lb_nick.Name = "lb_nick";
            this.lb_nick.Size = new System.Drawing.Size(162, 17);
            this.lb_nick.TabIndex = 65;
            this.lb_nick.Text = "Nick";
            this.lb_nick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_excluir
            // 
            this.bt_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_excluir.BackColor = System.Drawing.Color.Red;
            this.bt_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_excluir.FlatAppearance.BorderSize = 0;
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.ForeColor = System.Drawing.Color.White;
            this.bt_excluir.Location = new System.Drawing.Point(643, 7);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(79, 36);
            this.bt_excluir.TabIndex = 64;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            // 
            // txt_data_entrada
            // 
            this.txt_data_entrada.BackColor = System.Drawing.Color.Lavender;
            this.txt_data_entrada.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txt_data_entrada.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_data_entrada.BorderRadius = 0;
            this.txt_data_entrada.BorderSize = 1;
            this.txt_data_entrada.Enabled = false;
            this.txt_data_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_entrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_data_entrada.Location = new System.Drawing.Point(14, 7);
            this.txt_data_entrada.Margin = new System.Windows.Forms.Padding(4);
            this.txt_data_entrada.Multiline = false;
            this.txt_data_entrada.Name = "txt_data_entrada";
            this.txt_data_entrada.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_data_entrada.PasswordChar = false;
            this.txt_data_entrada.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_data_entrada.PlaceholderText = "";
            this.txt_data_entrada.Size = new System.Drawing.Size(111, 31);
            this.txt_data_entrada.TabIndex = 15;
            this.txt_data_entrada.Texts = "";
            this.txt_data_entrada.UnderlinedStyle = false;
            this.txt_data_entrada._TextChanged += new System.EventHandler(this.txt_data_entrada__TextChanged);
            // 
            // foto_classe
            // 
            this.foto_classe.BackColor = System.Drawing.Color.Transparent;
            this.foto_classe.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.foto_classe.BorderColor = System.Drawing.Color.RoyalBlue;
            this.foto_classe.BorderColor2 = System.Drawing.Color.White;
            this.foto_classe.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.foto_classe.BorderSize = 2;
            this.foto_classe.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.foto_classe.GradientAngle = 50F;
            this.foto_classe.Location = new System.Drawing.Point(307, 9);
            this.foto_classe.Name = "foto_classe";
            this.foto_classe.Size = new System.Drawing.Size(110, 110);
            this.foto_classe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto_classe.TabIndex = 14;
            this.foto_classe.TabStop = false;
            // 
            // lb_patente
            // 
            this.lb_patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patente.ForeColor = System.Drawing.Color.White;
            this.lb_patente.Location = new System.Drawing.Point(486, 190);
            this.lb_patente.Name = "lb_patente";
            this.lb_patente.Size = new System.Drawing.Size(126, 17);
            this.lb_patente.TabIndex = 13;
            this.lb_patente.Text = "Patente";
            this.lb_patente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_patente
            // 
            this.txt_patente.BackColor = System.Drawing.Color.White;
            this.txt_patente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_patente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_patente.FormattingEnabled = true;
            this.txt_patente.Items.AddRange(new object[] {
            "Ancião",
            "Égide Sombria",
            "Lider",
            "Membro",
            "Novo Membro"});
            this.txt_patente.Location = new System.Drawing.Point(486, 210);
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.Size = new System.Drawing.Size(126, 21);
            this.txt_patente.TabIndex = 12;
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
            this.txt_nick.Location = new System.Drawing.Point(112, 200);
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
            this.txt_poder.Location = new System.Drawing.Point(357, 200);
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
            this.lb_level.Location = new System.Drawing.Point(281, 179);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(68, 17);
            this.lb_level.TabIndex = 5;
            this.lb_level.Text = "Level";
            this.lb_level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_classe
            // 
            this.lb_classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_classe.ForeColor = System.Drawing.Color.White;
            this.lb_classe.Location = new System.Drawing.Point(298, 122);
            this.lb_classe.Name = "lb_classe";
            this.lb_classe.Size = new System.Drawing.Size(129, 17);
            this.lb_classe.TabIndex = 6;
            this.lb_classe.Text = "Classe";
            this.lb_classe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_classe
            // 
            this.txt_classe.BackColor = System.Drawing.Color.White;
            this.txt_classe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_classe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_classe.FormattingEnabled = true;
            this.txt_classe.Items.AddRange(new object[] {
            "Arbalista",
            "Feiticeira",
            "Guerreiro",
            "Lanceiro",
            "Taoista"});
            this.txt_classe.Location = new System.Drawing.Point(298, 142);
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.Size = new System.Drawing.Size(129, 21);
            this.txt_classe.TabIndex = 9;
            this.txt_classe.SelectedIndexChanged += new System.EventHandler(this.txt_classe_SelectedIndexChanged);
            // 
            // txt_esta_cla
            // 
            this.txt_esta_cla.BackColor = System.Drawing.Color.White;
            this.txt_esta_cla.BorderColor = System.Drawing.Color.White;
            this.txt_esta_cla.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_esta_cla.BorderRadius = 0;
            this.txt_esta_cla.BorderSize = 1;
            this.txt_esta_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_esta_cla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_esta_cla.Location = new System.Drawing.Point(358, 265);
            this.txt_esta_cla.Margin = new System.Windows.Forms.Padding(4);
            this.txt_esta_cla.Multiline = false;
            this.txt_esta_cla.Name = "txt_esta_cla";
            this.txt_esta_cla.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_esta_cla.PasswordChar = false;
            this.txt_esta_cla.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_esta_cla.PlaceholderText = "";
            this.txt_esta_cla.Size = new System.Drawing.Size(254, 31);
            this.txt_esta_cla.TabIndex = 11;
            this.txt_esta_cla.Texts = "";
            this.txt_esta_cla.UnderlinedStyle = false;
            // 
            // txt_veio_cla
            // 
            this.txt_veio_cla.BackColor = System.Drawing.Color.White;
            this.txt_veio_cla.BorderColor = System.Drawing.Color.White;
            this.txt_veio_cla.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_veio_cla.BorderRadius = 0;
            this.txt_veio_cla.BorderSize = 1;
            this.txt_veio_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_veio_cla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_veio_cla.Location = new System.Drawing.Point(112, 265);
            this.txt_veio_cla.Margin = new System.Windows.Forms.Padding(4);
            this.txt_veio_cla.Multiline = false;
            this.txt_veio_cla.Name = "txt_veio_cla";
            this.txt_veio_cla.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_veio_cla.PasswordChar = false;
            this.txt_veio_cla.PlaceholderColor = System.Drawing.Color.Black;
            this.txt_veio_cla.PlaceholderText = "";
            this.txt_veio_cla.Size = new System.Drawing.Size(238, 31);
            this.txt_veio_cla.TabIndex = 10;
            this.txt_veio_cla.Texts = "";
            this.txt_veio_cla.UnderlinedStyle = false;
            // 
            // membros_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(748, 597);
            this.Controls.Add(this.pl_dados);
            this.Controls.Add(this.pl_top);
            this.Name = "membros_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "membros_info";
            this.Load += new System.EventHandler(this.membros_info_Load);
            this.pl_top.ResumeLayout(false);
            this.pl_dados.ResumeLayout(false);
            this.pl_todos.ResumeLayout(false);
            this.pl_botao.ResumeLayout(false);
            this.pl_remanejamento.ResumeLayout(false);
            this.pl_remanejamento.PerformLayout();
            this.pl_membro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foto_classe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Panel pl_dados;
        private System.Windows.Forms.Panel pl_todos;
        private System.Windows.Forms.Panel pl_remanejamento;
        private System.Windows.Forms.Panel pl_membro;
        private script.RJCircularPictureBox foto_classe;
        private painel.RJTextBox txt_nick;
        private painel.RJTextBox txt_poder;
        private System.Windows.Forms.Label lb_level;
        private System.Windows.Forms.Label lb_classe;
        private System.Windows.Forms.ComboBox txt_classe;
        private painel.RJTextBox txt_esta_cla;
        private painel.RJTextBox txt_veio_cla;
        private System.Windows.Forms.Panel pl_botao;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_salvar;
        private painel.RJTextBox txt_data_entrada;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Label lb_remanejamento;
        private painel.RJTextBox txt_vai_cla_rema;
        private painel.RJTextBox txt_esta_cla_rema;
        private System.Windows.Forms.Label lb_patente;
        private System.Windows.Forms.ComboBox txt_patente;
        private painel.RJTextBox txt_data_rema;
        private System.Windows.Forms.Label lb_esta_cla;
        private System.Windows.Forms.Label lb_veio_cla;
        private System.Windows.Forms.Label lb_poder;
        private System.Windows.Forms.Label lb_nick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_data_rema;
        private painel.RJTextBox txt_level;
    }
}