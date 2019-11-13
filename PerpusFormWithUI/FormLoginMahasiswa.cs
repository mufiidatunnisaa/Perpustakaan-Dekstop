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
    public partial class FormLoginMahasiswa : Form
    {
        public FormLoginMahasiswa()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var contex = new perpustakaanEntities239();
            string username = username_Textbox.Text;
            string password = password_Textbox.Text;
            var login = (from a in contex.tabel_peminjam where a.nama_peminjam == username && a.password_peminjam == password select a).SingleOrDefault();
            if (login != null)
            {
                MessageBox.Show("Login Berhasil !!");
                FormMahasiswa bukahalaman = new FormMahasiswa();
                bukahalaman.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Anda Salah");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Form1 bf = new Form1();
            this.Hide();
            bf.Show();
        }
    }
}
