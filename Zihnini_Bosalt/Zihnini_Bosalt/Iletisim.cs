using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zihnini_Bosalt
{
    public partial class Iletisim : Form
    {
        public Iletisim()
        {
            InitializeComponent();
        }

        private void Iletisim_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Programdan çıkmak istediğine emin misin?", "Dikkat", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Process.Start("http://www.gmail.com");
        //}

        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Process.Start("http://www.facebook.com");

        //}

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Process.Start("http://www.instagram.com");

        //}

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/#inbox?compose=new");

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/FatihAydinn");
        }
    }
}
