using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta4_iciceif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gorev = textBox1.Text;
            double maas = Convert.ToDouble(textBox2.Text);

            if(gorev=="usta")
            {
                if (maas < 20000)
                {
                    double yeniMaas = maas + maas * 0.2;
                    listBox1.Items.Add(gorev+" nın yeni maaşı :"+yeniMaas.ToString());
                }

            }
            else if (gorev == "kalfa")
            {
                if (maas < 10000)
                {
                    double yeniMaas = maas + maas * 0.2;
                    listBox1.Items.Add(gorev + " nın yeni maaşı :" + yeniMaas.ToString());
                }

            }
            else if (gorev == "şegirt")
            {
                if (maas < 5000)
                {
                    double yeniMaas = maas + maas * 0.2;
                    listBox1.Items.Add(gorev + " nın yeni maaşı :" + yeniMaas.ToString());
                }

            }

        }
    }
}
