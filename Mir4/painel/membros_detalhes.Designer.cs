
namespace Mir4.painel
{
    partial class membros_detalhes
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
            this.pl_conteudo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_nick = new System.Windows.Forms.TextBox();
            this.txt_classe = new System.Windows.Forms.ComboBox();
            this.txt_nivel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_poder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pl_procurar = new System.Windows.Forms.Panel();
            this.pl_botoes = new System.Windows.Forms.Panel();
            this.bt_novo = new FontAwesome.Sharp.IconButton();
            this.bt_deletar = new FontAwesome.Sharp.IconButton();
            this.bt_editar = new FontAwesome.Sharp.IconButton();
            this.txt_procurar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_procurar = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bt_sair = new System.Windows.Forms.Button();
            this.pl_conteudo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pl_procurar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_conteudo
            // 
            this.pl_conteudo.Controls.Add(this.panel2);
            this.pl_conteudo.Controls.Add(this.panel1);
            this.pl_conteudo.Controls.Add(this.panel3);
            this.pl_conteudo.Controls.Add(this.panel4);
            this.pl_conteudo.Controls.Add(this.pl_botoes);
            this.pl_conteudo.Controls.Add(this.pl_procurar);
            this.pl_conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_conteudo.Location = new System.Drawing.Point(0, 0);
            this.pl_conteudo.Name = "pl_conteudo";
            this.pl_conteudo.Size = new System.Drawing.Size(1200, 720);
            this.pl_conteudo.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.txt_nick);
            this.panel3.Controls.Add(this.txt_classe);
            this.panel3.Controls.Add(this.txt_nivel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_poder);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_nome);
            this.panel3.Controls.Add(this.label1);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(27, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1153, 87);
            this.panel3.TabIndex = 72;
            // 
            // txt_nick
            // 
            this.txt_nick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nick.Location = new System.Drawing.Point(198, 34);
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Size = new System.Drawing.Size(290, 20);
            this.txt_nick.TabIndex = 1;
            // 
            // txt_classe
            // 
            this.txt_classe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_classe.FormattingEnabled = true;
            this.txt_classe.Items.AddRange(new object[] {
            "Besteira",
            "Feiticeira",
            "Guerreiro",
            "Lanceiro",
            "Taoista"});
            this.txt_classe.Location = new System.Drawing.Point(866, 32);
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.Size = new System.Drawing.Size(129, 21);
            this.txt_classe.TabIndex = 7;
            // 
            // txt_nivel
            // 
            this.txt_nivel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nivel.FormattingEnabled = true;
            this.txt_nivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150"});
            this.txt_nivel.Location = new System.Drawing.Point(543, 33);
            this.txt_nivel.Name = "txt_nivel";
            this.txt_nivel.Size = new System.Drawing.Size(69, 21);
            this.txt_nivel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(622, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Poder";
            // 
            // txt_poder
            // 
            this.txt_poder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_poder.Location = new System.Drawing.Point(674, 33);
            this.txt_poder.Name = "txt_poder";
            this.txt_poder.Size = new System.Drawing.Size(126, 20);
            this.txt_poder.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(810, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Classe";
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome.AutoSize = true;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.Black;
            this.txt_nome.Location = new System.Drawing.Point(157, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(35, 17);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.Text = "Nick";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(498, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nivel";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.textBox20);
            this.panel4.Controls.Add(this.textBox19);
            this.panel4.Controls.Add(this.textBox18);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox13);
            this.panel4.Controls.Add(this.textBox14);
            this.panel4.Controls.Add(this.textBox15);
            this.panel4.Controls.Add(this.textBox16);
            this.panel4.Controls.Add(this.textBox9);
            this.panel4.Controls.Add(this.textBox10);
            this.panel4.Controls.Add(this.textBox11);
            this.panel4.Controls.Add(this.textBox12);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.textBox8);
            this.panel4.Location = new System.Drawing.Point(27, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1153, 194);
            this.panel4.TabIndex = 73;
            // 
            // textBox20
            // 
            this.textBox20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox20.Location = new System.Drawing.Point(756, 146);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(132, 20);
            this.textBox20.TabIndex = 74;
            // 
            // textBox19
            // 
            this.textBox19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox19.Location = new System.Drawing.Point(618, 146);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(132, 20);
            this.textBox19.TabIndex = 73;
            // 
            // textBox18
            // 
            this.textBox18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox18.Location = new System.Drawing.Point(480, 146);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(132, 20);
            this.textBox18.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(282, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 71;
            this.label12.Text = "TOTAL";
            // 
            // textBox17
            // 
            this.textBox17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox17.Location = new System.Drawing.Point(3, 143);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(132, 20);
            this.textBox17.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(264, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 69;
            this.label11.Text = "Semana 1";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(264, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 68;
            this.label10.Text = "Semana 1";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(264, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 67;
            this.label9.Text = "Semana 1";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(264, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 66;
            this.label8.Text = "Semana 1";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(802, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "Mês 4";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(667, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Mês 3";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(525, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Mês 2";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mês 1";
            // 
            // textBox13
            // 
            this.textBox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox13.Location = new System.Drawing.Point(756, 120);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(132, 20);
            this.textBox13.TabIndex = 62;
            // 
            // textBox14
            // 
            this.textBox14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox14.Location = new System.Drawing.Point(756, 94);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(132, 20);
            this.textBox14.TabIndex = 61;
            // 
            // textBox15
            // 
            this.textBox15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox15.Location = new System.Drawing.Point(756, 68);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(132, 20);
            this.textBox15.TabIndex = 60;
            // 
            // textBox16
            // 
            this.textBox16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox16.Location = new System.Drawing.Point(756, 42);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(132, 20);
            this.textBox16.TabIndex = 59;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox9.Location = new System.Drawing.Point(618, 120);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(132, 20);
            this.textBox9.TabIndex = 58;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox10.Location = new System.Drawing.Point(618, 94);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(132, 20);
            this.textBox10.TabIndex = 57;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox11.Location = new System.Drawing.Point(618, 68);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(132, 20);
            this.textBox11.TabIndex = 56;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox12.Location = new System.Drawing.Point(618, 42);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(132, 20);
            this.textBox12.TabIndex = 55;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(480, 120);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 20);
            this.textBox5.TabIndex = 54;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.Location = new System.Drawing.Point(480, 94);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 20);
            this.textBox6.TabIndex = 53;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.Location = new System.Drawing.Point(480, 68);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 20);
            this.textBox7.TabIndex = 52;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.Location = new System.Drawing.Point(480, 42);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(132, 20);
            this.textBox8.TabIndex = 51;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(3, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 50;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(3, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 20);
            this.textBox4.TabIndex = 49;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(3, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 48;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(3, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 11;
            // 
            // pl_procurar
            // 
            this.pl_procurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_procurar.Controls.Add(this.bt_procurar);
            this.pl_procurar.Controls.Add(this.txt_procurar);
            this.pl_procurar.Location = new System.Drawing.Point(27, 71);
            this.pl_procurar.Name = "pl_procurar";
            this.pl_procurar.Size = new System.Drawing.Size(1153, 61);
            this.pl_procurar.TabIndex = 70;
            // 
            // pl_botoes
            // 
            this.pl_botoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_botoes.Location = new System.Drawing.Point(27, 17);
            this.pl_botoes.Name = "pl_botoes";
            this.pl_botoes.Size = new System.Drawing.Size(1153, 48);
            this.pl_botoes.TabIndex = 71;
            // 
            // bt_novo
            // 
            this.bt_novo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_novo.BackColor = System.Drawing.Color.YellowGreen;
            this.bt_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_novo.FlatAppearance.BorderSize = 0;
            this.bt_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_novo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo.ForeColor = System.Drawing.Color.White;
            this.bt_novo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.bt_novo.IconColor = System.Drawing.Color.White;
            this.bt_novo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_novo.IconSize = 35;
            this.bt_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_novo.Location = new System.Drawing.Point(346, 12);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_novo.Size = new System.Drawing.Size(120, 40);
            this.bt_novo.TabIndex = 71;
            this.bt_novo.Tag = "";
            this.bt_novo.Text = "Salvar";
            this.bt_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_novo.UseVisualStyleBackColor = false;
            // 
            // bt_deletar
            // 
            this.bt_deletar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_deletar.BackColor = System.Drawing.Color.DarkSalmon;
            this.bt_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_deletar.FlatAppearance.BorderSize = 0;
            this.bt_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_deletar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_deletar.ForeColor = System.Drawing.Color.White;
            this.bt_deletar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.bt_deletar.IconColor = System.Drawing.Color.White;
            this.bt_deletar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_deletar.IconSize = 35;
            this.bt_deletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_deletar.Location = new System.Drawing.Point(598, 12);
            this.bt_deletar.Name = "bt_deletar";
            this.bt_deletar.Size = new System.Drawing.Size(129, 40);
            this.bt_deletar.TabIndex = 72;
            this.bt_deletar.Tag = "";
            this.bt_deletar.Text = "Cancelar";
            this.bt_deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_deletar.UseVisualStyleBackColor = false;
            // 
            // bt_editar
            // 
            this.bt_editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_editar.BackColor = System.Drawing.Color.Gold;
            this.bt_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editar.FlatAppearance.BorderSize = 0;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.bt_editar.IconColor = System.Drawing.Color.White;
            this.bt_editar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_editar.IconSize = 35;
            this.bt_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_editar.Location = new System.Drawing.Point(472, 12);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_editar.Size = new System.Drawing.Size(120, 40);
            this.bt_editar.TabIndex = 73;
            this.bt_editar.Tag = "";
            this.bt_editar.Text = "Editar";
            this.bt_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_editar.UseVisualStyleBackColor = false;
            // 
            // txt_procurar
            // 
            this.txt_procurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_procurar.Location = new System.Drawing.Point(267, 21);
            this.txt_procurar.Name = "txt_procurar";
            this.txt_procurar.Size = new System.Drawing.Size(621, 23);
            this.txt_procurar.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(27, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 147);
            this.panel1.TabIndex = 73;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.bt_sair);
            this.panel2.Controls.Add(this.bt_novo);
            this.panel2.Controls.Add(this.bt_deletar);
            this.panel2.Controls.Add(this.bt_editar);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(27, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 84);
            this.panel2.TabIndex = 74;
            // 
            // bt_procurar
            // 
            this.bt_procurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_procurar.BackColor = System.Drawing.Color.CadetBlue;
            this.bt_procurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_procurar.FlatAppearance.BorderSize = 0;
            this.bt_procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_procurar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_procurar.ForeColor = System.Drawing.Color.White;
            this.bt_procurar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bt_procurar.IconColor = System.Drawing.Color.White;
            this.bt_procurar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_procurar.IconSize = 30;
            this.bt_procurar.Location = new System.Drawing.Point(894, 15);
            this.bt_procurar.Name = "bt_procurar";
            this.bt_procurar.Size = new System.Drawing.Size(116, 33);
            this.bt_procurar.TabIndex = 73;
            this.bt_procurar.Tag = "";
            this.bt_procurar.Text = "Procurar";
            this.bt_procurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_procurar.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.textBox17);
            this.panel5.Location = new System.Drawing.Point(342, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 176);
            this.panel5.TabIndex = 75;
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
            this.bt_sair.Location = new System.Drawing.Point(786, 12);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(102, 36);
            this.bt_sair.TabIndex = 74;
            this.bt_sair.Text = "Cancelar";
            this.bt_sair.UseVisualStyleBackColor = false;
            // 
            // membros_detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_conteudo);
            this.Name = "membros_detalhes";
            this.Size = new System.Drawing.Size(1200, 720);
            this.pl_conteudo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pl_procurar.ResumeLayout(false);
            this.pl_procurar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_conteudo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_nick;
        private System.Windows.Forms.ComboBox txt_classe;
        private System.Windows.Forms.ComboBox txt_nivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_poder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pl_botoes;
        private System.Windows.Forms.Panel pl_procurar;
        private FontAwesome.Sharp.IconButton bt_novo;
        private FontAwesome.Sharp.IconButton bt_deletar;
        private FontAwesome.Sharp.IconButton bt_editar;
        private System.Windows.Forms.TextBox txt_procurar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton bt_procurar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bt_sair;
    }
}
