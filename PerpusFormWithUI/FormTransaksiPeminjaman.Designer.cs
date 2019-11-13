namespace PerpusFormWithUI
{
    partial class FormTransaksiPeminjaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksiPeminjaman));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idpeminjamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpeminjamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalpeminjamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalharuskembaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabeltransaksipeminjamanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perpustakaanDataSet = new PerpusFormWithUI.perpustakaanDataSet();
            this.tabel_transaksi_peminjamanTableAdapter = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.tabel_transaksi_peminjamanTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabeltransaksipeminjamanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.idpeminjamanDataGridViewTextBoxColumn,
            this.idpeminjamDataGridViewTextBoxColumn,
            this.idpegawaiDataGridViewTextBoxColumn,
            this.idbukuDataGridViewTextBoxColumn,
            this.tanggalpeminjamanDataGridViewTextBoxColumn,
            this.tanggalharuskembaliDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.tabeltransaksipeminjamanBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.MediumTurquoise;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.DarkOliveGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(17, 70);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(718, 225);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // idpeminjamanDataGridViewTextBoxColumn
            // 
            this.idpeminjamanDataGridViewTextBoxColumn.DataPropertyName = "id_peminjaman";
            this.idpeminjamanDataGridViewTextBoxColumn.HeaderText = "id_peminjaman";
            this.idpeminjamanDataGridViewTextBoxColumn.Name = "idpeminjamanDataGridViewTextBoxColumn";
            this.idpeminjamanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpeminjamDataGridViewTextBoxColumn
            // 
            this.idpeminjamDataGridViewTextBoxColumn.DataPropertyName = "id_peminjam";
            this.idpeminjamDataGridViewTextBoxColumn.HeaderText = "id_peminjam";
            this.idpeminjamDataGridViewTextBoxColumn.Name = "idpeminjamDataGridViewTextBoxColumn";
            // 
            // idpegawaiDataGridViewTextBoxColumn
            // 
            this.idpegawaiDataGridViewTextBoxColumn.DataPropertyName = "id_pegawai";
            this.idpegawaiDataGridViewTextBoxColumn.HeaderText = "id_pegawai";
            this.idpegawaiDataGridViewTextBoxColumn.Name = "idpegawaiDataGridViewTextBoxColumn";
            // 
            // idbukuDataGridViewTextBoxColumn
            // 
            this.idbukuDataGridViewTextBoxColumn.DataPropertyName = "id_buku";
            this.idbukuDataGridViewTextBoxColumn.HeaderText = "id_buku";
            this.idbukuDataGridViewTextBoxColumn.Name = "idbukuDataGridViewTextBoxColumn";
            // 
            // tanggalpeminjamanDataGridViewTextBoxColumn
            // 
            this.tanggalpeminjamanDataGridViewTextBoxColumn.DataPropertyName = "tanggal_peminjaman";
            this.tanggalpeminjamanDataGridViewTextBoxColumn.HeaderText = "tanggal_peminjaman";
            this.tanggalpeminjamanDataGridViewTextBoxColumn.Name = "tanggalpeminjamanDataGridViewTextBoxColumn";
            // 
            // tanggalharuskembaliDataGridViewTextBoxColumn
            // 
            this.tanggalharuskembaliDataGridViewTextBoxColumn.DataPropertyName = "tanggal_harus_kembali";
            this.tanggalharuskembaliDataGridViewTextBoxColumn.HeaderText = "tanggal_harus_kembali";
            this.tanggalharuskembaliDataGridViewTextBoxColumn.Name = "tanggalharuskembaliDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // tabeltransaksipeminjamanBindingSource
            // 
            this.tabeltransaksipeminjamanBindingSource.DataMember = "tabel_transaksi_peminjaman";
            this.tabeltransaksipeminjamanBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabel_transaksi_peminjamanTableAdapter
            // 
            this.tabel_transaksi_peminjamanTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 16;
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
            this.label3.TabIndex = 15;
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
            this.label1.TabIndex = 14;
            this.label1.Text = "PERPUSTAKAAN";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.LightSalmon;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.MediumTurquoise;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "ADD";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(17, 303);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(140, 41);
            this.bunifuThinButton21.TabIndex = 21;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // FormTransaksiPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(760, 358);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "FormTransaksiPeminjaman";
            this.Text = "FormTransaksiPeminjaman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTransaksiPeminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabeltransaksipeminjamanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource tabeltransaksipeminjamanBindingSource;
        private perpustakaanDataSetTableAdapters.tabel_transaksi_peminjamanTableAdapter tabel_transaksi_peminjamanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeminjamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeminjamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalpeminjamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalharuskembaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}