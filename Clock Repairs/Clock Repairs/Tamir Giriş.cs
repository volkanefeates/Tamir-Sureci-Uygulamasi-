using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Repairs
{
    public partial class Tamir_Giriş : Form
    {
        string temp;
        public Tamir_Giriş()
        {
            InitializeComponent();
        }
        public void fill_table()
        {
            Sabit_Kodlar.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Teslim_Alma", Sabit_Kodlar.conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
            Sabit_Kodlar.conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();
        }

        private void Tamir_Giriş_Load(object sender, EventArgs e)
        {
            fill_table();
            comboBox4.Items.Clear();
            comboBox4.Items.Add("İSİM");
            comboBox4.Items.Add("SOYİSİM");
            comboBox4.Items.Add("TELEFON");
            comboBox4.Items.Add("TAMİR EDİLECEK EŞYA");
            comboBox4.Items.Add("MODEL");

            Sabit_Kodlar.conn.Open();
            SqlCommand comm = new SqlCommand("SELECT*FROM Model", Sabit_Kodlar.conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                comboBox5.Items.Add(read["model"].ToString());
            }
            Sabit_Kodlar.conn.Close();

            Sabit_Kodlar.conn.Open();
            SqlCommand comm1 = new SqlCommand("SELECT*FROM Gonderilecek_Firma", Sabit_Kodlar.conn);
            SqlDataReader read1 = comm1.ExecuteReader();
            while (read1.Read())
            {
                comboBox3.Items.Add(read1["gonderilecek_Firma"].ToString());
            }
            Sabit_Kodlar.conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[9].Value.ToString();  

        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            pictureBox1.Image = null;   
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where İsim like '%" + textBox6.Text + "%'", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where Soyisim like '%" + textBox6.Text + "%'", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();

            }
            else if (comboBox4.SelectedIndex == 2)
            {
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where Telefon like '%" + textBox6.Text + "%'", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where Tamir_Edilecek_Esya like '%" + textBox6.Text + "%'", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
            }
            else if (comboBox4.SelectedIndex == 4)
            {
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where Model like '%" + textBox6.Text + "%'", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Doğru Arama Yapmak İçin Türü Seçin ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBox2.SelectedIndex == -1) 
            { 
                MessageBox.Show("LÜTFEN TAMİR TÜRÜ SEÇİNİZ  ");

            }
            else if (comboBox3.SelectedIndex==-1)
            {
                MessageBox.Show("LÜTFEN GÖNDERİLCEK FİRMAYI SEÇİNİZ");
            }
            else if (textBox1.Text=="")
            {
                MessageBox.Show("LÜTFEN TABLODAN MÜŞTERİ SEÇİN");
            }
            else
            {
                Sabit_Kodlar.conn.Open();
                SqlCommand comm = new SqlCommand("insert into Tamir_Giris(İsim,Soyisim,Telefon,Tamir_Edilecek_Esya,Model,Tamir_Sebebi,Tahmini_Ucret,Tarih_Giris,Tamir_Turu,Gonderilen_Firma,Resim) values (@name,@lastname,@number,@tee,@model,@ts,@tu,@tg,@tt,@gf,@resim)", Sabit_Kodlar.conn);
                comm.Parameters.AddWithValue("@name", textBox1.Text.ToString());
                comm.Parameters.AddWithValue("@lastname", textBox2.Text.ToString());
                comm.Parameters.AddWithValue("@number", textBox3.Text.ToString());
                comm.Parameters.AddWithValue("tee", comboBox1.Text.ToString());
                comm.Parameters.AddWithValue("model", comboBox5.Text.ToString());
                comm.Parameters.AddWithValue("ts", textBox5.Text.ToString());
                comm.Parameters.AddWithValue("tu", textBox4.Text.ToString());
                comm.Parameters.AddWithValue("tg", Sabit_Kodlar.time.ToString());
                comm.Parameters.AddWithValue("tt", comboBox2.Text.ToString());
                comm.Parameters.AddWithValue("gf", comboBox3.Text.ToString());
                comm.Parameters.AddWithValue("@resim", dataGridView1.CurrentRow.Cells[9].Value.ToString());

                comm.ExecuteNonQuery();

                Sabit_Kodlar.conn.Close();

                Sabit_Kodlar.conn.Open();
                SqlCommand command = new SqlCommand("Delete from Teslim_Alma where Tamir_No=@tn", Sabit_Kodlar.conn);
                command.Parameters.AddWithValue("@tn", dataGridView1.CurrentRow.Cells[8].Value.ToString());
                command.ExecuteNonQuery();
                Sabit_Kodlar.conn.Close();

                MessageBox.Show("Tamir Girişi Yapıldı ");

                fill_table();
                clear();
            }
           
        }
    }
}



