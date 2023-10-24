using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta4_uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte yas;
            yas = Convert.ToByte(textBox1.Text);
            if (yas > 17)
            {
                MessageBox.Show("Ehliyet Alabilirsiniz");
            }

        }
    }
}
