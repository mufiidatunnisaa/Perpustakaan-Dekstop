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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuTileButton_admin_Click(object sender, EventArgs e)
        {
            FormLoginPegawai buka1 = new FormLoginPegawai();
            buka1.Show();
            this.Hide();

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            FormLoginMahasiswa mhs = new FormLoginMahasiswa();
            this.Hide();
            mhs.Show();
        }
    }
}
