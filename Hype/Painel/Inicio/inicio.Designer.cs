
namespace Hype.Painel
{
    partial class inicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pl_inicio = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart_membros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart_progressao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_progressao = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pl_inicio.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_membros)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_progressao)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_inicio
            // 
            this.pl_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_inicio.Controls.Add(this.panel6);
            this.pl_inicio.Controls.Add(this.panel5);
            this.pl_inicio.Controls.Add(this.panel4);
            this.pl_inicio.Controls.Add(this.panel3);
            this.pl_inicio.Controls.Add(this.panel2);
            this.pl_inicio.Controls.Add(this.panel1);
            this.pl_inicio.Location = new System.Drawing.Point(14, 3);
            this.pl_inicio.Name = "pl_inicio";
            this.pl_inicio.Size = new System.Drawing.Size(1172, 1008);
            this.pl_inicio.TabIndex = 78;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel3.Controls.Add(this.chart_membros);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(22, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1124, 268);
            this.panel3.TabIndex = 100;
            // 
            // chart_membros
            // 
            chartArea11.Name = "ChartArea1";
            this.chart_membros.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart_membros.Legends.Add(legend11);
            this.chart_membros.Location = new System.Drawing.Point(8, 41);
            this.chart_membros.Name = "chart_membros";
            this.chart_membros.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series11.Legend = "Legend1";
            series11.Name = "MEMBROS";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series11.YValuesPerPoint = 30;
            this.chart_membros.Series.Add(series11);
            this.chart_membros.Size = new System.Drawing.Size(1106, 210);
            this.chart_membros.TabIndex = 100;
            this.chart_membros.Text = "chart3";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1118, 31);
            this.label2.TabIndex = 98;
            this.label2.Text = "MEMBROS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.chart_progressao);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(602, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 473);
            this.panel2.TabIndex = 100;
            // 
            // chart_progressao
            // 
            chartArea12.Name = "ChartArea1";
            this.chart_progressao.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart_progressao.Legends.Add(legend12);
            this.chart_progressao.Location = new System.Drawing.Point(8, 41);
            this.chart_progressao.Name = "chart_progressao";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            series12.YValuesPerPoint = 6;
            this.chart_progressao.Series.Add(series12);
            this.chart_progressao.Size = new System.Drawing.Size(526, 421);
            this.chart_progressao.TabIndex = 99;
            this.chart_progressao.Text = "chart2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 31);
            this.label1.TabIndex = 98;
            this.label1.Text = "PROGRESSÃO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.lb_progressao);
            this.panel1.Location = new System.Drawing.Point(22, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 473);
            this.panel1.TabIndex = 0;
            // 
            // lb_progressao
            // 
            this.lb_progressao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_progressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_progressao.ForeColor = System.Drawing.Color.White;
            this.lb_progressao.Location = new System.Drawing.Point(3, 7);
            this.lb_progressao.Name = "lb_progressao";
            this.lb_progressao.Size = new System.Drawing.Size(538, 31);
            this.lb_progressao.TabIndex = 98;
            this.lb_progressao.Text = "DOAÇÕES";
            this.lb_progressao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(421, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 135);
            this.panel4.TabIndex = 101;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(22, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(329, 135);
            this.panel5.TabIndex = 102;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(814, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(329, 135);
            this.panel6.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 59);
            this.label3.TabIndex = 101;
            this.label3.Text = "QT MEMBRO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 59);
            this.label4.TabIndex = 102;
            this.label4.Text = "QT DOAÇÃO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 59);
            this.label5.TabIndex = 103;
            this.label5.Text = "NAO SEI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_inicio);
            this.Name = "inicio";
            this.Size = new System.Drawing.Size(1200, 1014);
            this.Load += new System.EventHandler(this.inicio_Load);
            this.pl_inicio.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_membros)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_progressao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_inicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_progressao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_progressao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_membros;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
