using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta4_uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte skor1, skor2;
            skor1 = 6;
            skor2 = 5;
            if (skor1 > skor2)
            {
                MessageBox.Show("İlk Takım Kazandı");
                button1.BackColor = Color.Red;
                button1.Text = "GS";
            }
            else
            {
                MessageBox.Show("İkinci Takım Kazandı");
                button1.BackColor = Color.Yellow;
                button1.Text = "FB";
            }
        }
    }
}
