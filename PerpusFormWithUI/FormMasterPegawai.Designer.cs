namespace PerpusFormWithUI
{
    partial class FormMasterPegawai
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
            System.Windows.Forms.Label nama_pegawaiLabel;
            System.Windows.Forms.Label password_pegawaiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMasterPegawai));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.perpustakaanDataSet = new PerpusFormWithUI.perpustakaanDataSet();
            this.tabel_pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabel_pegawaiTableAdapter = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.tabel_pegawaiTableAdapter();
            this.tableAdapterManager = new PerpusFormWithUI.perpustakaanDataSetTableAdapters.TableAdapterManager();
            this.tabel_pegawaiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabel_pegawaiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabel_pegawaiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pegawaiTextBox = new System.Windows.Forms.TextBox();
            this.password_pegawaiTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_pencarian = new System.Windows.Forms.TextBox();
            nama_pegawaiLabel = new System.Windows.Forms.Label();
            password_pegawaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_pegawaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_pegawaiBindingNavigator)).BeginInit();
            this.tabel_pegawaiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_pegawaiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nama_pegawaiLabel
            // 
            nama_pegawaiLabel.AutoSize = true;
            nama_pegawaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nama_pegawaiLabel.Location = new System.Drawing.Point(20, 173);
            nama_pegawaiLabel.Name = "nama_pegawaiLabel";
            nama_pegawaiLabel.Size = new System.Drawing.Size(116, 20);
            nama_pegawaiLabel.TabIndex = 14;
            nama_pegawaiLabel.Text = "nama pegawai:";
            // 
            // password_pegawaiLabel
            // 
            password_pegawaiLabel.AutoSize = true;
            password_pegawaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            password_pegawaiLabel.Location = new System.Drawing.Point(24, 228);
            password_pegawaiLabel.Name = "password_pegawaiLabel";
            password_pegawaiLabel.Size = new System.Drawing.Size(144, 20);
            password_pegawaiLabel.TabIndex = 15;
            password_pegawaiLabel.Text = "password pegawai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(1, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Master Pegawai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(163, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "DATEEB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(1, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "PERPUSTAKAAN";
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabel_pegawaiBindingSource
            // 
            this.tabel_pegawaiBindingSource.DataMember = "tabel_pegawai";
            this.tabel_pegawaiBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // tabel_pegawaiTableAdapter
            // 
            this.tabel_pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabel_bukuTableAdapter = null;
            this.tableAdapterManager.tabel_pegawaiTableAdapter = this.tabel_pegawaiTableAdapter;
            this.tableAdapterManager.tabel_peminjamTableAdapter = null;
            this.tableAdapterManager.tabel_pengembalianTableAdapter = null;
            this.tableAdapterManager.tabel_transaksi_peminjamanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PerpusFormWithUI.perpustakaanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabel_pegawaiBindingNavigator
            // 
            this.tabel_pegawaiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabel_pegawaiBindingNavigator.BindingSource = this.tabel_pegawaiBindingSource;
            this.tabel_pegawaiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabel_pegawaiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabel_pegawaiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabel_pegawaiBindingNavigatorSaveItem});
            this.tabel_pegawaiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabel_pegawaiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabel_pegawaiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabel_pegawaiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabel_pegawaiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabel_pegawaiBindingNavigator.Name = "tabel_pegawaiBindingNavigator";
            this.tabel_pegawaiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabel_pegawaiBindingNavigator.Size = new System.Drawing.Size(580, 25);
            this.tabel_pegawaiBindingNavigator.TabIndex = 14;
            this.tabel_pegawaiBindingNavigator.Text = "bindingNavigator1";
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
            // tabel_pegawaiBindingNavigatorSaveItem
            // 
            this.tabel_pegawaiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabel_pegawaiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabel_pegawaiBindingNavigatorSaveItem.Image")));
            this.tabel_pegawaiBindingNavigatorSaveItem.Name = "tabel_pegawaiBindingNavigatorSaveItem";
            this.tabel_pegawaiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabel_pegawaiBindingNavigatorSaveItem.Text = "Save Data";
            this.tabel_pegawaiBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabel_pegawaiBindingNavigatorSaveItem_Click);
            // 
            // tabel_pegawaiDataGridView
            // 
            this.tabel_pegawaiDataGridView.AutoGenerateColumns = false;
            this.tabel_pegawaiDataGridView.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.tabel_pegawaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel_pegawaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tabel_pegawaiDataGridView.DataSource = this.tabel_pegawaiBindingSource;
            this.tabel_pegawaiDataGridView.Location = new System.Drawing.Point(12, 269);
            this.tabel_pegawaiDataGridView.Name = "tabel_pegawaiDataGridView";
            this.tabel_pegawaiDataGridView.Size = new System.Drawing.Size(362, 220);
            this.tabel_pegawaiDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pegawai";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_pegawai";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama_pegawai";
            this.dataGridViewTextBoxColumn2.HeaderText = "nama_pegawai";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password_pegawai";
            this.dataGridViewTextBoxColumn3.HeaderText = "password_pegawai";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // nama_pegawaiTextBox
            // 
            this.nama_pegawaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabel_pegawaiBindingSource, "nama_pegawai", true));
            this.nama_pegawaiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_pegawaiTextBox.Location = new System.Drawing.Point(186, 173);
            this.nama_pegawaiTextBox.Name = "nama_pegawaiTextBox";
            this.nama_pegawaiTextBox.Size = new System.Drawing.Size(188, 26);
            this.nama_pegawaiTextBox.TabIndex = 15;
            // 
            // password_pegawaiTextBox
            // 
            this.password_pegawaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabel_pegawaiBindingSource, "password_pegawai", true));
            this.password_pegawaiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_pegawaiTextBox.Location = new System.Drawing.Point(186, 228);
            this.password_pegawaiTextBox.Name = "password_pegawaiTextBox";
            this.password_pegawaiTextBox.Size = new System.Drawing.Size(188, 26);
            this.password_pegawaiTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(301, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cari Buku";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_pencarian
            // 
            this.textBox_pencarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pencarian.Location = new System.Drawing.Point(12, 105);
            this.textBox_pencarian.Name = "textBox_pencarian";
            this.textBox_pencarian.Size = new System.Drawing.Size(281, 29);
            this.textBox_pencarian.TabIndex = 27;
            // 
            // FormMasterPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(580, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_pencarian);
            this.Controls.Add(password_pegawaiLabel);
            this.Controls.Add(this.password_pegawaiTextBox);
            this.Controls.Add(nama_pegawaiLabel);
            this.Controls.Add(this.nama_pegawaiTextBox);
            this.Controls.Add(this.tabel_pegawaiDataGridView);
            this.Controls.Add(this.tabel_pegawaiBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormMasterPegawai";
            this.Text = "FormMasterPegawai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMasterPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_pegawaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_pegawaiBindingNavigator)).EndInit();
            this.tabel_pegawaiBindingNavigator.ResumeLayout(false);
            this.tabel_pegawaiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_pegawaiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource tabel_pegawaiBindingSource;
        private perpustakaanDataSetTableAdapters.tabel_pegawaiTableAdapter tabel_pegawaiTableAdapter;
        private perpustakaanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabel_pegawaiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabel_pegawaiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabel_pegawaiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox nama_pegawaiTextBox;
        private System.Windows.Forms.TextBox password_pegawaiTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_pencarian;
    }
}