namespace PerpusFormWithUI
{
    partial class FormMahasiswa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idbukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penerbitbukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokbukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelbukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perpustakaanDataSet = new PerpusFormWithUI.perpustakaanDataSet();
            this.tabel_bukuTableAdapter = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.tabel_bukuTableAdapter();
            this.textBox_pencarian = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelbukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pencarian Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "DATEEB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "PERPUSTAKAAN";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbukuDataGridViewTextBoxColumn,
            this.namabukuDataGridViewTextBoxColumn,
            this.penerbitbukuDataGridViewTextBoxColumn,
            this.stokbukuDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.tabelbukuBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.MediumTurquoise;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.DarkOliveGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(17, 163);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(459, 189);
            this.bunifuCustomDataGrid1.TabIndex = 22;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // idbukuDataGridViewTextBoxColumn
            // 
            this.idbukuDataGridViewTextBoxColumn.DataPropertyName = "id_buku";
            this.idbukuDataGridViewTextBoxColumn.HeaderText = "id_buku";
            this.idbukuDataGridViewTextBoxColumn.Name = "idbukuDataGridViewTextBoxColumn";
            this.idbukuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namabukuDataGridViewTextBoxColumn
            // 
            this.namabukuDataGridViewTextBoxColumn.DataPropertyName = "nama_buku";
            this.namabukuDataGridViewTextBoxColumn.HeaderText = "nama_buku";
            this.namabukuDataGridViewTextBoxColumn.Name = "namabukuDataGridViewTextBoxColumn";
            // 
            // penerbitbukuDataGridViewTextBoxColumn
            // 
            this.penerbitbukuDataGridViewTextBoxColumn.DataPropertyName = "penerbit_buku";
            this.penerbitbukuDataGridViewTextBoxColumn.HeaderText = "penerbit_buku";
            this.penerbitbukuDataGridViewTextBoxColumn.Name = "penerbitbukuDataGridViewTextBoxColumn";
            // 
            // stokbukuDataGridViewTextBoxColumn
            // 
            this.stokbukuDataGridViewTextBoxColumn.DataPropertyName = "stok_buku";
            this.stokbukuDataGridViewTextBoxColumn.HeaderText = "stok_buku";
            this.stokbukuDataGridViewTextBoxColumn.Name = "stokbukuDataGridViewTextBoxColumn";
            // 
            // tabelbukuBindingSource
            // 
            this.tabelbukuBindingSource.DataMember = "tabel_buku";
            this.tabelbukuBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabel_bukuTableAdapter
            // 
            this.tabel_bukuTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_pencarian
            // 
            this.textBox_pencarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pencarian.Location = new System.Drawing.Point(42, 105);
            this.textBox_pencarian.Name = "textBox_pencarian";
            this.textBox_pencarian.Size = new System.Drawing.Size(281, 29);
            this.textBox_pencarian.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(331, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cari Buku";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(499, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_pencarian);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormMahasiswa";
            this.Text = "FormMahasiswa";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelbukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource tabelbukuBindingSource;
        private perpustakaanDataSetTableAdapters.tabel_bukuTableAdapter tabel_bukuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penerbitbukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokbukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_pencarian;
        private System.Windows.Forms.Button button1;
    }
}