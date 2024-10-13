using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TUGAS_PERTEMUAN_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string username = "iqbalnafis";
            string password = "0000";

            string inputUsr = textBoxUsername.Text;
            string inputPass = textBoxPassword.Text;

            if (password == inputPass && inputUsr == username)
            {
                Menu mnu = new Menu();
                MessageBox.Show("Login berhasil");

                mnu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }
    }
}