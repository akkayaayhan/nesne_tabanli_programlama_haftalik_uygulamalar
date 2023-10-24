using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta6_while_dongusu_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ileriSay = 1;
            listBox1.Items.Add("1 den 10 a kadar sayılar");
            while (ileriSay <= 10)
            {
                listBox1.Items.Add(ileriSay);
                ileriSay++;
            }

            int geriSay = 10;
            listBox1.Items.Add("10 dan 1 e kadar sayılar");
            while (geriSay >= 1)
            {
                listBox1.Items.Add( geriSay);
                geriSay--;
            }

            int besinKatlari = 10;
            listBox1.Items.Add("10 ile 100 arasındaki 5 in katları");
            while (besinKatlari <= 100)
            {
                listBox1.Items.Add(besinKatlari);
                besinKatlari += 5;
            }

            int yedininKatlari = 100;
            while (yedininKatlari <= 0)
            {
                listBox1.Items.Add(yedininKatlari);
                yedininKatlari -= 7;
            }

            int ucunKatlari = 1;
            do
            {
                listBox1.Items.Add("3 ün katları:" + ucunKatlari);
                ucunKatlari += 3;
            } 
            while (ucunKatlari > 100);

        }
    }
}
