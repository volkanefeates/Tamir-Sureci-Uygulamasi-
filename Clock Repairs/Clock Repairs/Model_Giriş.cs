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
    public partial class Model_Giriş : Form
    {
        public Model_Giriş()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();
        }
        public void fill_list1()
        {
            Sabit_Kodlar.conn.Open();
            SqlCommand comm = new SqlCommand("SELECT*FROM Model", Sabit_Kodlar.conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                listView1.Items.Add(read["model"].ToString());
            }
            Sabit_Kodlar.conn.Close();
        }
        public void fill_combo1()
        {

            Sabit_Kodlar.conn.Open();
            SqlCommand comm = new SqlCommand("SELECT*FROM Model", Sabit_Kodlar.conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["model"].ToString());
            }
            Sabit_Kodlar.conn.Close();

        }
        public void fill_list2()
        {

            Sabit_Kodlar.conn.Open();
            SqlCommand comm = new SqlCommand("SELECT*FROM Gonderilecek_Firma", Sabit_Kodlar.conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                listView2.Items.Add(read["gonderilecek_Firma"].ToString());
            }
            Sabit_Kodlar.conn.Close();

        }
        public void fill_combo2()
        {

            Sabit_Kodlar.conn.Open();
            SqlCommand comm = new SqlCommand("SELECT*FROM Gonderilecek_Firma", Sabit_Kodlar.conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read["gonderilecek_Firma"].ToString());
            }
            Sabit_Kodlar.conn.Close();

        }
        private void Model_Giriş_Load(object sender, EventArgs e)
        {
            fill_list1();
            fill_combo1();
            fill_list2();
            fill_combo2();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            do
            {
                Sabit_Kodlar.conn.Open();
                SqlCommand comm1 = new SqlCommand("select * from Model", Sabit_Kodlar.conn);
                SqlDataReader reader = comm1.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text = reader["model"].ToString();
                    if (textBox1.Text == label1.Text)
                    {
                        MessageBox.Show("BU MODEL KAYITLIDIR");
                        textBox1.Clear();
                    }

                }
                Sabit_Kodlar.conn.Close();
            } while (sayac != 0);

            if (textBox1.Text == "")
            {
                MessageBox.Show("LÜTFEN MODEL GİRİNİZ ");
            }
            else
            {
                Sabit_Kodlar.conn.Open();
                SqlCommand comm = new SqlCommand("insert into Model(model) values (@model)", Sabit_Kodlar.conn);
                comm.Parameters.AddWithValue("@model", textBox1.Text.ToString());
                comm.ExecuteNonQuery();
                Sabit_Kodlar.conn.Close();
                MessageBox.Show("EKLENDİ ");
                textBox1.Clear();
                listView1.Items.Clear();
                comboBox1.Items.Clear();
                fill_list1();
                fill_combo1();
                comboBox1.SelectedIndex = -1;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            
            int sayac = 0;
            do
            {
                Sabit_Kodlar.conn.Open();
                SqlCommand comm1 = new SqlCommand("select * from Gonderilecek_Firma", Sabit_Kodlar.conn);
                SqlDataReader reader = comm1.ExecuteReader();
                while (reader.Read())
                {
                    label1.Text = reader["gonderilecek_Firma"].ToString();
                    if (textBox2.Text ==label1.Text)
                    {
                        MessageBox.Show("BU MODEL KAYITLIDIR");
                        textBox2.Clear();
                    }

                }
                Sabit_Kodlar.conn.Close();
            } while (sayac!=0);
            
          
            if (textBox2.Text == "")
            {
                MessageBox.Show("LÜTFEN GÖNDERİLECEK FİRMA GİRİNİZ ");

            }
            else
            {
                Sabit_Kodlar.conn.Open();
                SqlCommand comm2 = new SqlCommand("insert into Gonderilecek_Firma(gonderilecek_Firma) values (@gonderilecek_Firma)", Sabit_Kodlar.conn);
                comm2.Parameters.AddWithValue("@gonderilecek_Firma", textBox2.Text.ToString());
                comm2.ExecuteNonQuery();
                Sabit_Kodlar.conn.Close();
                MessageBox.Show("EKLENDİ ");
                textBox2.Clear();
                comboBox2.Items.Clear();
                listView2.Items.Clear();
                fill_list2();
                fill_combo2();
                comboBox2.SelectedIndex = -1;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("LÜTFEN SİLİNCEK MODELİ SEÇİNİZ");
            }
            else
            {
                Sabit_Kodlar.conn.Open();
                SqlCommand comm = new SqlCommand("Delete from Model where model=@model", Sabit_Kodlar.conn);
                comm.Parameters.AddWithValue("@model", comboBox1.Text.ToString());
                comm.ExecuteNonQuery();
                Sabit_Kodlar.conn.Close();
                MessageBox.Show("SİLİNDİ");
                textBox1.Clear();
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                listView1.Items.Clear();
                fill_list1();
                fill_combo1();
                comboBox1.SelectedIndex = -1;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("LÜTFEN SİLİNCEK FİRMA SEÇİNİZ");
            }
            else
            {
                Sabit_Kodlar.conn.Open();
                SqlCommand comm = new SqlCommand("Delete from Gonderilecek_Firma where gonderilecek_Firma=@gonderilecek_Firma", Sabit_Kodlar.conn);
                comm.Parameters.AddWithValue("@gonderilecek_Firma", comboBox2.Text.ToString());
                comm.ExecuteNonQuery();
                Sabit_Kodlar.conn.Close();
                MessageBox.Show("SİLİNDİ");
                textBox2.Clear();
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                listView2.Items.Clear();
                fill_list2();
                fill_combo2();
                comboBox2.SelectedIndex = -1;
            }
        }
    }
}
