using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta5_switch_case_takim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oyuncu = comboBox1.Text;

            switch (oyuncu)
            {

                 
                case "Muslera":
                    pictureBox1.Visible = true;
                    break;
                case "Zaha":
                    pictureBox2.Visible = true;
                    break;
                case "Icardi":
                    pictureBox3.Visible = true;
                    break;
                case "Kerem":
                    pictureBox4.Visible = true;
                    pictureBox2.Visible = false;
                    break;

            }
        }
    }
}
