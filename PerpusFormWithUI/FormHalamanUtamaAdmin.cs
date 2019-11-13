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
    public partial class FormHalamanUtamaAdmin : Form
    {
        public FormHalamanUtamaAdmin()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton_tabel_buku_Click(object sender, EventArgs e)
        {
            FormMasterBuku buku = new FormMasterBuku();
            buku.MdiParent = this;
            buku.Show();
            buku.Focus();
        }

        private void bunifuFlatButton_tabel_pegawai_Click(object sender, EventArgs e)
        {
            FormMasterPegawai pegawai = new FormMasterPegawai();
            pegawai.MdiParent = this;
            pegawai.Show();
            pegawai.Focus();
        }

        private void bunifuFlatButton_tabel_peminjam_Click(object sender, EventArgs e)
        {
            FormMasterPeminjam peminjam = new FormMasterPeminjam();
            peminjam.MdiParent = this;
            peminjam.Show();
            peminjam.Focus();
        }

        private void bunifuFlatButton_transaksi_stok_buku_Click(object sender, EventArgs e)
        {
            FormTransaksiStokBuku stok = new FormTransaksiStokBuku();
            stok.MdiParent = this;
            stok.Show();
            stok.Focus();
        }

        private void bunifuFlatButton_transaksi_peminjaman_Click(object sender, EventArgs e)
        {
            FormTransaksiPeminjaman pinjam = new FormTransaksiPeminjaman();
            pinjam.MdiParent = this;
            pinjam.Show();
            pinjam.Focus();
        }

        private void bunifuFlatButton_transaksi_pengembalian_Click(object sender, EventArgs e)
        {
            FormPengembalian kembali = new FormPengembalian();
            kembali.MdiParent = this;
            kembali.Show();
            kembali.Focus();
        }
    }
}
