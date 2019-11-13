namespace PerpusFormWithUI
{
    partial class FormTransaksiPengembalian
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
            this.perpustakaanDataSet = new PerpusFormWithUI.perpustakaanDataSet();
            this.tabelpengembalianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabel_pengembalianTableAdapter = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.tabel_pengembalianTableAdapter();
            this.idpengembalianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpeminjamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalkembaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelpengembalianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Transaksi Peminjaman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 18;
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
            this.label1.TabIndex = 17;
            this.label1.Text = "PERPUSTAKAAN";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpengembalianDataGridViewTextBoxColumn,
            this.idpeminjamanDataGridViewTextBoxColumn,
            this.tanggalkembaliDataGridViewTextBoxColumn,
            this.dendaDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.tabelpengembalianBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(17, 151);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(240, 150);
            this.bunifuCustomDataGrid1.TabIndex = 20;
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelpengembalianBindingSource
            // 
            this.tabelpengembalianBindingSource.DataMember = "tabel_pengembalian";
            this.tabelpengembalianBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // tabel_pengembalianTableAdapter
            // 
            this.tabel_pengembalianTableAdapter.ClearBeforeFill = true;
            // 
            // idpengembalianDataGridViewTextBoxColumn
            // 
            this.idpengembalianDataGridViewTextBoxColumn.DataPropertyName = "id_pengembalian";
            this.idpengembalianDataGridViewTextBoxColumn.HeaderText = "id_pengembalian";
            this.idpengembalianDataGridViewTextBoxColumn.Name = "idpengembalianDataGridViewTextBoxColumn";
            this.idpengembalianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpeminjamanDataGridViewTextBoxColumn
            // 
            this.idpeminjamanDataGridViewTextBoxColumn.DataPropertyName = "id_peminjaman";
            this.idpeminjamanDataGridViewTextBoxColumn.HeaderText = "id_peminjaman";
            this.idpeminjamanDataGridViewTextBoxColumn.Name = "idpeminjamanDataGridViewTextBoxColumn";
            // 
            // tanggalkembaliDataGridViewTextBoxColumn
            // 
            this.tanggalkembaliDataGridViewTextBoxColumn.DataPropertyName = "tanggal_kembali";
            this.tanggalkembaliDataGridViewTextBoxColumn.HeaderText = "tanggal_kembali";
            this.tanggalkembaliDataGridViewTextBoxColumn.Name = "tanggalkembaliDataGridViewTextBoxColumn";
            // 
            // dendaDataGridViewTextBoxColumn
            // 
            this.dendaDataGridViewTextBoxColumn.DataPropertyName = "denda";
            this.dendaDataGridViewTextBoxColumn.HeaderText = "denda";
            this.dendaDataGridViewTextBoxColumn.Name = "dendaDataGridViewTextBoxColumn";
            // 
            // FormTransaksiPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(508, 358);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaksiPengembalian";
            this.Text = "FormTransaksiPengembalian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTransaksiPengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelpengembalianBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource tabelpengembalianBindingSource;
        private perpustakaanDataSetTableAdapters.tabel_pengembalianTableAdapter tabel_pengembalianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpengembalianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeminjamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalkembaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dendaDataGridViewTextBoxColumn;
    }
}