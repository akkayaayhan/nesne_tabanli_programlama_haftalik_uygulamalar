using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta4_iciceif_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 9 == 0)
            {
                if (sayi % 5 == 0)
                {
                    MessageBox.Show(sayi + " sayısı 45 in katıdır");
                    
                }

                else
                {
                    sayi = 90;
                    MessageBox.Show("45 in katı oldu");
                } 

            }
        }
    }
}
