using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta3_uygulama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yaricap = Convert.ToDouble(textBox1.Text);
            double pi = 3.14;
            double alan = pi * yaricap * yaricap;
            double cevre = 2 * pi * yaricap;
            label2.Text = "Alan="+alan.ToString();
            label3.Text = "Çevre=" + cevre.ToString();
            textBox1.Text = "";

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            int uzunluk = Convert.ToInt16(textBox2.Text);
            int genislik = Convert.ToInt16(textBox3.Text);
            int alan = uzunluk * genislik;
            int cevre = 2 * (uzunluk + genislik);
            label6.Text = "Alan="+alan.ToString();
            label5.Text = "Çevre="+cevre.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kenar = Convert.ToInt16(textBox5.Text);
            int alan = kenar * kenar;
            int cevre = 4*kenar;
            label11.Text = "Alan="+alan.ToString();
            label10.Text = "Çevre="+cevre.ToString();
        }
    }
}
