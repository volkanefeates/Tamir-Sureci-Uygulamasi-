using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Repairs
{
    
    public partial class Şifre_Düzenleme : Form
    {
        
        public Şifre_Düzenleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();
        }
       
        private void Şifre_Düzenleme_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sabit_Kodlar.conn.Open();
            SqlCommand comm = new SqlCommand("Update Kullanici_Giris set Kullanici_adi=@ad,Kullanici_sifre=@sifre where no=@no", Sabit_Kodlar.conn);
            comm.Parameters.AddWithValue("@ad", textBox1.Text);
            comm.Parameters.AddWithValue("@sifre", textBox2.Text);
            comm.Parameters.AddWithValue("@no", "1");
            comm.ExecuteNonQuery();
            
            Sabit_Kodlar.conn.Close();
            textBox1.Clear  ();
            textBox2.Clear ();  
            MessageBox.Show("BAŞARIYLA DEĞİŞTİRİLDİ ");
        }
    }
}
