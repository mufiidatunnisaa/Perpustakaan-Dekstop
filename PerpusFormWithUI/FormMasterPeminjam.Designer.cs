namespace PerpusFormWithUI
{
    partial class FormMasterPeminjam
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
            System.Windows.Forms.Label nama_peminjamLabel;
            System.Windows.Forms.Label alamat_peminjamLabel;
            System.Windows.Forms.Label password_peminjamLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMasterPeminjam));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.perpustakaanDataSet = new PerpusFormWithUI.perpustakaanDataSet();
            this.tabel_peminjamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabel_peminjamTableAdapter = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.tabel_peminjamTableAdapter();
            this.tableAdapterManager = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.TableAdapterManager();
            this.tabel_peminjamBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabel_peminjamBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabel_peminjamDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_peminjamTextBox = new System.Windows.Forms.TextBox();
            this.alamat_peminjamTextBox = new System.Windows.Forms.TextBox();
            this.password_peminjamTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_pencarian = new System.Windows.Forms.TextBox();
            nama_peminjamLabel = new System.Windows.Forms.Label();
            alamat_peminjamLabel = new System.Windows.Forms.Label();
            password_peminjamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_peminjamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_peminjamBindingNavigator)).BeginInit();
            this.tabel_peminjamBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_peminjamDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nama_peminjamLabel
            // 
            nama_peminjamLabel.AutoSize = true;
            nama_peminjamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nama_peminjamLabel.Location = new System.Drawing.Point(18, 189);
            nama_peminjamLabel.Name = "nama_peminjamLabel";
            nama_peminjamLabel.Size = new System.Drawing.Size(125, 20);
            nama_peminjamLabel.TabIndex = 17;
            nama_peminjamLabel.Text = "nama peminjam:";
            // 
            // alamat_peminjamLabel
            // 
            alamat_peminjamLabel.AutoSize = true;
            alamat_peminjamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alamat_peminjamLabel.Location = new System.Drawing.Point(22, 235);
            alamat_peminjamLabel.Name = "alamat_peminjamLabel";
            alamat_peminjamLabel.Size = new System.Drawing.Size(133, 20);
            alamat_peminjamLabel.TabIndex = 18;
            alamat_peminjamLabel.Text = "alamat peminjam:";
            // 
            // password_peminjamLabel
            // 
            password_peminjamLabel.AutoSize = true;
            password_peminjamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            password_peminjamLabel.Location = new System.Drawing.Point(26, 293);
            password_peminjamLabel.Name = "password_peminjamLabel";
            password_peminjamLabel.Size = new System.Drawing.Size(153, 20);
            password_peminjamLabel.TabIndex = 19;
            password_peminjamLabel.Text = "password peminjam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(-3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Master Peminjam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(159, 31);
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
            this.label1.Location = new System.Drawing.Point(-3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "PERPUSTAKAAN";
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabel_peminjamBindingSource
            // 
            this.tabel_peminjamBindingSource.DataMember = "tabel_peminjam";
            this.tabel_peminjamBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // tabel_peminjamTableAdapter
            // 
            this.tabel_peminjamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabel_bukuTableAdapter = null;
            this.tableAdapterManager.tabel_pegawaiTableAdapter = null;
            this.tableAdapterManager.tabel_peminjamTableAdapter = this.tabel_peminjamTableAdapter;
            this.tableAdapterManager.tabel_pengembalianTableAdapter = null;
            this.tableAdapterManager.tabel_transaksi_peminjamanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PerpusFormWithUI.perpustakaanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabel_peminjamBindingNavigator
            // 
            this.tabel_peminjamBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabel_peminjamBindingNavigator.BindingSource = this.tabel_peminjamBindingSource;
            this.tabel_peminjamBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabel_peminjamBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabel_peminjamBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabel_peminjamBindingNavigatorSaveItem});
            this.tabel_peminjamBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabel_peminjamBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabel_peminjamBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabel_peminjamBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabel_peminjamBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabel_peminjamBindingNavigator.Name = "tabel_peminjamBindingNavigator";
            this.tabel_peminjamBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabel_peminjamBindingNavigator.Size = new System.Drawing.Size(513, 25);
            this.tabel_peminjamBindingNavigator.TabIndex = 17;
            this.tabel_peminjamBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabel_peminjamBindingNavigatorSaveItem
            // 
            this.tabel_peminjamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabel_peminjamBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabel_peminjamBindingNavigatorSaveItem.Image")));
            this.tabel_peminjamBindingNavigatorSaveItem.Name = "tabel_peminjamBindingNavigatorSaveItem";
            this.tabel_peminjamBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabel_peminjamBindingNavigatorSaveItem.Text = "Save Data";
            this.tabel_peminjamBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabel_peminjamBindingNavigatorSaveItem_Click);
            // 
            // tabel_peminjamDataGridView
            // 
            this.tabel_peminjamDataGridView.AutoGenerateColumns = false;
            this.tabel_peminjamDataGridView.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.tabel_peminjamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel_peminjamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tabel_peminjamDataGridView.DataSource = this.tabel_peminjamBindingSource;
            this.tabel_peminjamDataGridView.Location = new System.Drawing.Point(12, 339);
            this.tabel_peminjamDataGridView.Name = "tabel_peminjamDataGridView";
            this.tabel_peminjamDataGridView.Size = new System.Drawing.Size(457, 220);
            this.tabel_peminjamDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_peminjam";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_peminjam";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama_peminjam";
            this.dataGridViewTextBoxColumn2.HeaderText = "nama_peminjam";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "alamat_peminjam";
            this.dataGridViewTextBoxColumn3.HeaderText = "alamat_peminjam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "password_peminjam";
            this.dataGridViewTextBoxColumn4.HeaderText = "password_peminjam";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // nama_peminjamTextBox
            // 
            this.nama_peminjamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabel_peminjamBindingSource, "nama_peminjam", true));
            this.nama_peminjamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_peminjamTextBox.Location = new System.Drawing.Point(194, 189);
            this.nama_peminjamTextBox.Name = "nama_peminjamTextBox";
            this.nama_peminjamTextBox.Size = new System.Drawing.Size(204, 26);
            this.nama_peminjamTextBox.TabIndex = 18;
            // 
            // alamat_peminjamTextBox
            // 
            this.alamat_peminjamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabel_peminjamBindingSource, "alamat_peminjam", true));
            this.alamat_peminjamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_peminjamTextBox.Location = new System.Drawing.Point(194, 235);
            this.alamat_peminjamTextBox.Name = "alamat_peminjamTextBox";
            this.alamat_peminjamTextBox.Size = new System.Drawing.Size(204, 26);
            this.alamat_peminjamTextBox.TabIndex = 19;
            // 
            // password_peminjamTextBox
            // 
            this.password_peminjamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabel_peminjamBindingSource, "password_peminjam", true));
            this.password_peminjamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_peminjamTextBox.Location = new System.Drawing.Point(194, 287);
            this.password_peminjamTextBox.Name = "password_peminjamTextBox";
            this.password_peminjamTextBox.Size = new System.Drawing.Size(204, 26);
            this.password_peminjamTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 30;
            this.button1.Text = "Cari Buku";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_pencarian
            // 
            this.textBox_pencarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pencarian.Location = new System.Drawing.Point(22, 119);
            this.textBox_pencarian.Name = "textBox_pencarian";
            this.textBox_pencarian.Size = new System.Drawing.Size(281, 29);
            this.textBox_pencarian.TabIndex = 29;
            // 
            // FormMasterPeminjam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(513, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_pencarian);
            this.Controls.Add(password_peminjamLabel);
            this.Controls.Add(this.password_peminjamTextBox);
            this.Controls.Add(alamat_peminjamLabel);
            this.Controls.Add(this.alamat_peminjamTextBox);
            this.Controls.Add(nama_peminjamLabel);
            this.Controls.Add(this.nama_peminjamTextBox);
            this.Controls.Add(this.tabel_peminjamDataGridView);
            this.Controls.Add(this.tabel_peminjamBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormMasterPeminjam";
            this.Text = "FormMasterPeminjam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMasterPeminjam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_peminjamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_peminjamBindingNavigator)).EndInit();
            this.tabel_peminjamBindingNavigator.ResumeLayout(false);
            this.tabel_peminjamBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_peminjamDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource tabel_peminjamBindingSource;
        private perpustakaanDataSetTableAdapters.tabel_peminjamTableAdapter tabel_peminjamTableAdapter;
        private perpustakaanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabel_peminjamBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tabel_peminjamBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabel_peminjamDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox nama_peminjamTextBox;
        private System.Windows.Forms.TextBox alamat_peminjamTextBox;
        private System.Windows.Forms.TextBox password_peminjamTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_pencarian;
    }
}