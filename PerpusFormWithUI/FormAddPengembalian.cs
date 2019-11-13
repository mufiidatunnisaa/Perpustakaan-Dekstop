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
    public partial class FormAddPengembalian : Form
    {
        public FormAddPengembalian()
        {
            InitializeComponent();
        }

        private void FormAddPengembalian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.tabel_transaksi_peminjaman' table. You can move, or remove it, as needed.
            this.tabel_transaksi_peminjamanTableAdapter.Fill(this.perpustakaanDataSet.tabel_transaksi_peminjaman);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contex = new perpustakaanEntities239();
            var id_peminjaman = Convert.ToInt32(comboBox_id_peminjaman.SelectedValue);
            var tanggal_kembali = dateTimePicker_tanggal_kembali.Value;
            var transaksi = (from a in contex.tabel_transaksi_peminjaman where a.id_peminjaman == id_peminjaman select a).Single();
            int result = DateTime.Compare(transaksi.tanggal_harus_kembali, tanggal_kembali);
            if (result >= 0)
            {
                label_denda.Text = "0";

            }
            else
            {
                label_denda.Text = "5000";
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            var contex = new perpustakaanEntities239();
            var id_peminjaman = Convert.ToInt32(comboBox_id_peminjaman.SelectedValue);
            var transaksi = (from a in contex.tabel_transaksi_peminjaman where a.id_peminjaman == id_peminjaman select a).Single();
            int id_buku = transaksi.id_buku;
            var buku = (from a in contex.tabel_buku where a.id_buku == id_buku select a).Single();
            tabel_pengembalian kembali = new tabel_pengembalian();
            if (transaksi.status == 0)
            {
                transaksi.status = 1;
                buku.stok_buku = buku.stok_buku + 1;
                kembali.id_peminjaman = Convert.ToInt32(comboBox_id_peminjaman.SelectedValue);
                kembali.tanggal_kembali = dateTimePicker_tanggal_kembali.Value.Date;
                kembali.denda = Convert.ToInt32(label_denda.Text);
                contex.tabel_pengembalian.Add(kembali);
                MessageBox.Show("Transaksi Berhasil");
            }
            else
            {
                MessageBox.Show("Maaf, buku sudah dikembalikan");
            }
            contex.SaveChanges();
            FormPengembalian kembalian = new FormPengembalian();
            this.Hide();
            kembalian.Show();

        }
    }
}
