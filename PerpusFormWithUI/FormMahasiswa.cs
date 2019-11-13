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
    public partial class FormMahasiswa : Form
    {
        public FormMahasiswa()
        {
            InitializeComponent();
        }

        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.tabel_buku' table. You can move, or remove it, as needed.
            this.tabel_bukuTableAdapter.Fill(this.perpustakaanDataSet.tabel_buku);

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = bunifuCustomDataGrid1.DataSource;
            bs.Filter = "nama_buku like '%" + textBox_pencarian.Text + "%'";
            bunifuCustomDataGrid1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
