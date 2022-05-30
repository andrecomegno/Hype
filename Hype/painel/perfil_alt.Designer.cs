
namespace Hype.painel
{
    partial class perfil_alt
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
            this.pl_remanejamento = new System.Windows.Forms.Panel();
            this.lb_data_rema = new System.Windows.Forms.Label();
            this.lb_vai_para_cla = new System.Windows.Forms.Label();
            this.lb_esta_no_cla = new System.Windows.Forms.Label();
            this.pl_pergunta = new System.Windows.Forms.Panel();
            this.rd_nao = new System.Windows.Forms.RadioButton();
            this.rd_sim = new System.Windows.Forms.RadioButton();
            this.lb_remanejamento = new System.Windows.Forms.Label();
            this.pl_botao = new System.Windows.Forms.Panel();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.pl_membro = new System.Windows.Forms.Panel();
            this.lb_data_entrada = new System.Windows.Forms.Label();
            this.lb_esta_cla = new System.Windows.Forms.Label();
            this.lb_poder = new System.Windows.Forms.Label();
            this.lb_nick = new System.Windows.Forms.Label();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.lb_level = new System.Windows.Forms.Label();
            this.lb_classe = new System.Windows.Forms.Label();
            this.txt_classe = new System.Windows.Forms.ComboBox();
            this.txt_data_rema = new Hype.painel.RJTextBox();
            this.txt_vai_cla_rema = new Hype.painel.RJTextBox();
            this.txt_esta_cla_rema = new Hype.painel.RJTextBox();
            this.txt_level = new Hype.painel.RJTextBox();
            this.foto_classe = new Hype.script.RJCircularPictureBox();
            this.txt_nick = new Hype.painel.RJTextBox();
            this.txt_poder = new Hype.painel.RJTextBox();
            this.txt_esta_cla = new Hype.painel.RJTextBox();
            this.lb_nick_main = new System.Windows.Forms.Label();
            this.pl_todos.SuspendLayout();
            this.pl_remanejamento.SuspendLayout();
            this.pl_pergunta.SuspendLayout();
            this.pl_botao.SuspendLayout();
            this.pl_membro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_classe)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_todos
            // 
            this.pl_todos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_todos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_todos.Controls.Add(this.pl_remanejamento);
            this.pl_todos.Controls.Add(this.pl_pergunta);
            this.pl_todos.Controls.Add(this.pl_botao);
            this.pl_todos.Controls.Add(this.pl_membro);
            this.pl_todos.Location = new System.Drawing.Point(20, 46);
            this.pl_todos.Name = "pl_todos";
            this.pl_todos.Size = new System.Drawing.Size(725, 534);
            this.pl_todos.TabIndex = 24;
            // 
            // pl_remanejamento
            // 
            this.pl_remanejamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_remanejamento.Controls.Add(this.lb_data_rema);
            this.pl_remanejamento.Controls.Add(this.lb_vai_para_cla);
            this.pl_remanejamento.Controls.Add(this.lb_esta_no_cla);
            this.pl_remanejamento.Controls.Add(this.txt_data_rema);
            this.pl_remanejamento.Controls.Add(this.txt_vai_cla_rema);
            this.pl_remanejamento.Controls.Add(this.txt_esta_cla_rema);
            this.pl_remanejamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_remanejamento.Location = new System.Drawing.Point(0, 377);
            this.pl_remanejamento.Name = "pl_remanejamento";
            this.pl_remanejamento.Size = new System.Drawing.Size(725, 100);
            this.pl_remanejamento.TabIndex = 19;
            this.pl_remanejamento.Visible = false;
            // 
            // lb_data_rema
            // 
            this.lb_data_rema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_rema.ForeColor = System.Drawing.Color.White;
            this.lb_data_rema.Location = new System.Drawing.Point(53, 26);
            this.lb_data_rema.Name = "lb_data_rema";
            this.lb_data_rema.Size = new System.Drawing.Size(111, 17);
            this.lb_data_rema.TabIndex = 69;
            this.lb_data_rema.Text = "Data";
            this.lb_data_rema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_vai_para_cla
            // 
            this.lb_vai_para_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vai_para_cla.ForeColor = System.Drawing.Color.White;
            this.lb_vai_para_cla.Location = new System.Drawing.Point(416, 26);
            this.lb_vai_para_cla.Name = "lb_vai_para_cla";
            this.lb_vai_para_cla.Size = new System.Drawing.Size(256, 17);
            this.lb_vai_para_cla.TabIndex = 70;
            this.lb_vai_para_cla.Text = "Vai para o Clã";
            this.lb_vai_para_cla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_esta_no_cla
            // 
            this.lb_esta_no_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_esta_no_cla.ForeColor = System.Drawing.Color.White;
            this.lb_esta_no_cla.Location = new System.Drawing.Point(172, 26);
            this.lb_esta_no_cla.Name = "lb_esta_no_cla";
            this.lb_esta_no_cla.Size = new System.Drawing.Size(238, 17);
            this.lb_esta_no_cla.TabIndex = 69;
            this.lb_esta_no_cla.Text = "Está no Clã";
            this.lb_esta_no_cla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_pergunta
            // 
            this.pl_pergunta.Controls.Add(this.rd_nao);
            this.pl_pergunta.Controls.Add(this.rd_sim);
            this.pl_pergunta.Controls.Add(this.lb_remanejamento);
            this.pl_pergunta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_pergunta.Location = new System.Drawing.Point(0, 322);
            this.pl_pergunta.Name = "pl_pergunta";
            this.pl_pergunta.Size = new System.Drawing.Size(725, 55);
            this.pl_pergunta.TabIndex = 65;
            // 
            // rd_nao
            // 
            this.rd_nao.AutoSize = true;
            this.rd_nao.Checked = true;
            this.rd_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nao.ForeColor = System.Drawing.Color.White;
            this.rd_nao.Location = new System.Drawing.Point(420, 15);
            this.rd_nao.Name = "rd_nao";
            this.rd_nao.Size = new System.Drawing.Size(64, 24);
            this.rd_nao.TabIndex = 72;
            this.rd_nao.TabStop = true;
            this.rd_nao.Text = "NÃO";
            this.rd_nao.UseVisualStyleBackColor = true;
            this.rd_nao.CheckedChanged += new System.EventHandler(this.rd_nao_CheckedChanged);
            // 
            // rd_sim
            // 
            this.rd_sim.AutoSize = true;
            this.rd_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_sim.ForeColor = System.Drawing.Color.White;
            this.rd_sim.Location = new System.Drawing.Point(358, 15);
            this.rd_sim.Name = "rd_sim";
            this.rd_sim.Size = new System.Drawing.Size(59, 24);
            this.rd_sim.TabIndex = 71;
            this.rd_sim.Text = "SIM";
            this.rd_sim.UseVisualStyleBackColor = true;
            this.rd_sim.CheckedChanged += new System.EventHandler(this.rd_sim_CheckedChanged);
            // 
            // lb_remanejamento
            // 
            this.lb_remanejamento.AutoSize = true;
            this.lb_remanejamento.BackColor = System.Drawing.Color.Transparent;
            this.lb_remanejamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_remanejamento.ForeColor = System.Drawing.Color.White;
            this.lb_remanejamento.Location = new System.Drawing.Point(214, 16);
            this.lb_remanejamento.Name = "lb_remanejamento";
            this.lb_remanejamento.Size = new System.Drawing.Size(140, 20);
            this.lb_remanejamento.TabIndex = 65;
            this.lb_remanejamento.Text = "Remanejamento";
            this.lb_remanejamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_botao
            // 
            this.pl_botao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_botao.Controls.Add(this.bt_cancelar);
            this.pl_botao.Controls.Add(this.bt_salvar);
            this.pl_botao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_botao.Location = new System.Drawing.Point(0, 483);
            this.pl_botao.Name = "pl_botao";
            this.pl_botao.Size = new System.Drawing.Size(725, 51);
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
            this.bt_cancelar.Location = new System.Drawing.Point(600, 12);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 36);
            this.bt_cancelar.TabIndex = 62;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
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
            this.bt_salvar.Location = new System.Drawing.Point(467, 12);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(122, 36);
            this.bt_salvar.TabIndex = 63;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // pl_membro
            // 
            this.pl_membro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_membro.Controls.Add(this.lb_nick_main);
            this.pl_membro.Controls.Add(this.lb_data_entrada);
            this.pl_membro.Controls.Add(this.txt_level);
            this.pl_membro.Controls.Add(this.lb_esta_cla);
            this.pl_membro.Controls.Add(this.lb_poder);
            this.pl_membro.Controls.Add(this.lb_nick);
            this.pl_membro.Controls.Add(this.bt_excluir);
            this.pl_membro.Controls.Add(this.foto_classe);
            this.pl_membro.Controls.Add(this.txt_nick);
            this.pl_membro.Controls.Add(this.txt_poder);
            this.pl_membro.Controls.Add(this.lb_level);
            this.pl_membro.Controls.Add(this.lb_classe);
            this.pl_membro.Controls.Add(this.txt_classe);
            this.pl_membro.Controls.Add(this.txt_esta_cla);
            this.pl_membro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_membro.Location = new System.Drawing.Point(0, 0);
            this.pl_membro.Name = "pl_membro";
            this.pl_membro.Size = new System.Drawing.Size(725, 322);
            this.pl_membro.TabIndex = 18;
            // 
            // lb_data_entrada
            // 
            this.lb_data_entrada.AutoSize = true;
            this.lb_data_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_entrada.ForeColor = System.Drawing.Color.White;
            this.lb_data_entrada.Location = new System.Drawing.Point(17, 15);
            this.lb_data_entrada.Name = "lb_data_entrada";
            this.lb_data_entrada.Size = new System.Drawing.Size(99, 20);
            this.lb_data_entrada.TabIndex = 70;
            this.lb_data_entrada.Text = "00/00/0000";
            // 
            // lb_esta_cla
            // 
            this.lb_esta_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_esta_cla.ForeColor = System.Drawing.Color.White;
            this.lb_esta_cla.Location = new System.Drawing.Point(430, 207);
            this.lb_esta_cla.Name = "lb_esta_cla";
            this.lb_esta_cla.Size = new System.Drawing.Size(254, 17);
            this.lb_esta_cla.TabIndex = 68;
            this.lb_esta_cla.Text = "Está no Clã";
            this.lb_esta_cla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_poder
            // 
            this.lb_poder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_poder.ForeColor = System.Drawing.Color.White;
            this.lb_poder.Location = new System.Drawing.Point(302, 207);
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
            this.lb_nick.Location = new System.Drawing.Point(58, 207);
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
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // lb_level
            // 
            this.lb_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_level.ForeColor = System.Drawing.Color.White;
            this.lb_level.Location = new System.Drawing.Point(227, 207);
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
            this.lb_classe.Location = new System.Drawing.Point(298, 140);
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
            this.txt_classe.Location = new System.Drawing.Point(298, 160);
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.Size = new System.Drawing.Size(129, 21);
            this.txt_classe.TabIndex = 9;
            // 
            // txt_data_rema
            // 
            this.txt_data_rema.BackColor = System.Drawing.Color.Lavender;
            this.txt_data_rema.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txt_data_rema.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_data_rema.BorderRadius = 0;
            this.txt_data_rema.BorderSize = 1;
            this.txt_data_rema.Enabled = false;
            this.txt_data_rema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_rema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_data_rema.Location = new System.Drawing.Point(53, 47);
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
            // txt_vai_cla_rema
            // 
            this.txt_vai_cla_rema.BackColor = System.Drawing.Color.White;
            this.txt_vai_cla_rema.BorderColor = System.Drawing.Color.White;
            this.txt_vai_cla_rema.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_vai_cla_rema.BorderRadius = 0;
            this.txt_vai_cla_rema.BorderSize = 1;
            this.txt_vai_cla_rema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vai_cla_rema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_vai_cla_rema.Location = new System.Drawing.Point(418, 47);
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
            this.txt_esta_cla_rema.BackColor = System.Drawing.Color.Lavender;
            this.txt_esta_cla_rema.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txt_esta_cla_rema.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_esta_cla_rema.BorderRadius = 0;
            this.txt_esta_cla_rema.BorderSize = 1;
            this.txt_esta_cla_rema.Enabled = false;
            this.txt_esta_cla_rema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_esta_cla_rema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_esta_cla_rema.Location = new System.Drawing.Point(172, 47);
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
            this.txt_level.Location = new System.Drawing.Point(227, 228);
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
            this.foto_classe.Location = new System.Drawing.Point(307, 27);
            this.foto_classe.Name = "foto_classe";
            this.foto_classe.Size = new System.Drawing.Size(110, 110);
            this.foto_classe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto_classe.TabIndex = 14;
            this.foto_classe.TabStop = false;
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
            this.txt_nick.Location = new System.Drawing.Point(58, 228);
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
            this.txt_poder.Location = new System.Drawing.Point(303, 228);
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
            // txt_esta_cla
            // 
            this.txt_esta_cla.BackColor = System.Drawing.Color.Lavender;
            this.txt_esta_cla.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txt_esta_cla.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.txt_esta_cla.BorderRadius = 0;
            this.txt_esta_cla.BorderSize = 1;
            this.txt_esta_cla.Enabled = false;
            this.txt_esta_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_esta_cla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_esta_cla.Location = new System.Drawing.Point(430, 228);
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
            // lb_nick_main
            // 
            this.lb_nick_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nick_main.ForeColor = System.Drawing.Color.White;
            this.lb_nick_main.Location = new System.Drawing.Point(58, 263);
            this.lb_nick_main.Name = "lb_nick_main";
            this.lb_nick_main.Size = new System.Drawing.Size(162, 17);
            this.lb_nick_main.TabIndex = 71;
            this.lb_nick_main.Text = "Nick";
            this.lb_nick_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // perfil_alt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.pl_todos);
            this.Name = "perfil_alt";
            this.Size = new System.Drawing.Size(764, 627);
            this.Load += new System.EventHandler(this.perfil_alt_Load);
            this.pl_todos.ResumeLayout(false);
            this.pl_remanejamento.ResumeLayout(false);
            this.pl_pergunta.ResumeLayout(false);
            this.pl_pergunta.PerformLayout();
            this.pl_botao.ResumeLayout(false);
            this.pl_membro.ResumeLayout(false);
            this.pl_membro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_classe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_todos;
        private System.Windows.Forms.Panel pl_remanejamento;
        private System.Windows.Forms.Label lb_data_rema;
        private System.Windows.Forms.Label lb_vai_para_cla;
        private System.Windows.Forms.Label lb_esta_no_cla;
        private RJTextBox txt_data_rema;
        private RJTextBox txt_vai_cla_rema;
        private RJTextBox txt_esta_cla_rema;
        private System.Windows.Forms.Panel pl_pergunta;
        private System.Windows.Forms.RadioButton rd_nao;
        private System.Windows.Forms.RadioButton rd_sim;
        private System.Windows.Forms.Label lb_remanejamento;
        private System.Windows.Forms.Panel pl_botao;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Panel pl_membro;
        private System.Windows.Forms.Label lb_data_entrada;
        private RJTextBox txt_level;
        private System.Windows.Forms.Label lb_esta_cla;
        private System.Windows.Forms.Label lb_poder;
        private System.Windows.Forms.Label lb_nick;
        private System.Windows.Forms.Button bt_excluir;
        private script.RJCircularPictureBox foto_classe;
        private RJTextBox txt_nick;
        private RJTextBox txt_poder;
        private System.Windows.Forms.Label lb_level;
        private System.Windows.Forms.Label lb_classe;
        private System.Windows.Forms.ComboBox txt_classe;
        private RJTextBox txt_esta_cla;
        private System.Windows.Forms.Label lb_nick_main;
    }
}
