using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUGAS_PERTEMUAN_9
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void jumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void tombolTotal_Click(object sender, EventArgs e)
        {
            int pilihanValue;

            if (int.TryParse(pilihan.Text, out pilihanValue))
            {
                hitungHarga(pilihanValue);
            }
            else
            {
                MessageBox.Show("Input tidak valid, masukkan angka yang benar.");
            }
        }

        public void hitungHarga(int pilih)
        {
            int banyakk = int.Parse(jumlah.Text);

            int totall;

            switch (pilih)
            {
                case 1:
                    totall = banyakk * 5000;
                    total.Text = totall.ToString();
                    break;
                case 2:
                    totall = banyakk * 4000;
                    total.Text = totall.ToString();
                    break;
                case 3:
                    totall = banyakk * 5000;
                    total.Text = totall.ToString();
                    break;
                case 4:
                    totall = banyakk * 4000;
                    total.Text = totall.ToString();
                    break;
                default:
                    MessageBox.Show("Pilihan tidak tersedia.");
                    break;
            }

        }


        private void tombolKeluar_Click(object sender, EventArgs e)
        {
            Form1 loginn = new Form1();
            loginn.Show();
            this.Close();
        }

        private void pilihan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
