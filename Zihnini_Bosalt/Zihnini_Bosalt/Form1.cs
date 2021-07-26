using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zihnini_Bosalt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-C17ULPC\\SQLEXPRESS;Initial Catalog=Kullanici;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;

            label2.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;

            label3.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;

            label4.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;

            label5.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;

            label6.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;

            label7.BackColor = Color.Transparent;
            label7.Parent = pictureBox1;

            label8.BackColor = Color.Transparent;
            label8.Parent = pictureBox1;

            label9.BackColor = Color.Transparent;
            label9.Parent = pictureBox1;

            label10.BackColor = Color.Transparent;
            label10.Parent = pictureBox1;

            pictureBox26.BackColor = Color.Transparent;
            pictureBox26.Parent = pictureBox1;

            //pictureBox27.BackColor = Color.Transparent;
            //pictureBox27.Parent = pictureBox1;

            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Parent = pictureBox1;

            //this.KulolTableAdapter.Fill(this.personelVeriTabaniDataSet9.Personel_Tablosu);

        }

        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Text == "-1")
            {
                //string[] metin = "Doğarken ağladı insan bu son olsun".Split(' ');
                string [] anaMetin = "bütün hayvanlar bitkiler yaşamak için suya muhtaçtır".Split(' ');

                if (count < anaMetin.Length)
                {
                    label1.Text = anaMetin[count];
                }
                count++;
            }
            if (count == 0)
            {
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
            }
            label4.Text = "" + count;
        }
        public int counter = 4;

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 3;
            timer2 = new Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 1000; 
            timer2.Start();
            label2.Text = counter.ToString();
            button1.Visible = false;
            timer1.Start();
            label9.Visible = false;
            label2.Visible = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == -1)
                timer2.Stop();
            label2.Text = counter.ToString();
            if (label2.Text == "0" || label2.Text == "-1")
            {
                label2.Visible = false;
                //textBox1.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                richTextBox1.Visible = true;
            }
            else
            {
                label2.Visible = true;
            }
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            //label3.Visible = true;
            string anaMetin = "bütün hayvanlar bitkiler yaşamak için suya muhtaçtır";

            //string girilenMetin = textBox1.Text;
            string girilenMetin = richTextBox1.Text;
            int dogru = anaMetin.Split(' ').Intersect(girilenMetin.Split(' ')).Count();
            int yanlis = anaMetin.Split(' ').Except(girilenMetin.Split(' ')).Count();
            //MessageBox.Show("D:{0}, Y:{1}\n" + dogru + "\n" + yanlis);

            label5.Text = ""+dogru;
            label6.Text = ""+yanlis;
            //label3.Text = "Tebrikler";
            //    label3.Text = "Yanlış";
            label8.Visible = true;
            label7.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count = 0;
            counter = 4;
            timer1.Stop();
            //timer1.Start();
            //timer2.Start();
            label1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            //textBox1.Visible = false;
            label3.Visible = false;
            //richTextBox1.Visible = false;
            button1.Visible = true;
            richTextBox1.Clear();
            //textBox1.Clear();
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
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

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //this.Close();
            //form1.Show();
            //Skor skor = new Skor();
            //this.Close();
            //skor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-C17ULPC\\SQLEXPRESS;Initial Catalog=Kullanici;Integrated Security=True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLNesne (KullaniciAdı,Dogru,Yanlis) values (@a1,@a2,@a3)", baglanti);
            komut.Parameters.AddWithValue("@a1", label10.Text);
            komut.Parameters.AddWithValue("@a2", label5.Text);
            komut.Parameters.AddWithValue("@a3", label6.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        //private void skorTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Skor skor = new Skor();
        //    this.Close();
        //    skor.Show();
        //}

        private void bizeUlaşınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iletisim ilet = new Iletisim();
            this.Hide();
            ilet.Show();
        }
    }
}
