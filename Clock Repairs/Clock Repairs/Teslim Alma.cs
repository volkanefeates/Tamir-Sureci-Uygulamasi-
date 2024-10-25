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
    public partial class Teslim_Alma : Form
    {
        
        public Teslim_Alma()
        {
            InitializeComponent();

        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            pictureBox1.Image = null;   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("İSİM YERİNİ BOŞ BIRAKMAYIN LÜTFEN ");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("SOYİSİM YERİNİ BOŞ BIRAKMAYIN LÜTFEN ");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("TELEFON YERİNİ BOŞ BIRAKMAYIN LÜTFEN ");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("EŞYA YERİNİ BOŞ BIRAKMAYIN LÜTFEN ");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("TAMİR SEBEBİNİ GİRİN LÜTFEN ");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("TAHMİNİ ÜCRETİ GİRİM LÜTFEN ");
            }
            else
            {
                Sabit_Kodlar.conn.Open();

                SqlCommand comm = new SqlCommand("insert into Teslim_Alma(İsim,Soyisim,Telefon,Tamir_Edilecek_Esya,Model,Tamir_Sebebi,Tahmini_Ucret,Tarih_Giris,Resim) values (@name,@lastname,@number,@tee,@model,@ts,@tu,@tg,@resim)", Sabit_Kodlar.conn);

                comm.Parameters.AddWithValue("@name", textBox1.Text.ToString());
                comm.Parameters.AddWithValue("@lastname", textBox2.Text.ToString());
                comm.Parameters.AddWithValue("@number", textBox3.Text.ToString());
                comm.Parameters.AddWithValue("@tee", comboBox1.Text.ToString());
                comm.Parameters.AddWithValue("@model", comboBox2.Text.ToString());
                comm.Parameters.AddWithValue("@ts", textBox4.Text.ToString());
                comm.Parameters.AddWithValue("@tu", textBox5.Text.ToString());
                comm.Parameters.AddWithValue("@tg",Sabit_Kodlar.time);
                comm.Parameters.AddWithValue("@resim",openFileDialog1.FileName );
                comm.ExecuteNonQuery();
                Sabit_Kodlar.conn.Close();
                clear();
                MessageBox.Show("TESLİM ALINDI");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void Teslim_Alma_Load(object sender, EventArgs e)
        {
            Sabit_Kodlar.conn.Open();
            SqlCommand comm = new SqlCommand("SELECT*FROM Model", Sabit_Kodlar.conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read["model"].ToString());
            }
            Sabit_Kodlar.conn.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}



