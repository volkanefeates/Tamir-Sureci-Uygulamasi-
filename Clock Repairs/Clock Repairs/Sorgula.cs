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
    public partial class Sorgula : Form
    {
        public Sorgula()
        {
            InitializeComponent();
        }
        public void combobox_Fill()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("İSİM");
            comboBox1.Items.Add("SOYİSİM");
            comboBox1.Items.Add("TELEFON");
            comboBox1.Items.Add("TAMİR EDİLECEK EŞYA");
            comboBox1.Items.Add("MODEL");
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            dataGridView1.DataSource = null;
            Sabit_Kodlar.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Teslim_Alma", Sabit_Kodlar.conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
            Sabit_Kodlar.conn.Close();
            combobox_Fill();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 32;
            dataGridView1.DataSource=null;
            Sabit_Kodlar.conn.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM  Tamir_Giris", Sabit_Kodlar.conn);
            DataTable dataTable1 = new DataTable();
            dataAdapter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1.DefaultView;
            Sabit_Kodlar.conn.Close();
            combobox_Fill();
            comboBox1.Items.Add("GÖNDERİLEN FİRMA");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 65;
            dataGridView1.DataSource = null;
            Sabit_Kodlar.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Tamir_Bitir", Sabit_Kodlar.conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
            Sabit_Kodlar.conn.Close();
            combobox_Fill();
            comboBox1.Items.Add("GÖNDERİLEN FİRMA");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            dataGridView1.DataSource = null;
            Sabit_Kodlar.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM  Teslim_Etme", Sabit_Kodlar.conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable.DefaultView;
            Sabit_Kodlar.conn.Close();
            combobox_Fill();
            comboBox1.Items.Add("GÖNDERİLEN FİRMA");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();
        }
        public void sorgula_clear() { textBox1.Text = null; comboBox1.SelectedIndex = -1; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where İsim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();    
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where Soyisim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();

                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where Telefon like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();

                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Alma where Tamir_Edilecek_Esya like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();

                }
                else if (comboBox1.SelectedIndex == 4)
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
            else if (radioButton2.Checked == true)
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Gİris where İsim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Gİris where Soyisim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();

                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Gİris where Telefon like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Gİris where Tamir_Edilecek_Esya like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Gİris where Model like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 5)
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
            else if (radioButton3.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where İsim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Soyisim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();

                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Telefon like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Tamir_Edilecek_Esya like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tamir_Bitir where Model like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 5)
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
            else if (radioButton4.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Etme where İsim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Etme where Soyisim like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Etme where Telefon like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Etme where Tamir_Edilecek_Esya like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    Sabit_Kodlar.conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Teslim_Etme where Model like '%" + textBox1.Text + "%'", Sabit_Kodlar.conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Sabit_Kodlar.conn.Close();
                    sorgula_clear();
                }
                else if (comboBox1.SelectedIndex == 5)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            }
            else if (radioButton2.Checked == true)
            {
                textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                comboBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                comboBox5.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            }
            else if (radioButton3.Checked == true)
            {
                textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                comboBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                comboBox5.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[12].Value.ToString();

            }
            else if (radioButton4.Checked == true)
            {
                textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                comboBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                comboBox5.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            }
        }

        private void sorgula2_Load(object sender, EventArgs e)
        {
           
        }

    }
}
