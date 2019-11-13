namespace PerpusFormWithUI
{
    partial class FormAddPengembalian
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_id_peminjaman = new System.Windows.Forms.ComboBox();
            this.perpustakaanDataSet = new PerpusFormWithUI.perpustakaanDataSet();
            this.tabeltransaksipeminjamanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabel_transaksi_peminjamanTableAdapter = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.tabel_transaksi_peminjamanTableAdapter();
            this.dateTimePicker_tanggal_kembali = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label_denda = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabeltransaksipeminjamanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Transaksi Pengembalian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 21;
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
            this.label1.TabIndex = 20;
            this.label1.Text = "PERPUSTAKAAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "ID PEMINJAMAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "TANGGAL KEMBALI";
            // 
            // comboBox_id_peminjaman
            // 
            this.comboBox_id_peminjaman.DataSource = this.tabeltransaksipeminjamanBindingSource;
            this.comboBox_id_peminjaman.DisplayMember = "id_peminjaman";
            this.comboBox_id_peminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_id_peminjaman.FormattingEnabled = true;
            this.comboBox_id_peminjaman.Location = new System.Drawing.Point(203, 99);
            this.comboBox_id_peminjaman.Name = "comboBox_id_peminjaman";
            this.comboBox_id_peminjaman.Size = new System.Drawing.Size(200, 28);
            this.comboBox_id_peminjaman.TabIndex = 26;
            this.comboBox_id_peminjaman.ValueMember = "id_peminjaman";
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabeltransaksipeminjamanBindingSource
            // 
            this.tabeltransaksipeminjamanBindingSource.DataMember = "tabel_transaksi_peminjaman";
            this.tabeltransaksipeminjamanBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // tabel_transaksi_peminjamanTableAdapter
            // 
            this.tabel_transaksi_peminjamanTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker_tanggal_kembali
            // 
            this.dateTimePicker_tanggal_kembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_tanggal_kembali.Location = new System.Drawing.Point(203, 155);
            this.dateTimePicker_tanggal_kembali.Name = "dateTimePicker_tanggal_kembali";
            this.dateTimePicker_tanggal_kembali.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_tanggal_kembali.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(251, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 56);
            this.button1.TabIndex = 28;
            this.button1.Text = "GENERATE DENDA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_denda
            // 
            this.label_denda.AutoSize = true;
            this.label_denda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_denda.Location = new System.Drawing.Point(203, 224);
            this.label_denda.Name = "label_denda";
            this.label_denda.Size = new System.Drawing.Size(19, 20);
            this.label_denda.TabIndex = 29;
            this.label_denda.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "DENDA";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.CadetBlue;
            this.button_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(166, 284);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(104, 42);
            this.button_save.TabIndex = 31;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // FormAddPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(459, 378);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_denda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker_tanggal_kembali);
            this.Controls.Add(this.comboBox_id_peminjaman);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPengembalian";
            this.Text = "FormAddPengembalian";
            this.Load += new System.EventHandler(this.FormAddPengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabeltransaksipeminjamanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_id_peminjaman;
        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource tabeltransaksipeminjamanBindingSource;
        private perpustakaanDataSetTableAdapters.tabel_transaksi_peminjamanTableAdapter tabel_transaksi_peminjamanTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tanggal_kembali;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_denda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_save;
    }
}