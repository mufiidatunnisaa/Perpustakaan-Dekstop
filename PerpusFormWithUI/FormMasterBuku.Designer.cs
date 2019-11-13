namespace PerpusFormWithUI
{
    partial class FormMasterBuku
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
            System.Windows.Forms.Label nama_bukuLabel;
            System.Windows.Forms.Label penerbit_bukuLabel;
            System.Windows.Forms.Label stok_bukuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMasterBuku));
            this.perpustakaanDataSet = new PerpusFormWithUI.perpustakaanDataSet();
            this.tabel_bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabel_bukuTableAdapter = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.tabel_bukuTableAdapter();
            this.tableAdapterManager = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.TableAdapterManager();
            this.tabel_bukuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabel_bukuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabel_bukuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nama_bukuTextBox = new System.Windows.Forms.TextBox();
            this.penerbit_bukuTextBox = new System.Windows.Forms.TextBox();
            this.stok_bukuTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_pencarian = new System.Windows.Forms.TextBox();
            nama_bukuLabel = new System.Windows.Forms.Label();
            penerbit_bukuLabel = new System.Windows.Forms.Label();
            stok_bukuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_bukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_bukuBindingNavigator)).BeginInit();
            this.tabel_bukuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_bukuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nama_bukuLabel
            // 
            nama_bukuLabel.AutoSize = true;
            nama_bukuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nama_bukuLabel.Location = new System.Drawing.Point(12, 157);
            nama_bukuLabel.Name = "nama_bukuLabel";
            nama_bukuLabel.Size = new System.Drawing.Size(92, 20);
            nama_bukuLabel.TabIndex = 10;
            nama_bukuLabel.Text = "nama buku:";
            // 
            // penerbit_bukuLabel
            // 
            penerbit_bukuLabel.AutoSize = true;
            penerbit_bukuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            penerbit_bukuLabel.Location = new System.Drawing.Point(10, 196);
            penerbit_bukuLabel.Name = "penerbit_bukuLabel";
            penerbit_bukuLabel.Size = new System.Drawing.Size(110, 20);
            penerbit_bukuLabel.TabIndex = 11;
            penerbit_bukuLabel.Text = "penerbit buku:";
            // 
            // stok_bukuLabel
            // 
            stok_bukuLabel.AutoSize = true;
            stok_bukuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stok_bukuLabel.Location = new System.Drawing.Point(12, 237);
            stok_bukuLabel.Name = "stok_bukuLabel";
            stok_bukuLabel.Size = new System.Drawing.Size(82, 20);
            stok_bukuLabel.TabIndex = 12;
            stok_bukuLabel.Text = "stok buku:";
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabel_bukuBindingSource
            // 
            this.tabel_bukuBindingSource.DataMember = "tabel_buku";
            this.tabel_bukuBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // tabel_bukuTableAdapter
            // 
            this.tabel_bukuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabel_bukuTableAdapter = this.tabel_bukuTableAdapter;
            this.tableAdapterManager.tabel_pegawaiTableAdapter = null;
            this.tableAdapterManager.tabel_peminjamTableAdapter = null;
            this.tableAdapterManager.tabel_pengembalianTableAdapter = null;
            this.tableAdapterManager.tabel_transaksi_peminjamanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PerpusFormWithUI.perpustakaanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabel_bukuBindingNavigator
            // 
            this.tabel_bukuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabel_bukuBindingNavigator.BindingSource = this.tabel_bukuBindingSource;
            this.tabel_bukuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabel_bukuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabel_bukuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabel_bukuBindingNavigatorSaveItem});
            this.tabel_bukuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabel_bukuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabel_bukuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabel_bukuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabel_bukuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabel_bukuBindingNavigator.Name = "tabel_bukuBindingNavigator";
            this.tabel_bukuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabel_bukuBindingNavigator.Size = new System.Drawing.Size(528, 25);
            this.tabel_bukuBindingNavigator.TabIndex = 0;
            this.tabel_bukuBindingNavigator.Text = "bindingNavigator1";
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
            // tabel_bukuBindingNavigatorSaveItem
            // 
            this.tabel_bukuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabel_bukuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabel_bukuBindingNavigatorSaveItem.Image")));
            this.tabel_bukuBindingNavigatorSaveItem.Name = "tabel_bukuBindingNavigatorSaveItem";
            this.tabel_bukuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabel_bukuBindingNavigatorSaveItem.Text = "Save Data";
            this.tabel_bukuBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabel_bukuBindingNavigatorSaveItem_Click);
            // 
            // tabel_bukuDataGridView
            // 
            this.tabel_bukuDataGridView.AutoGenerateColumns = false;
            this.tabel_bukuDataGridView.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.tabel_bukuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel_bukuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tabel_bukuDataGridView.DataSource = this.tabel_bukuBindingSource;
            this.tabel_bukuDataGridView.Location = new System.Drawing.Point(12, 294);
            this.tabel_bukuDataGridView.Name = "tabel_bukuDataGridView";
            this.tabel_bukuDataGridView.Size = new System.Drawing.Size(453, 220);
            this.tabel_bukuDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_buku";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_buku";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama_buku";
            this.dataGridViewTextBoxColumn2.HeaderText = "nama_buku";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "penerbit_buku";
            this.dataGridViewTextBoxColumn3.HeaderText = "penerbit_buku";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stok_buku";
            this.dataGridViewTextBoxColumn4.HeaderText = "stok_buku";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(158, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "DATEEB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(-4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "PERPUSTAKAAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(-4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Master Buku";
            // 
            // nama_bukuTextBox
            // 
            this.nama_bukuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabel_bukuBindingSource, "nama_buku", true));
            this.nama_bukuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_bukuTextBox.Location = new System.Drawing.Point(139, 154);
            this.nama_bukuTextBox.Name = "nama_bukuTextBox";
            this.nama_bukuTextBox.Size = new System.Drawing.Size(155, 26);
            this.nama_bukuTextBox.TabIndex = 11;
            // 
            // penerbit_bukuTextBox
            // 
            this.penerbit_bukuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabel_bukuBindingSource, "penerbit_buku", true));
            this.penerbit_bukuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penerbit_bukuTextBox.Location = new System.Drawing.Point(139, 193);
            this.penerbit_bukuTextBox.Name = "penerbit_bukuTextBox";
            this.penerbit_bukuTextBox.Size = new System.Drawing.Size(155, 26);
            this.penerbit_bukuTextBox.TabIndex = 12;
            // 
            // stok_bukuTextBox
            // 
            this.stok_bukuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabel_bukuBindingSource, "stok_buku", true));
            this.stok_bukuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stok_bukuTextBox.Location = new System.Drawing.Point(139, 237);
            this.stok_bukuTextBox.Name = "stok_bukuTextBox";
            this.stok_bukuTextBox.Size = new System.Drawing.Size(155, 26);
            this.stok_bukuTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "Cari Buku";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_pencarian
            // 
            this.textBox_pencarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pencarian.Location = new System.Drawing.Point(20, 108);
            this.textBox_pencarian.Name = "textBox_pencarian";
            this.textBox_pencarian.Size = new System.Drawing.Size(281, 29);
            this.textBox_pencarian.TabIndex = 25;
            // 
            // FormMasterBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(528, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_pencarian);
            this.Controls.Add(stok_bukuLabel);
            this.Controls.Add(this.stok_bukuTextBox);
            this.Controls.Add(penerbit_bukuLabel);
            this.Controls.Add(this.penerbit_bukuTextBox);
            this.Controls.Add(nama_bukuLabel);
            this.Controls.Add(this.nama_bukuTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabel_bukuDataGridView);
            this.Controls.Add(this.tabel_bukuBindingNavigator);
            this.Name = "FormMasterBuku";
            this.Text = "FormMasterBuku";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMasterBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_bukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_bukuBindingNavigator)).EndInit();
            this.tabel_bukuBindingNavigator.ResumeLayout(false);
            this.tabel_bukuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_bukuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource tabel_bukuBindingSource;
        private perpustakaanDataSetTableAdapters.tabel_bukuTableAdapter tabel_bukuTableAdapter;
        private perpustakaanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabel_bukuBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabel_bukuBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabel_bukuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nama_bukuTextBox;
        private System.Windows.Forms.TextBox penerbit_bukuTextBox;
        private System.Windows.Forms.TextBox stok_bukuTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_pencarian;
    }
}