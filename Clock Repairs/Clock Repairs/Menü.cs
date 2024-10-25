using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Repairs
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teslim_Alma teslim_Alma = new Teslim_Alma();
            teslim_Alma.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tamir_Giriş tamir_Giriş = new Tamir_Giriş();
            tamir_Giriş.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tamir_Bitir tamir_Bitir = new Tamir_Bitir();
            tamir_Bitir.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Teslim_Etme teslim_Etme = new Teslim_Etme();
            teslim_Etme.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sorgula sorgula = new Sorgula();
            sorgula.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
            this.Hide();
        }

        private void Menü_Load(object sender, EventArgs e)
        {

        }
    }
}
