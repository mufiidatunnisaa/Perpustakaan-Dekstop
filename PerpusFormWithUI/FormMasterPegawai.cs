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
    public partial class FormMasterPegawai : Form
    {
        public FormMasterPegawai()
        {
            InitializeComponent();
        }

        private void tabel_pegawaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabel_pegawaiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.perpustakaanDataSet);

        }

        private void FormMasterPegawai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.tabel_pegawai' table. You can move, or remove it, as needed.
            this.tabel_pegawaiTableAdapter.Fill(this.perpustakaanDataSet.tabel_pegawai);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tabel_pegawaiDataGridView.DataSource;
            bs.Filter = "nama_pegawai like '%" + textBox_pencarian.Text + "%'";
            tabel_pegawaiDataGridView.DataSource = bs;
        }
    }
}
