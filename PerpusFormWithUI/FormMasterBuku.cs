using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerpusFormWithUI
{
    public partial class FormMasterBuku : Form
    {
        public FormMasterBuku()
        {
            InitializeComponent();
        }

        private void tabel_bukuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabel_bukuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perpustakaanDataSet);

        }

        private void FormMasterBuku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.tabel_buku' table. You can move, or remove it, as needed.
            this.tabel_bukuTableAdapter.Fill(this.perpustakaanDataSet.tabel_buku);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tabel_bukuDataGridView.DataSource;
            bs.Filter = "nama_buku like '%" + textBox_pencarian.Text + "%'";
            tabel_bukuDataGridView.DataSource = bs;
        }
    }
}
