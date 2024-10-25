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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Clock_Repairs
{
    public partial class Düzenleme : Form
    {
        public Düzenleme()
        {
            InitializeComponent();
        }
        public void sorgula_clear() { textBox1.Text = null; comboBox1.SelectedIndex = -1; }
       
        private void button5_Click(object sender, EventArgs e)
        {

            if (comboBox6.SelectedIndex == 0)
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where İsim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where Soyisim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();

                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where Telefon like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();

                }
                else if (comboBox4.SelectedIndex == 3)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where Tamir_Edilecek_Esya like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();

                }
                else if (comboBox4.SelectedIndex == 4)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where Model like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else
                {
                    MessageBox.Show("Lütfen Doğru Arama Yapmak İçin Türü Seçin ");
                }
            }
            else if (comboBox6.SelectedIndex == 1)
            {

                if (comboBox4.SelectedIndex == 0)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Gİris where İsim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Gİris where Soyisim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();

                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Gİris where Telefon like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 3)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Gİris where Tamir_Edilecek_Esya like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 4)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Gİris where Model like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 5)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Giris where Gonderilen_Firma like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else
                {
                    MessageBox.Show("Lütfen Doğru Arama Yapmak İçin Türü Seçin ");
                }

            }
            else if (comboBox6.SelectedIndex == 2)
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where İsim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Soyisim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Telefon like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 3)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Tamir_Edilecek_Esya like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 4)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Model like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 5)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Gonderilen_Firma like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else
                {
                    MessageBox.Show("Lütfen Doğru Arama Yapmak İçin Türü Seçin ");
                }
            }
            else if (comboBox6.SelectedIndex==3)
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Etme where İsim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Etme where Soyisim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Etme where Telefon like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 3)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Etme where Tamir_Edilecek_Esya like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 4)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Etme where Model like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox4.SelectedIndex == 5)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Etme where Gonderilen_Firma like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else
                {
                    MessageBox.Show("Lütfen Doğru Arama Yapmak İçin Türü Seçin ");
                }
            }
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
            textBox9.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            pictureBox1.Image = null;
        }
        public void combobox_Fill()
        {
            comboBox4.Items.Clear();
            comboBox4.Items.Add("İSİM");
            comboBox4.Items.Add("SOYİSİM");
            comboBox4.Items.Add("TELEFON");
            comboBox4.Items.Add("TAMİR EDİLECEK EŞYA");
            comboBox4.Items.Add("MODEL");
        }
        public void teslim_Alma_fill_table()
        {
            Sabit_Kodlar.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Teslim_Alma", Sabit_Kodlar.conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
            Sabit_Kodlar.conn.Close();
        }
        public void tamir_Giris_fill_table()
        {
            Sabit_Kodlar.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Tamir_Giris", Sabit_Kodlar.conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
            Sabit_Kodlar.conn.Close();
        }
        public void tamir_Bitir_fill_table()
        {
            Sabit_Kodlar.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Tamir_Bitir", Sabit_Kodlar.conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
            Sabit_Kodlar.conn.Close();
        }
        public void teslim_Etme_fill_table()
        {
            Sabit_Kodlar.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Teslim_Etme", Sabit_Kodlar.conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
            Sabit_Kodlar.conn.Close();
        }
        private void Düzenleme_Load(object sender, EventArgs e)
        {

            comboBox6.Items.Add("TESLİM ALMA");
            comboBox6.Items.Add("TAMİR GİRİŞ");
            comboBox6.Items.Add("TAMİR BİTİR");
            comboBox6.Items.Add("TESLİM ETME");
            comboBox1.Text = "SEÇİNİZ ";
            comboBox5.Text = "SEÇİNİZ ";

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

        private void button2_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("LÜTFEN İSİMİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("LÜTFEN SOYİSİMİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("LÜTFEN TELEFONU BOŞ BIRAKMAYINIZ");
                }
                else if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN TAMİR EDİLECEK EŞYAYI  BOŞ BIRAKMAYINIZ");
                }
                else if (comboBox5.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN MODELİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("LÜTFEN TANİR SEBEBİNİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("LÜTFEN TAHMİNİ SÖYLENEN ÜCRETİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox8.Text == "")
                {
                    MessageBox.Show("LÜTFEN TESLİM ALMA TARİHİNİ BOŞ BIRAKMAYINIZ");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand comm = new SqlCommand("insert into Teslim_Alma(İsim,Soyisim,Telefon,Tamir_Edilecek_Esya,Model,Tamir_Sebebi,Tahmini_Ucret,Tarih_Giris) values (@name,@lastname,@number,@tee,@model,@ts,@tu,@tg)", Sabit_Kodlar.conn);
                    comm.Parameters.AddWithValue("@name", textBox1.Text.ToString());
                    comm.Parameters.AddWithValue("@lastname", textBox2.Text.ToString());
                    comm.Parameters.AddWithValue("@number", textBox3.Text.ToString());
                    comm.Parameters.AddWithValue("tee", comboBox1.Text.ToString());
                    comm.Parameters.AddWithValue("model", comboBox5.Text.ToString());
                    comm.Parameters.AddWithValue("ts", textBox5.Text.ToString());
                    comm.Parameters.AddWithValue("tu", textBox4.Text.ToString());
                    comm.Parameters.AddWithValue("tg", textBox8.Text.ToString());
                    comm.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    MessageBox.Show("TESLİM ALINDI");
                    teslim_Alma_fill_table();
                    clear();
                }
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("LÜTFEN İSİMİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("LÜTFEN SOYİSİMİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("LÜTFEN TELEFONU BOŞ BIRAKMAYINIZ");
                }
                else if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN TAMİR EDİLECEK EŞYAYI  BOŞ BIRAKMAYINIZ");
                }
                else if (comboBox5.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN MODELİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("LÜTFEN TANİR SEBEBİNİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("LÜTFEN TAHMİNİ SÖYLENEN ÜCRETİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox8.Text == "")
                {
                    MessageBox.Show("LÜTFEN TESLİM ALMA TARİHİNİ BOŞ BIRAKMAYINIZ");

                }
                else if (comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN TAMİR TÜRÜ SEÇİN");
                }
                else if (comboBox3.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN GÖNDERİLECEK FİRMAYI SEÇİN");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand comm = new SqlCommand("insert into Tamir_Giris(İsim,Soyisim,Telefon,Tamir_Edilecek_Esya,Model,Tamir_Sebebi,Tahmini_Ucret,Tarih_Giris,Tamir_Turu,Gonderilen_Firma) values (@name,@lastname,@number,@tee,@model,@ts,@tu,@tg,@tt,@gf)", Sabit_Kodlar.conn);
                    comm.Parameters.AddWithValue("@name", textBox1.Text.ToString());
                    comm.Parameters.AddWithValue("@lastname", textBox2.Text.ToString());
                    comm.Parameters.AddWithValue("@number", textBox3.Text.ToString());
                    comm.Parameters.AddWithValue("tee", comboBox1.Text.ToString());
                    comm.Parameters.AddWithValue("model", comboBox5.Text.ToString());
                    comm.Parameters.AddWithValue("ts", textBox5.Text.ToString());
                    comm.Parameters.AddWithValue("tu", textBox4.Text.ToString());
                    comm.Parameters.AddWithValue("tg", textBox8.Text.ToString());
                    comm.Parameters.AddWithValue("tt", comboBox2.Text.ToString());
                    comm.Parameters.AddWithValue("gf", comboBox3.Text.ToString());
                    comm.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    MessageBox.Show("TAMİR GİRİŞ YAPILDI");
                    tamir_Giris_fill_table();
                    clear();

                }
            }
            else if (comboBox6.SelectedIndex == 2)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("LÜTFEN İSİMİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("LÜTFEN SOYİSİMİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("LÜTFEN TELEFONU BOŞ BIRAKMAYINIZ");
                }
                else if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN TAMİR EDİLECEK EŞYAYI  BOŞ BIRAKMAYINIZ");
                }
                else if (comboBox5.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN MODELİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("LÜTFEN TANİR SEBEBİNİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("LÜTFEN TAHMİNİ SÖYLENEN ÜCRETİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox8.Text == "")
                {
                    MessageBox.Show("LÜTFEN TESLİM ALMA TARİHİNİ BOŞ BIRAKMAYINIZ");

                }
                else if (comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN TAMİR TÜRÜ SEÇİN");
                }
                else if (comboBox3.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN GÖNDERİLECEK FİRMAYI SEÇİN");
                }
                else if (textBox9.Text == "")
                {
                    MessageBox.Show("LÜTFEN ÖDENECEK ÜCRETİ GİRİNİZ");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand comm = new SqlCommand("insert into Tamir_Bitir(İsim,Soyisim,Telefon,Tamir_Edilecek_Esya,Model,Tamir_Sebebi,Tahmini_Ucret,Tarih_Giris,Tamir_Turu,Gonderilen_Firma,Odenmesi_Gereken_Ucret) values (@name,@lastname,@number,@tee,@model,@ts,@tu,@tg,@tt,@gf,@ou)", Sabit_Kodlar.conn);
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
                    comm.Parameters.AddWithValue("@ou", textBox9.Text.ToString());
                    comm.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    MessageBox.Show("TAMİR BİTİRİLDİ");
                    tamir_Bitir_fill_table();
                    clear();

                }
            }
            else if (comboBox6.SelectedIndex == 3)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("LÜTFEN İSİMİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("LÜTFEN SOYİSİMİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("LÜTFEN TELEFONU BOŞ BIRAKMAYINIZ");
                }
                else if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN TAMİR EDİLECEK EŞYAYI  BOŞ BIRAKMAYINIZ");
                }
                else if (comboBox5.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN MODELİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("LÜTFEN TANİR SEBEBİNİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("LÜTFEN TAHMİNİ SÖYLENEN ÜCRETİ BOŞ BIRAKMAYINIZ");
                }
                else if (textBox8.Text == "")
                {
                    MessageBox.Show("LÜTFEN TESLİM ALMA TARİHİNİ BOŞ BIRAKMAYINIZ");
                }
                else if (comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN TAMİR TÜRÜ SEÇİN");
                }
                else if (comboBox3.SelectedIndex == -1)
                {
                    MessageBox.Show("LÜTFEN GÖNDERİLECEK FİRMAYI SEÇİN");
                }
                else if (textBox9.Text == "")
                {
                    MessageBox.Show("LÜTFEN ÖDENECEK ÜCRETİ GİRİNİZ");
                }
                else if (textBox7.Text == "")
                {
                    MessageBox.Show("LÜTFEN TESLİM ETME TARİHİNİ BOŞ BIRAKMAYINIZ");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand comm = new SqlCommand("insert into Teslim_Etme(İsim,Soyisim,Telefon,Tamir_Edilecek_Esya,Model,Tamir_Sebebi,Tahmini_Ucret,Tarih_Giris,Tamir_Turu,Gonderilen_Firma,Tarih_Cikis) values (@name,@lastname,@number,@tee,@model,@ts,@tu,@tg,@tt,@gf,@tc)", Sabit_Kodlar.conn);
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
                    comm.Parameters.AddWithValue("@ou", textBox9.Text.ToString());
                    comm.Parameters.AddWithValue("@tc", textBox7.Text.ToString());
                    comm.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    MessageBox.Show("TESLİM EDİLDİ");
                    teslim_Etme_fill_table();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN AŞAMA SEÇİNİZ");
            }
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                dataGridView1.DataSource = null;
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Teslim_Alma", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
                textBox7.Enabled = false;
                textBox9.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                combobox_Fill();

            }
            else if (comboBox6.SelectedIndex == 1)
            {
                dataGridView1.DataSource = null;
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Tamir_Giris", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
                comboBox2.Enabled = true;
                textBox7.Enabled = false;
                textBox9.Enabled = false;
                comboBox3.Enabled = true;
                combobox_Fill();
                comboBox4.Items.Add("GÖNDERİLEN FİRMA");
            }

            else if (comboBox6.SelectedIndex == 2)
            {
                dataGridView1.DataSource = null;
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Tamir_Bitir", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
                comboBox2.Enabled = true;
                textBox7.Enabled = false;
                textBox9.Enabled = true;
                comboBox3.Enabled = true;
                combobox_Fill();
                comboBox4.Items.Add("GÖNDERİLEN FİRMA");
            }
            else if (comboBox6.SelectedIndex == 3)
            {
                dataGridView1.DataSource = null;
                Sabit_Kodlar.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Teslim_Etme", Sabit_Kodlar.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                Sabit_Kodlar.conn.Close();
                comboBox2.Enabled = true;
                textBox7.Enabled = true;
                textBox9.Enabled = true;
                comboBox3.Enabled = true;
                combobox_Fill();
                comboBox4.Items.Add("GÖNDERİLEN FİRMA");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                if (textBox8.Text == "")
                {
                    MessageBox.Show("LÜTFEN TABLODAN MÜŞTERİ SEÇİN");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand command = new SqlCommand("Delete from Teslim_Alma where Tamir_No=@tn", Sabit_Kodlar.conn);
                    command.Parameters.AddWithValue("@tn", dataGridView1.CurrentRow.Cells[8].Value.ToString());
                    command.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    teslim_Alma_fill_table();
                    clear();
                    MessageBox.Show("MÜŞTERİ SİLİNDİ");
                }
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                if (textBox8.Text == "")
                {
                    MessageBox.Show("LÜTFEN TABLODAN MÜŞTERİ SEÇİN");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand command = new SqlCommand("Delete from Tamir_giris where Tamir_No=@tn", Sabit_Kodlar.conn);
                    command.Parameters.AddWithValue("@tn", dataGridView1.CurrentRow.Cells[10].Value.ToString());
                    command.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    tamir_Giris_fill_table();
                    clear();
                    MessageBox.Show("MÜŞTERİ SİLİNDİ");
                }
            }
            else if (comboBox6.SelectedIndex == 2)
            {
                if (textBox8.Text == "")
                {
                    MessageBox.Show("LÜTFEN TABLODAN MÜŞTERİ SEÇİN");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand command = new SqlCommand("Delete from Tamir_Bitir where Tamir_No=@tn", Sabit_Kodlar.conn);
                    command.Parameters.AddWithValue("@tn", dataGridView1.CurrentRow.Cells[11].Value.ToString());
                    command.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    tamir_Bitir_fill_table();
                    clear();
                    MessageBox.Show("MÜŞTERİ SİLİNDİ");
                }
            }
            else if (comboBox6.SelectedIndex == 3)
            {
                if (textBox8.Text == "")
                {
                    MessageBox.Show("LÜTFEN TABLODAN MÜŞTERİ SEÇİN");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand command = new SqlCommand("Delete from Teslim_Etme where Tamir_No=@tn", Sabit_Kodlar.conn);
                    command.Parameters.AddWithValue("@tn", dataGridView1.CurrentRow.Cells[12].Value.ToString());
                    command.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    teslim_Etme_fill_table();
                    clear();
                    MessageBox.Show("MÜŞTERİ SİLİNDİ");
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN AŞAMA SEÇİNİZ ");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[9].Value.ToString();  
            }
            else if (comboBox6.SelectedIndex == 1)
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
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }
            else if (comboBox6.SelectedIndex == 2)
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
                textBox9.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            }
            else if (comboBox6.SelectedIndex == 3)
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
                textBox9.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
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
                    MessageBox.Show("TAMİR EDİLECEK EŞYA YERİNİ BOŞ BIRAKMAYIN LÜTFEN ");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("TAMİR SEBEBİNİ GİRİN LÜTFEN ");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("TAHMİNİ ÜCRETİ GİRİM LÜTFEN ");
                }
                else if (textBox8.Text == "")
                {
                    MessageBox.Show("GİRİŞ TARİHİ GİRİNİZ LÜTFEN  ");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand command = new SqlCommand("Update Teslim_Alma set Tarih_Giris=@tarih_Giris,İSim=@isim,Soyisim=@soyisim,Telefon=@telefon,Tamir_Edilecek_Esya=@tamir_Edilecek_Esya,Model=@model,Tamir_Sebebi=@tamir_Sebebi,Tahmini_Ucret=@tahmini_Ucret where Tamir_No=@tamir_No ", Sabit_Kodlar.conn);
                    command.Parameters.AddWithValue("@tarih_Giris", textBox8.Text.ToString());
                    command.Parameters.AddWithValue("@isim", textBox1.Text.ToString());
                    command.Parameters.AddWithValue("@soyisim", textBox2.Text.ToString());
                    command.Parameters.AddWithValue("@telefon", textBox3.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_Edilecek_Esya", comboBox1.Text.ToString());
                    command.Parameters.AddWithValue("@model", comboBox5.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_Sebebi", textBox5.Text.ToString());
                    command.Parameters.AddWithValue("@tahmini_Ucret", textBox4.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_No", dataGridView1.CurrentRow.Cells[8].Value.ToString());

                    command.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    clear();
                    teslim_Alma_fill_table();
                    MessageBox.Show("GÜNCELLENDİ");
                }
            }
            else if (comboBox6.SelectedIndex == 1)
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
                    MessageBox.Show("TAMİR EDİLECEK EŞYA YERİNİ BOŞ BIRAKMAYIN LÜTFEN ");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("TAMİR SEBEBİNİ GİRİN LÜTFEN ");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("TAHMİNİ ÜCRETİ GİRİM LÜTFEN ");
                }
                else if (comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("TAMİR TÜRÜ SEÇİNİZ LÜTFEN ");
                }
                else if (comboBox3.SelectedIndex == -1)
                {
                    MessageBox.Show("GÖNDERİLECEK FİRMA GİRİNİZ LÜTFEN ");
                }
                else if (textBox8.Text == "")
                {
                    MessageBox.Show("GİRİŞ TARİHİ GİRİNİZ LÜTFEN  ");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand command = new SqlCommand("Update Tamir_Giris set Tarih_Giris=@tarih_Giris,İSim=@isim,Soyisim=@soyisim,Telefon=@telefon,Tamir_Edilecek_Esya=@tamir_Edilecek_Esya,Model=@model,Tamir_Sebebi=@tamir_Sebebi,Tahmini_Ucret=@tahmini_Ucret,Tamir_Turu=@tamir_Turu,Gonderilen_Firma=@gonderilen_Firma where Tamir_No=@tamir_No", Sabit_Kodlar.conn);
                    command.Parameters.AddWithValue("@tarih_Giris", textBox8.Text.ToString());
                    command.Parameters.AddWithValue("@isim", textBox1.Text.ToString());
                    command.Parameters.AddWithValue("@soyisim", textBox2.Text.ToString());
                    command.Parameters.AddWithValue("@telefon", textBox3.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_Edilecek_Esya", comboBox1.Text.ToString());
                    command.Parameters.AddWithValue("@model", comboBox5.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_Sebebi", textBox5.Text.ToString());
                    command.Parameters.AddWithValue("@tahmini_Ucret", textBox4.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_Turu", comboBox2.Text.ToString());
                    command.Parameters.AddWithValue("@gonderilen_Firma", comboBox3.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_No", dataGridView1.CurrentRow.Cells[10].Value.ToString());
                    command.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    clear();
                    tamir_Giris_fill_table();
                    MessageBox.Show("GÜNCELLENDİ");
                }
            }
            else if (comboBox6.SelectedIndex == 2)
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
                    MessageBox.Show("TAMİR EDİLECEK EŞYA YERİNİ BOŞ BIRAKMAYIN LÜTFEN ");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("TAMİR SEBEBİNİ GİRİN LÜTFEN ");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("TAHMİNİ ÜCRETİ GİRİM LÜTFEN ");
                }
                else if (comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("TAMİR TÜRÜ SEÇİNİZ LÜTFEN ");
                }
                else if (comboBox3.SelectedIndex == -1)
                {
                    MessageBox.Show("GÖNDERİLECEK FİRMA GİRİNİZ LÜTFEN  ");
                }
                else if (textBox8.Text == "")
                {
                    MessageBox.Show("GİRİŞ TARİHİ GİRİNİZ LÜTFEN  ");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand command = new SqlCommand("Update Tamir_Bitir set Tarih_Giris=@tarih_Giris,İSim=@isim,Soyisim=@soyisim,Telefon=@telefon,Tamir_Edilecek_Esya=@tamir_Edilecek_Esya,Model=@model,Tamir_Sebebi=@tamir_Sebebi,Tahmini_Ucret=@tahmini_Ucret,Tamir_Turu=@tamir_Turu,Gonderilen_Firma=@gonderilen_Firma,Odenmesi_Gereken_Ucret=@odenmesi_Gereken_Ucret where Tamir_No=@tamir_No", Sabit_Kodlar.conn);
                    command.Parameters.AddWithValue("@tarih_Giris", textBox8.Text.ToString());
                    command.Parameters.AddWithValue("@isim", textBox1.Text.ToString());
                    command.Parameters.AddWithValue("@soyisim", textBox2.Text.ToString());
                    command.Parameters.AddWithValue("@telefon", textBox3.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_Edilecek_Esya", comboBox1.Text.ToString());
                    command.Parameters.AddWithValue("@model", comboBox5.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_Sebebi", textBox5.Text.ToString());
                    command.Parameters.AddWithValue("@tahmini_Ucret", textBox4.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_Turu", comboBox2.Text.ToString());
                    command.Parameters.AddWithValue("@gonderilen_Firma", comboBox3.Text.ToString());
                    command.Parameters.AddWithValue("@odenmesi_Gereken_Ucret", textBox9.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_No", dataGridView1.CurrentRow.Cells[11].Value.ToString());
                    command.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    clear();
                    tamir_Bitir_fill_table();
                    MessageBox.Show("GÜNCELLENDİ");
                }
            }
            else if (comboBox6.SelectedIndex == 3)
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
                    MessageBox.Show("TAMİR EDİLECEK EŞYA YERİNİ BOŞ BIRAKMAYIN LÜTFEN ");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("TAMİR SEBEBİNİ GİRİN LÜTFEN ");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("TAHMİNİ ÜCRETİ GİRİM LÜTFEN ");
                }
                else if (comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("TAMİR TÜRÜ SEÇİNİZ LÜTFEN ");
                }
                else if (comboBox3.SelectedIndex == -1)
                {
                    MessageBox.Show("GÖNDERİLECEK FİRMA GİRİNİZ LÜTFEN ");
                }
                else if (textBox7.Text == "")
                {
                    MessageBox.Show("ÇIKIŞ TARİHİ GİRİNİZ LÜTFEN  ");
                }
                else if (textBox8.Text == "")
                {
                    MessageBox.Show("GİRİŞ TARİHİ GİRİNİZ LÜTFEN  ");
                }
                else
                {
                    Sabit_Kodlar.conn.Open();
                    SqlCommand command = new SqlCommand("Update Teslim_Etme set Tarih_Giris=@tarih_Giris,İSim=@isim,Soyisim=@soyisim,Telefon=@telefon,Tamir_Edilecek_Esya=@tamir_Edilecek_Esya,Model=@model,Tamir_Sebebi=@tamir_Sebebi,Tahmini_Ucret=@tahmini_Ucret,Tamir_Turu=@tamir_Turu,Gonderilen_Firma=@gonderilen_Firma,Odenmesi_Gereken_Ucret=@odenmesi_Gereken_Ucret,Tarih_Cikis=@tarih_Cikis where Tamir_No=@tamir_No", Sabit_Kodlar.conn);
                    command.Parameters.AddWithValue("@tarih_Giris", textBox8.Text.ToString());
                    command.Parameters.AddWithValue("@isim", textBox1.Text.ToString());
                    command.Parameters.AddWithValue("@soyisim", textBox2.Text.ToString());
                    command.Parameters.AddWithValue("@telefon", textBox3.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_Edilecek_Esya", comboBox1.Text.ToString());
                    command.Parameters.AddWithValue("@model", comboBox5.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_Sebebi", textBox5.Text.ToString());
                    command.Parameters.AddWithValue("@tahmini_Ucret", textBox4.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_Turu", comboBox2.Text.ToString());
                    command.Parameters.AddWithValue("@gonderilen_Firma", comboBox3.Text.ToString());
                    command.Parameters.AddWithValue("@odenmesi_Gereken_Ucret", textBox9.Text.ToString());
                    command.Parameters.AddWithValue("@tarih_Cikis", textBox7.Text.ToString());
                    command.Parameters.AddWithValue("@tamir_No", dataGridView1.CurrentRow.Cells[12].Value.ToString());
                    command.ExecuteNonQuery();
                    Sabit_Kodlar.conn.Close();
                    clear();
                    teslim_Etme_fill_table();
                    MessageBox.Show("GÜNCELLENDİ");
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN AŞAMA SEÇİNİZ ");
            }
        }
    }
}
