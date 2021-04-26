using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBilSatu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBilDua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBilSatu.Clear();
            txtBilDua.Clear();
            txtHasil.Text = "";

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBilSatu.Text) || string.IsNullOrEmpty(txtBilDua.Text))
            {
                MessageBox.Show("Masukan bilangan terlebih dahulu!");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.txtBilSatu.Text);
                b = float.Parse(this.txtBilDua.Text);
                c = a + b;
                this.txtHasil.Text = c.ToString();
            }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBilSatu.Text) || string.IsNullOrEmpty(txtBilDua.Text))
            {
                MessageBox.Show("Masukan bilangan terlebih dahulu!");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.txtBilSatu.Text);
                b = float.Parse(this.txtBilDua.Text);
                c = a - b;
                this.txtHasil.Text = c.ToString();
            }
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBilSatu.Text) || string.IsNullOrEmpty(txtBilDua.Text))
            {
                MessageBox.Show("Masukan bilangan terlebih dahulu!");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.txtBilSatu.Text);
                b = float.Parse(this.txtBilDua.Text);
                c = a * b;
                this.txtHasil.Text = c.ToString();
            }
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBilSatu.Text) || string.IsNullOrEmpty(txtBilDua.Text))
            {
                MessageBox.Show("Masukan bilangan terlebih dahulu!");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.txtBilSatu.Text);
                b = float.Parse(this.txtBilDua.Text);
                c = a / b;
                this.txtHasil.Text = c.ToString();
            }
        }

        private void txtHasil_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
