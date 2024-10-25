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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clock_Repairs
{
    public partial class Teslim_Etme : Form
    {
        public Teslim_Etme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();
        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            pictureBox1.Image = null;
        }
        public void fill_table()
        {
            Sabit_Kodlar.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Tamir_Bitir", Sabit_Kodlar.conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
            Sabit_Kodlar.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("LÜTFEN TABLODAN MÜŞTERİYİ SEÇİNİZ");
            }
            else
            {
                Sabit_Kodlar.conn.Open();
                SqlCommand comm = new SqlCommand("insert into Teslim_Etme(İsim,Soyisim,Telefon,Tamir_Edilecek_Esya,Model,Tamir_Sebebi,Tahmini_Ucret,Tarih_Giris,Tamir_Turu,Gonderilen_Firma,Tarih_Cikis,Odenmesi_Gereken_Ucret,Resim) values (@name,@lastname,@number,@tee,@model,@ts,@tu,@tg,@tt,@gf,@tc,@ou,@resim)", Sabit_Kodlar.conn);
                comm.Parameters.AddWithValue("@name", textBox1.Text.ToString());
                comm.Parameters.AddWithValue("@lastname", textBox2.Text.ToString());
                comm.Parameters.AddWithValue("@number", textBox3.Text.ToString());
                comm.Parameters.AddWithValue("@tee", comboBox1.Text.ToString());
                comm.Parameters.AddWithValue("@model", comboBox5.Text.ToString());
                comm.Parameters.AddWithValue("@ts", textBox5.Text.ToString());
                comm.Parameters.AddWithValue("@tu", textBox4.Text.ToString());
                comm.Parameters.AddWithValue("@tg", textBox8.Text.ToString());
                comm.Parameters.AddWithValue("@tt", comboBox2.Text.ToString());
                comm.Parameters.AddWithValue("@gf", comboBox3.Text.ToString());
                comm.Parameters.AddWithValue("@ou", textBox6.Text.ToString());
                comm.Parameters.AddWithValue("@tc", Sabit_Kodlar.time);
                comm.Parameters.AddWithValue("@resim", dataGridView1.CurrentRow.Cells[12].Value.ToString());
                comm.ExecuteNonQuery();
                Sabit_Kodlar.conn.Close();

                Sabit_Kodlar.conn.Open();
                SqlCommand command = new SqlCommand("Delete from Tamir_Bitir where Tamir_No=@tn", Sabit_Kodlar.conn);
                command.Parameters.AddWithValue("@tn", dataGridView1.CurrentRow.Cells[11].Value.ToString());
                command.ExecuteNonQuery();
                Sabit_Kodlar.conn.Close();

                MessageBox.Show("TESLİM EDİLDİ");

                fill_table();
                clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[12].Value.ToString();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where İsim like '%" + textBox7.Text + "%'", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Soyisim like '%" + textBox7.Text + "%'", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();

            }
            else if (comboBox4.SelectedIndex == 2)
            {
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Telefon like '%" + textBox7.Text + "%'", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Tamir_Edilecek_Esya like '%" + textBox7.Text + "%'", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
            }
            else if (comboBox4.SelectedIndex == 4)
            {
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Model like '%" + textBox7.Text + "%'", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
            }
            else if (comboBox4.SelectedIndex == 5)
            {
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Gonderilen_Firma like '%" + textBox7.Text + "%'", Sabit_Kodlar.conn);
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

        private void Teslim_Etme_Load(object sender, EventArgs e)
        {
            fill_table(); 

            comboBox4.Items.Clear();
            comboBox4.Items.Add("İSİM");
            comboBox4.Items.Add("SOYİSİM");
            comboBox4.Items.Add("TELEFON");
            comboBox4.Items.Add("TAMİR EDİLECEK EŞYA");
            comboBox4.Items.Add("MODEL");
            comboBox4.Items.Add("GÖNDERİLECEK FİRMA");
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
