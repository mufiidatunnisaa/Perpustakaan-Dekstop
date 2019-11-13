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
    public partial class FormTransaksiStokBuku : Form
    {
        public FormTransaksiStokBuku()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            tabel_buku buku = new tabel_buku();
            var contex = new perpustakaanEntities239();
            string nama_buku = textBox_nama_buku.Text;
            string penerbit_buku = textBox_penerbit_buku.Text;
            int stok_buku = Convert.ToInt32(textBox_stok_masuk.Text);
            var add = (from a in contex.tabel_buku where a.nama_buku == nama_buku && a.penerbit_buku == penerbit_buku select a).SingleOrDefault();
            if(add != null)
            {
                add.stok_buku = add.stok_buku + stok_buku;
                contex.SaveChanges();
                MessageBox.Show("Data Berhasil Ditambahkan");
            }
            else
            {
                buku.nama_buku = nama_buku;
                buku.penerbit_buku = penerbit_buku;
                buku.stok_buku = stok_buku;
                contex.tabel_buku.Add(buku);
                contex.SaveChanges();
                MessageBox.Show("Simpan Berhasil !!");
            }
        }
    }
}
