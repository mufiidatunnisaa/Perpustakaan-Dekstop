namespace PerpusFormWithUI
{
    partial class FormAddPeminjaman
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_id_pegawai = new System.Windows.Forms.ComboBox();
            this.comboBox_id_peminjam = new System.Windows.Forms.ComboBox();
            this.comboBox_id_buku = new System.Windows.Forms.ComboBox();
            this.perpustakaanDataSet = new PerpusFormWithUI.perpustakaanDataSet();
            this.tabelpegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabel_pegawaiTableAdapter = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.tabel_pegawaiTableAdapter();
            this.tabelpeminjamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabel_peminjamTableAdapter = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.tabel_peminjamTableAdapter();
            this.tabelbukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabel_bukuTableAdapter = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.tabel_bukuTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_tanggal_peminjaman = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_tanggal_harus_kembali = new System.Windows.Forms.DateTimePicker();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelpegawaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelpeminjamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelbukuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID PEGAWAI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Transaksi Penambahan Stok Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(165, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "DATEEB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "PERPUSTAKAAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID PEMINJAM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "ID BUKU";
            // 
            // comboBox_id_pegawai
            // 
            this.comboBox_id_pegawai.DataSource = this.tabelpegawaiBindingSource;
            this.comboBox_id_pegawai.DisplayMember = "nama_pegawai";
            this.comboBox_id_pegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_id_pegawai.FormattingEnabled = true;
            this.comboBox_id_pegawai.Location = new System.Drawing.Point(277, 86);
            this.comboBox_id_pegawai.Name = "comboBox_id_pegawai";
            this.comboBox_id_pegawai.Size = new System.Drawing.Size(200, 28);
            this.comboBox_id_pegawai.TabIndex = 21;
            this.comboBox_id_pegawai.ValueMember = "id_pegawai";
            // 
            // comboBox_id_peminjam
            // 
            this.comboBox_id_peminjam.DataSource = this.tabelpeminjamBindingSource;
            this.comboBox_id_peminjam.DisplayMember = "nama_peminjam";
            this.comboBox_id_peminjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_id_peminjam.FormattingEnabled = true;
            this.comboBox_id_peminjam.Location = new System.Drawing.Point(277, 132);
            this.comboBox_id_peminjam.Name = "comboBox_id_peminjam";
            this.comboBox_id_peminjam.Size = new System.Drawing.Size(200, 28);
            this.comboBox_id_peminjam.TabIndex = 22;
            this.comboBox_id_peminjam.ValueMember = "id_peminjam";
            // 
            // comboBox_id_buku
            // 
            this.comboBox_id_buku.DataSource = this.tabelbukuBindingSource;
            this.comboBox_id_buku.DisplayMember = "nama_buku";
            this.comboBox_id_buku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_id_buku.FormattingEnabled = true;
            this.comboBox_id_buku.Location = new System.Drawing.Point(277, 186);
            this.comboBox_id_buku.Name = "comboBox_id_buku";
            this.comboBox_id_buku.Size = new System.Drawing.Size(200, 28);
            this.comboBox_id_buku.TabIndex = 23;
            this.comboBox_id_buku.ValueMember = "id_buku";
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelpegawaiBindingSource
            // 
            this.tabelpegawaiBindingSource.DataMember = "tabel_pegawai";
            this.tabelpegawaiBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // tabel_pegawaiTableAdapter
            // 
            this.tabel_pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // tabelpeminjamBindingSource
            // 
            this.tabelpeminjamBindingSource.DataMember = "tabel_peminjam";
            this.tabelpeminjamBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // tabel_peminjamTableAdapter
            // 
            this.tabel_peminjamTableAdapter.ClearBeforeFill = true;
            // 
            // tabelbukuBindingSource
            // 
            this.tabelbukuBindingSource.DataMember = "tabel_buku";
            this.tabelbukuBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // tabel_bukuTableAdapter
            // 
            this.tabel_bukuTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "TANGGAL PEMINJAMAN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "TANGGAL HARUS KEMBALI";
            // 
            // dateTimePicker_tanggal_peminjaman
            // 
            this.dateTimePicker_tanggal_peminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_tanggal_peminjaman.Location = new System.Drawing.Point(277, 241);
            this.dateTimePicker_tanggal_peminjaman.Name = "dateTimePicker_tanggal_peminjaman";
            this.dateTimePicker_tanggal_peminjaman.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_tanggal_peminjaman.TabIndex = 26;
            // 
            // dateTimePicker_tanggal_harus_kembali
            // 
            this.dateTimePicker_tanggal_harus_kembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_tanggal_harus_kembali.Location = new System.Drawing.Point(277, 287);
            this.dateTimePicker_tanggal_harus_kembali.Name = "dateTimePicker_tanggal_harus_kembali";
            this.dateTimePicker_tanggal_harus_kembali.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_tanggal_harus_kembali.TabIndex = 27;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.CadetBlue;
            this.button_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(202, 330);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(104, 42);
            this.button_save.TabIndex = 28;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // FormAddPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(520, 384);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dateTimePicker_tanggal_harus_kembali);
            this.Controls.Add(this.dateTimePicker_tanggal_peminjaman);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_id_buku);
            this.Controls.Add(this.comboBox_id_peminjam);
            this.Controls.Add(this.comboBox_id_pegawai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "FormAddPeminjaman";
            this.Text = "FormAddPeminjaman";
            this.Load += new System.EventHandler(this.FormAddPeminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelpegawaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelpeminjamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelbukuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_id_pegawai;
        private System.Windows.Forms.ComboBox comboBox_id_peminjam;
        private System.Windows.Forms.ComboBox comboBox_id_buku;
        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource tabelpegawaiBindingSource;
        private perpustakaanDataSetTableAdapters.tabel_pegawaiTableAdapter tabel_pegawaiTableAdapter;
        private System.Windows.Forms.BindingSource tabelpeminjamBindingSource;
        private perpustakaanDataSetTableAdapters.tabel_peminjamTableAdapter tabel_peminjamTableAdapter;
        private System.Windows.Forms.BindingSource tabelbukuBindingSource;
        private perpustakaanDataSetTableAdapters.tabel_bukuTableAdapter tabel_bukuTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tanggal_peminjaman;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tanggal_harus_kembali;
        private System.Windows.Forms.Button button_save;
    }
}