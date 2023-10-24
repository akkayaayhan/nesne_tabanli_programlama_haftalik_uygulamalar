using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta3_uygulama5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int my1 = Convert.ToInt32(textBox1.Text);
            int my2 = Convert.ToInt32(textBox2.Text);
            int mp1 = Convert.ToInt32(textBox3.Text);
            int mp2 = Convert.ToInt32(textBox4.Text);
            int ort = (my1 + my2 +( mp1 + mp2)/2)/3;
            label6.Text = ort.ToString();
        }
    }
}
