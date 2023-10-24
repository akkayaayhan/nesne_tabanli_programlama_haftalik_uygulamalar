using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta5_switch_case_gun_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(textBox1.Text);
            //int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            switch (gun)
            {
                case 1:MessageBox.Show("Günlerden Pazartesi");
                    break;
                case 2:
                    MessageBox.Show("Günlerden Salı");
                    break;
                case 3:
                    MessageBox.Show("Günlerden Çarşamba");
                    break;
                case 4:
                    MessageBox.Show("Günlerden Perşembe");
                    break;
                case 5:
                    MessageBox.Show("Günlerden Cuma");
                    break;
                case 6:
                    MessageBox.Show("Günlerden Cumartesi");
                    break;
                case 7:
                    MessageBox.Show("Günlerden Pazar");
                    break;
                default:MessageBox.Show("Lütfen 1-7 arasında değer giriniz");
                    break;
            }
        }
    }
}
