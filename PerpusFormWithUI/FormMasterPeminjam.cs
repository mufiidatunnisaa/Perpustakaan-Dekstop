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
    public partial class FormMasterPeminjam : Form
    {
        public FormMasterPeminjam()
        {
            InitializeComponent();
        }

        private void tabel_peminjamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabel_peminjamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perpustakaanDataSet);

        }

        private void FormMasterPeminjam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.tabel_peminjam' table. You can move, or remove it, as needed.
            this.tabel_peminjamTableAdapter.Fill(this.perpustakaanDataSet.tabel_peminjam);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tabel_peminjamDataGridView.DataSource;
            bs.Filter = "nama_peminjam like '%" + textBox_pencarian.Text + "%'";
            tabel_peminjamDataGridView.DataSource = bs;
        }
    }
}
