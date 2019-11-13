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
    public partial class FormPengembalian : Form
    {
        public FormPengembalian()
        {
            InitializeComponent();
        }

        private void FormPengembalian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.tabel_pengembalian' table. You can move, or remove it, as needed.
            this.tabel_pengembalianTableAdapter.Fill(this.perpustakaanDataSet.tabel_pengembalian);

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormAddPengembalian kembali = new FormAddPengembalian();
            this.Hide();
            kembali.Show();
        }
    }
}
