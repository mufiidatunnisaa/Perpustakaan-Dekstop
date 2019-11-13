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
    public partial class FormAddPeminjaman : Form
    {
        public FormAddPeminjaman()
        {
            InitializeComponent();
        }

        private void FormAddPeminjaman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.tabel_buku' table. You can move, or remove it, as needed.
            this.tabel_bukuTableAdapter.Fill(this.perpustakaanDataSet.tabel_buku);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.tabel_peminjam' table. You can move, or remove it, as needed.
            this.tabel_peminjamTableAdapter.Fill(this.perpustakaanDataSet.tabel_peminjam);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.tabel_pegawai' table. You can move, or remove it, as needed.
            this.tabel_pegawaiTableAdapter.Fill(this.perpustakaanDataSet.tabel_pegawai);

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            var contex = new perpustakaanEntities239();
            tabel_transaksi_peminjaman pinjam = new tabel_transaksi_peminjaman();
            pinjam.id_buku = Convert.ToInt32(comboBox_id_buku.SelectedValue);
            pinjam.id_pegawai = Convert.ToInt32(comboBox_id_pegawai.SelectedValue);
            pinjam.id_peminjam = Convert.ToInt32(comboBox_id_peminjam.SelectedValue);
            pinjam.tanggal_peminjaman = dateTimePicker_tanggal_peminjaman.Value.Date;
            pinjam.tanggal_harus_kembali = dateTimePicker_tanggal_harus_kembali.Value.Date;
            pinjam.status = 0;
            int id_buku = Convert.ToInt32(comboBox_id_buku.SelectedValue);
            var cek_stok = (from a in contex.tabel_buku where a.id_buku == id_buku select a).Single();
            if (cek_stok.stok_buku != 0)
            {
                cek_stok.stok_buku = cek_stok.stok_buku - 1;
                contex.tabel_transaksi_peminjaman.Add(pinjam);

            }
            else
            {
                MessageBox.Show("Stok Buku Kosong!!");
            }
            contex.SaveChanges();
            MessageBox.Show("Data berhasil disimpan");
            FormTransaksiPeminjaman fpinjam = new FormTransaksiPeminjaman();
            this.Hide();
            fpinjam.Show();
        }
    }
}
