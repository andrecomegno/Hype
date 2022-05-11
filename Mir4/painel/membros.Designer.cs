
namespace Mir4.painel
{
    partial class membros
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_procurar = new System.Windows.Forms.Button();
            this.txt_procurar = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mydbDataSet = new Mir4.mydbDataSet();
            this.cadastromembroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastro_membroTableAdapter = new Mir4.mydbDataSetTableAdapters.cadastro_membroTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIVELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pODERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastromembroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 720);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(27, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 48);
            this.panel2.TabIndex = 77;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.bt_procurar);
            this.panel3.Controls.Add(this.txt_procurar);
            this.panel3.Location = new System.Drawing.Point(24, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1156, 61);
            this.panel3.TabIndex = 76;
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
            this.bt_procurar.Location = new System.Drawing.Point(764, 18);
            this.bt_procurar.Name = "bt_procurar";
            this.bt_procurar.Size = new System.Drawing.Size(117, 28);
            this.bt_procurar.TabIndex = 61;
            this.bt_procurar.Text = "Procurar";
            this.bt_procurar.UseVisualStyleBackColor = false;
            this.bt_procurar.Click += new System.EventHandler(this.bt_procurar_Click);
            // 
            // txt_procurar
            // 
            this.txt_procurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_procurar.Location = new System.Drawing.Point(249, 23);
            this.txt_procurar.Name = "txt_procurar";
            this.txt_procurar.Size = new System.Drawing.Size(509, 23);
            this.txt_procurar.TabIndex = 60;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(21, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1159, 570);
            this.panel4.TabIndex = 75;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nICKDataGridViewTextBoxColumn,
            this.nIVELDataGridViewTextBoxColumn,
            this.pODERDataGridViewTextBoxColumn,
            this.cLASSEDataGridViewTextBoxColumn,
            this.pATENTEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadastromembroBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 570);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEMBROS";
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastromembroBindingSource
            // 
            this.cadastromembroBindingSource.DataMember = "cadastro_membro";
            this.cadastromembroBindingSource.DataSource = this.mydbDataSet;
            // 
            // cadastro_membroTableAdapter
            // 
            this.cadastro_membroTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nICKDataGridViewTextBoxColumn
            // 
            this.nICKDataGridViewTextBoxColumn.DataPropertyName = "NICK";
            this.nICKDataGridViewTextBoxColumn.HeaderText = "NICK";
            this.nICKDataGridViewTextBoxColumn.Name = "nICKDataGridViewTextBoxColumn";
            // 
            // nIVELDataGridViewTextBoxColumn
            // 
            this.nIVELDataGridViewTextBoxColumn.DataPropertyName = "NIVEL";
            this.nIVELDataGridViewTextBoxColumn.HeaderText = "NIVEL";
            this.nIVELDataGridViewTextBoxColumn.Name = "nIVELDataGridViewTextBoxColumn";
            // 
            // pODERDataGridViewTextBoxColumn
            // 
            this.pODERDataGridViewTextBoxColumn.DataPropertyName = "PODER";
            this.pODERDataGridViewTextBoxColumn.HeaderText = "PODER";
            this.pODERDataGridViewTextBoxColumn.Name = "pODERDataGridViewTextBoxColumn";
            // 
            // cLASSEDataGridViewTextBoxColumn
            // 
            this.cLASSEDataGridViewTextBoxColumn.DataPropertyName = "CLASSE";
            this.cLASSEDataGridViewTextBoxColumn.HeaderText = "CLASSE";
            this.cLASSEDataGridViewTextBoxColumn.Name = "cLASSEDataGridViewTextBoxColumn";
            // 
            // pATENTEDataGridViewTextBoxColumn
            // 
            this.pATENTEDataGridViewTextBoxColumn.DataPropertyName = "PATENTE";
            this.pATENTEDataGridViewTextBoxColumn.HeaderText = "PATENTE";
            this.pATENTEDataGridViewTextBoxColumn.Name = "pATENTEDataGridViewTextBoxColumn";
            // 
            // membros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "membros";
            this.Size = new System.Drawing.Size(1200, 720);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastromembroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_procurar;
        private System.Windows.Forms.TextBox txt_procurar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pODERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cadastromembroBindingSource;
        private mydbDataSet mydbDataSet;
        private mydbDataSetTableAdapters.cadastro_membroTableAdapter cadastro_membroTableAdapter;
    }
}
