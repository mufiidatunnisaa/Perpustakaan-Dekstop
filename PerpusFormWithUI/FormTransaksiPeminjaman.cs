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
    public partial class FormTransaksiPeminjaman : Form
    {
        public FormTransaksiPeminjaman()
        {
            InitializeComponent();
        }

        private void FormTransaksiPeminjaman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.tabel_transaksi_peminjaman' table. You can move, or remove it, as needed.
            this.tabel_transaksi_peminjamanTableAdapter.Fill(this.perpustakaanDataSet.tabel_transaksi_peminjaman);

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormAddPeminjaman tambah = new FormAddPeminjaman();
            this.Hide();
            tambah.Show();
        }
    }
}
