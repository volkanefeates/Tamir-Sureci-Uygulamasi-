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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Düzenleme düzenleme =new Düzenleme();   
            düzenleme.Show();   
            this.Hide();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Model_Giriş model_Giriş=new Model_Giriş();  
            model_Giriş.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Şifre_Düzenleme şifre_Düzenleme = new Şifre_Düzenleme();
            şifre_Düzenleme.Show();
            this.Hide();    
        }
    }
}
