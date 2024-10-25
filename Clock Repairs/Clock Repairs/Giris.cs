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

namespace Clock_Repairs
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("LÜTFEN BOŞ BIRAKMAYINIZ");
            }
            else
            {
                Sabit_Kodlar.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sabit_Kodlar.conn;
                cmd.CommandText = "select * from Kullanici_Giris where Kullanici_adi='" + textBox1.Text + "'And Kullanici_sifre='" + textBox2.Text + "'";

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Menü menü = new Menü();
                    menü.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ADMİN ADI VEYA ŞİFRE YANLIŞ TEKRAR DENEYİNİZ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                Sabit_Kodlar.conn.Close();
            }
            
        }
    }
}
