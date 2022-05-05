
namespace Mir4
{
    partial class cla
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
            this.components = new System.ComponentModel.Container();
            this.lb_nick = new System.Windows.Forms.Label();
            this.lb_nome_do_cla = new System.Windows.Forms.Label();
            this.lb_patente = new System.Windows.Forms.Label();
            this.pl_menu = new System.Windows.Forms.Panel();
            this.pl_conta = new System.Windows.Forms.Panel();
            this.bt_menu = new FontAwesome.Sharp.IconButton();
            this.pl_conf = new System.Windows.Forms.Panel();
            this.bt_configurar = new FontAwesome.Sharp.IconButton();
            this.bt_deslogar = new FontAwesome.Sharp.IconButton();
            this.bt_gold = new FontAwesome.Sharp.IconButton();
            this.bt_painel = new FontAwesome.Sharp.IconButton();
            this.bt_membros = new FontAwesome.Sharp.IconButton();
            this.bt_cadastro = new FontAwesome.Sharp.IconButton();
            this.pl_top = new System.Windows.Forms.Panel();
            this.pl_nome_cla = new System.Windows.Forms.Panel();
            this.bt_maximizar = new System.Windows.Forms.Button();
            this.bt_minimizar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.pl_centro = new System.Windows.Forms.Panel();
            this.pl_conteudo = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.foto_perfil = new Mir4.script.RJCircularPictureBox();
            this.pl_menu.SuspendLayout();
            this.pl_conta.SuspendLayout();
            this.pl_conf.SuspendLayout();
            this.pl_top.SuspendLayout();
            this.pl_nome_cla.SuspendLayout();
            this.pl_centro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nick
            // 
            this.lb_nick.AutoSize = true;
            this.lb_nick.BackColor = System.Drawing.Color.Transparent;
            this.lb_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nick.ForeColor = System.Drawing.Color.White;
            this.lb_nick.Location = new System.Drawing.Point(50, 107);
            this.lb_nick.Name = "lb_nick";
            this.lb_nick.Size = new System.Drawing.Size(107, 20);
            this.lb_nick.TabIndex = 48;
            this.lb_nick.Text = "Andy Makler";
            // 
            // lb_nome_do_cla
            // 
            this.lb_nome_do_cla.AutoSize = true;
            this.lb_nome_do_cla.BackColor = System.Drawing.Color.Transparent;
            this.lb_nome_do_cla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_do_cla.ForeColor = System.Drawing.Color.White;
            this.lb_nome_do_cla.Location = new System.Drawing.Point(13, 5);
            this.lb_nome_do_cla.Name = "lb_nome_do_cla";
            this.lb_nome_do_cla.Size = new System.Drawing.Size(75, 20);
            this.lb_nome_do_cla.TabIndex = 51;
            this.lb_nome_do_cla.Text = "HYPE ツ";
            // 
            // lb_patente
            // 
            this.lb_patente.AutoSize = true;
            this.lb_patente.BackColor = System.Drawing.Color.Transparent;
            this.lb_patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patente.ForeColor = System.Drawing.Color.Gray;
            this.lb_patente.Location = new System.Drawing.Point(75, 127);
            this.lb_patente.Name = "lb_patente";
            this.lb_patente.Size = new System.Drawing.Size(49, 20);
            this.lb_patente.TabIndex = 50;
            this.lb_patente.Text = "Lider";
            // 
            // pl_menu
            // 
            this.pl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_menu.Controls.Add(this.pl_conta);
            this.pl_menu.Controls.Add(this.pl_conf);
            this.pl_menu.Controls.Add(this.bt_gold);
            this.pl_menu.Controls.Add(this.bt_painel);
            this.pl_menu.Controls.Add(this.bt_membros);
            this.pl_menu.Controls.Add(this.bt_cadastro);
            this.pl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_menu.Location = new System.Drawing.Point(0, 0);
            this.pl_menu.Name = "pl_menu";
            this.pl_menu.Size = new System.Drawing.Size(210, 783);
            this.pl_menu.TabIndex = 51;
            // 
            // pl_conta
            // 
            this.pl_conta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_conta.Controls.Add(this.foto_perfil);
            this.pl_conta.Controls.Add(this.bt_menu);
            this.pl_conta.Controls.Add(this.lb_patente);
            this.pl_conta.Controls.Add(this.lb_nick);
            this.pl_conta.Location = new System.Drawing.Point(-2, 1);
            this.pl_conta.Name = "pl_conta";
            this.pl_conta.Size = new System.Drawing.Size(206, 157);
            this.pl_conta.TabIndex = 0;
            // 
            // bt_menu
            // 
            this.bt_menu.FlatAppearance.BorderSize = 0;
            this.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_menu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.bt_menu.IconColor = System.Drawing.Color.White;
            this.bt_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_menu.IconSize = 30;
            this.bt_menu.Location = new System.Drawing.Point(165, 7);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(44, 33);
            this.bt_menu.TabIndex = 52;
            this.bt_menu.Tag = "";
            this.bt_menu.UseVisualStyleBackColor = true;
            this.bt_menu.Click += new System.EventHandler(this.bt_menu_Click);
            // 
            // pl_conf
            // 
            this.pl_conf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_conf.Controls.Add(this.bt_configurar);
            this.pl_conf.Controls.Add(this.bt_deslogar);
            this.pl_conf.Location = new System.Drawing.Point(0, 737);
            this.pl_conf.Name = "pl_conf";
            this.pl_conf.Size = new System.Drawing.Size(207, 43);
            this.pl_conf.TabIndex = 0;
            // 
            // bt_configurar
            // 
            this.bt_configurar.AccessibleName = "";
            this.bt_configurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_configurar.BackColor = System.Drawing.Color.Transparent;
            this.bt_configurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_configurar.FlatAppearance.BorderSize = 0;
            this.bt_configurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_configurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_configurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_configurar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_configurar.ForeColor = System.Drawing.Color.White;
            this.bt_configurar.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.bt_configurar.IconColor = System.Drawing.Color.White;
            this.bt_configurar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_configurar.IconSize = 35;
            this.bt_configurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_configurar.Location = new System.Drawing.Point(6, 4);
            this.bt_configurar.Name = "bt_configurar";
            this.bt_configurar.Size = new System.Drawing.Size(40, 36);
            this.bt_configurar.TabIndex = 58;
            this.bt_configurar.Tag = "";
            this.bt_configurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bt_configurar, "Configuração");
            this.bt_configurar.UseVisualStyleBackColor = false;
            this.bt_configurar.Click += new System.EventHandler(this.bt_configurar_Click);
            // 
            // bt_deslogar
            // 
            this.bt_deslogar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_deslogar.BackColor = System.Drawing.Color.Transparent;
            this.bt_deslogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_deslogar.FlatAppearance.BorderSize = 0;
            this.bt_deslogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_deslogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_deslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_deslogar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_deslogar.ForeColor = System.Drawing.Color.White;
            this.bt_deslogar.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.bt_deslogar.IconColor = System.Drawing.Color.White;
            this.bt_deslogar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_deslogar.IconSize = 35;
            this.bt_deslogar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_deslogar.Location = new System.Drawing.Point(159, 3);
            this.bt_deslogar.Name = "bt_deslogar";
            this.bt_deslogar.Size = new System.Drawing.Size(44, 36);
            this.bt_deslogar.TabIndex = 60;
            this.bt_deslogar.Tag = "";
            this.bt_deslogar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.bt_deslogar, "Sair");
            this.bt_deslogar.UseVisualStyleBackColor = false;
            // 
            // bt_gold
            // 
            this.bt_gold.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_gold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_gold.FlatAppearance.BorderSize = 0;
            this.bt_gold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gold.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gold.ForeColor = System.Drawing.Color.White;
            this.bt_gold.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.bt_gold.IconColor = System.Drawing.Color.White;
            this.bt_gold.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_gold.IconSize = 35;
            this.bt_gold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gold.Location = new System.Drawing.Point(-1, 332);
            this.bt_gold.Name = "bt_gold";
            this.bt_gold.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_gold.Size = new System.Drawing.Size(193, 46);
            this.bt_gold.TabIndex = 56;
            this.bt_gold.Tag = "Doações";
            this.bt_gold.Text = "Doações";
            this.bt_gold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_gold.UseVisualStyleBackColor = false;
            this.bt_gold.Click += new System.EventHandler(this.bt_gold_Click);
            // 
            // bt_painel
            // 
            this.bt_painel.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_painel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_painel.FlatAppearance.BorderSize = 0;
            this.bt_painel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_painel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_painel.ForeColor = System.Drawing.Color.White;
            this.bt_painel.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.bt_painel.IconColor = System.Drawing.Color.White;
            this.bt_painel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_painel.IconSize = 35;
            this.bt_painel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_painel.Location = new System.Drawing.Point(-1, 176);
            this.bt_painel.Name = "bt_painel";
            this.bt_painel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_painel.Size = new System.Drawing.Size(193, 46);
            this.bt_painel.TabIndex = 55;
            this.bt_painel.Tag = "Painel";
            this.bt_painel.Text = "Painel";
            this.bt_painel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_painel.UseVisualStyleBackColor = false;
            this.bt_painel.Click += new System.EventHandler(this.bt_painel_Click);
            // 
            // bt_membros
            // 
            this.bt_membros.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_membros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_membros.FlatAppearance.BorderSize = 0;
            this.bt_membros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_membros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_membros.ForeColor = System.Drawing.Color.White;
            this.bt_membros.IconChar = FontAwesome.Sharp.IconChar.User;
            this.bt_membros.IconColor = System.Drawing.Color.White;
            this.bt_membros.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_membros.IconSize = 35;
            this.bt_membros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_membros.Location = new System.Drawing.Point(-1, 228);
            this.bt_membros.Name = "bt_membros";
            this.bt_membros.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_membros.Size = new System.Drawing.Size(193, 46);
            this.bt_membros.TabIndex = 54;
            this.bt_membros.Tag = "Membros";
            this.bt_membros.Text = "Membros";
            this.bt_membros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_membros.UseVisualStyleBackColor = false;
            this.bt_membros.Click += new System.EventHandler(this.bt_membros_Click);
            // 
            // bt_cadastro
            // 
            this.bt_cadastro.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastro.FlatAppearance.BorderSize = 0;
            this.bt_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastro.ForeColor = System.Drawing.Color.White;
            this.bt_cadastro.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.bt_cadastro.IconColor = System.Drawing.Color.White;
            this.bt_cadastro.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_cadastro.IconSize = 35;
            this.bt_cadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cadastro.Location = new System.Drawing.Point(-1, 280);
            this.bt_cadastro.Name = "bt_cadastro";
            this.bt_cadastro.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_cadastro.Size = new System.Drawing.Size(193, 46);
            this.bt_cadastro.TabIndex = 53;
            this.bt_cadastro.Tag = "Cadastro";
            this.bt_cadastro.Text = "Cadastro";
            this.bt_cadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_cadastro.UseVisualStyleBackColor = false;
            this.bt_cadastro.Click += new System.EventHandler(this.bt_cadastro_Click);
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.pl_top.Controls.Add(this.pl_nome_cla);
            this.pl_top.Controls.Add(this.bt_maximizar);
            this.pl_top.Controls.Add(this.bt_minimizar);
            this.pl_top.Controls.Add(this.bt_fechar);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(210, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1085, 54);
            this.pl_top.TabIndex = 0;
            this.pl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_top_MouseDown);
            // 
            // pl_nome_cla
            // 
            this.pl_nome_cla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_nome_cla.Controls.Add(this.lb_nome_do_cla);
            this.pl_nome_cla.Location = new System.Drawing.Point(842, 8);
            this.pl_nome_cla.Name = "pl_nome_cla";
            this.pl_nome_cla.Size = new System.Drawing.Size(102, 33);
            this.pl_nome_cla.TabIndex = 47;
            // 
            // bt_maximizar
            // 
            this.bt_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_maximizar.BackColor = System.Drawing.Color.Gray;
            this.bt_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_maximizar.FlatAppearance.BorderSize = 0;
            this.bt_maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.bt_maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_maximizar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_maximizar.ForeColor = System.Drawing.Color.White;
            this.bt_maximizar.Location = new System.Drawing.Point(1013, 6);
            this.bt_maximizar.Name = "bt_maximizar";
            this.bt_maximizar.Size = new System.Drawing.Size(27, 26);
            this.bt_maximizar.TabIndex = 46;
            this.bt_maximizar.Text = "❐";
            this.bt_maximizar.UseVisualStyleBackColor = false;
            this.bt_maximizar.Click += new System.EventHandler(this.bt_maximizar_Click);
            // 
            // bt_minimizar
            // 
            this.bt_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_minimizar.BackColor = System.Drawing.Color.Gray;
            this.bt_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_minimizar.FlatAppearance.BorderSize = 0;
            this.bt_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.bt_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimizar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minimizar.ForeColor = System.Drawing.Color.White;
            this.bt_minimizar.Location = new System.Drawing.Point(980, 6);
            this.bt_minimizar.Name = "bt_minimizar";
            this.bt_minimizar.Size = new System.Drawing.Size(27, 26);
            this.bt_minimizar.TabIndex = 45;
            this.bt_minimizar.Text = "🗕";
            this.bt_minimizar.UseVisualStyleBackColor = false;
            this.bt_minimizar.Click += new System.EventHandler(this.bt_minimizar_Click);
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
            this.bt_fechar.Location = new System.Drawing.Point(1046, 6);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(27, 26);
            this.bt_fechar.TabIndex = 44;
            this.bt_fechar.Text = "X";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // pl_centro
            // 
            this.pl_centro.BackColor = System.Drawing.Color.White;
            this.pl_centro.Controls.Add(this.panel4);
            this.pl_centro.Controls.Add(this.pl_conteudo);
            this.pl_centro.Controls.Add(this.panel5);
            this.pl_centro.Controls.Add(this.panel3);
            this.pl_centro.Controls.Add(this.panel2);
            this.pl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_centro.Location = new System.Drawing.Point(210, 0);
            this.pl_centro.Name = "pl_centro";
            this.pl_centro.Size = new System.Drawing.Size(1085, 783);
            this.pl_centro.TabIndex = 53;
            // 
            // pl_conteudo
            // 
            this.pl_conteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_conteudo.Location = new System.Drawing.Point(70, 0);
            this.pl_conteudo.Name = "pl_conteudo";
            this.pl_conteudo.Size = new System.Drawing.Size(945, 733);
            this.pl_conteudo.TabIndex = 49;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(70, 733);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(945, 50);
            this.panel5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(70, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(945, 100);
            this.panel4.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1015, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 783);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 783);
            this.panel2.TabIndex = 0;
            // 
            // foto_perfil
            // 
            this.foto_perfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.foto_perfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.foto_perfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.foto_perfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.foto_perfil.BorderSize = 2;
            this.foto_perfil.GradientAngle = 50F;
            this.foto_perfil.Location = new System.Drawing.Point(53, 7);
            this.foto_perfil.Name = "foto_perfil";
            this.foto_perfil.Size = new System.Drawing.Size(94, 94);
            this.foto_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto_perfil.TabIndex = 0;
            this.foto_perfil.TabStop = false;
            // 
            // cla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1295, 783);
            this.Controls.Add(this.pl_top);
            this.Controls.Add(this.pl_centro);
            this.Controls.Add(this.pl_menu);
            this.Name = "cla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pl_menu.ResumeLayout(false);
            this.pl_conta.ResumeLayout(false);
            this.pl_conta.PerformLayout();
            this.pl_conf.ResumeLayout(false);
            this.pl_top.ResumeLayout(false);
            this.pl_nome_cla.ResumeLayout(false);
            this.pl_nome_cla.PerformLayout();
            this.pl_centro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_nick;
        private System.Windows.Forms.Label lb_patente;
        private System.Windows.Forms.Panel pl_menu;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_minimizar;
        private System.Windows.Forms.Label lb_nome_do_cla;
        private System.Windows.Forms.Button bt_maximizar;
        private System.Windows.Forms.Panel pl_centro;
        private FontAwesome.Sharp.IconButton bt_cadastro;
        private FontAwesome.Sharp.IconButton bt_configurar;
        private FontAwesome.Sharp.IconButton bt_gold;
        private FontAwesome.Sharp.IconButton bt_painel;
        private FontAwesome.Sharp.IconButton bt_membros;
        private FontAwesome.Sharp.IconButton bt_menu;
        private FontAwesome.Sharp.IconButton bt_deslogar;
        private System.Windows.Forms.ToolTip toolTip1;
        private script.RJCircularPictureBox foto_perfil;
        private System.Windows.Forms.Panel pl_conf;
        private System.Windows.Forms.Panel pl_conta;
        private System.Windows.Forms.Panel pl_nome_cla;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pl_conteudo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}