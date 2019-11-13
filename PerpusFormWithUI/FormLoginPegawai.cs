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
    public partial class FormLoginPegawai : Form
    {
        public FormLoginPegawai()
        {
            InitializeComponent();
        }

      

        private void button_login_Click(object sender, EventArgs e)
        {
            var contex = new perpustakaanEntities239();
            string username = username_Textbox.Text;
            string password = password_Textbox.Text;
            var login = (from a in contex.tabel_pegawai where a.nama_pegawai == username && a.password_pegawai == password select a).SingleOrDefault();
            if (login != null)
            {
                MessageBox.Show("Login Berhasil !!");
                FormHalamanUtamaAdmin bukahalaman = new FormHalamanUtamaAdmin();
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
            Form1 buka = new Form1();
            this.Hide();
            buka.Show();
        }
    }
}
