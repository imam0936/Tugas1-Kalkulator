using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAplikasiKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /* private int penambahan(int a, int b)
        {
            return a + b;
        }
        private int pengurangan(int a, int b)
        {
            return a - b;
        }
        private int perkalian(int a, int b)
        {
            return a * b;
        }
        private int pembagian(int a, int b)
        {
            return a / b;
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHitung_Click(object sender, EventArgs e)
        {
            Double NilaiA, NilaiB, Hasil;

            if (Operasi.SelectedIndex == 0)
            {
                NilaiA = Double.Parse(txtNilaiA.Text);
                NilaiB = Double.Parse(txtNilaiB.Text);
                Hasil = NilaiA + NilaiB;
                txtHasil.Text = Hasil.ToString();
            }
            else if (Operasi.SelectedIndex == 1)
            {
                NilaiA = Double.Parse(txtNilaiA.Text);
                NilaiB = Double.Parse(txtNilaiB.Text);
                Hasil = NilaiA - NilaiB;
                txtHasil.Text = Hasil.ToString();
            }
            else if (Operasi.SelectedIndex == 2)
            {
                NilaiA = Double.Parse(txtNilaiA.Text);
                NilaiB = Double.Parse(txtNilaiB.Text);
                Hasil = NilaiA * NilaiB;
                txtHasil.Text = Hasil.ToString();
            }
            else if (Operasi.SelectedIndex == 3)
            {
                NilaiA = Double.Parse(txtNilaiA.Text);
                NilaiB = Double.Parse(txtNilaiB.Text);
                Hasil = NilaiA / NilaiB;
                txtHasil.Text = Hasil.ToString();
            }
        }

        private void Operasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
