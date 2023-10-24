using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta6_for_dongusu_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("1 ile 10 arasındaki sayılar");
            for (int i = 1; i <= 10; i++)
            {
                
                listBox1.Items.Add(i);
            }
            int toplam = 0;
            for(int i = 1; i <= 10; i++)
            {
                toplam += i;
            }
            listBox1.Items.Add("1 ile 10 arasındaki sayıların toplamı");
            listBox1.Items.Add(toplam);

            int ciftSayilar = 0;
            for(int i = 0; i <= 10; i=i+2)
            {
                ciftSayilar += i;
                
            }
            listBox1.Items.Add("1 ile 10 arasındaki çift sayıların toplamı");
            listBox1.Items.Add(ciftSayilar);

            int tekSayilar = 0;
            for(int i = 1; i <= 10; i = i + 2)
            {
                tekSayilar = tekSayilar + i;
            }

            listBox1.Items.Add("1 ile 10 arasındaki tek sayıların toplamı");
            listBox1.Items.Add(tekSayilar);
        }
    }
}
