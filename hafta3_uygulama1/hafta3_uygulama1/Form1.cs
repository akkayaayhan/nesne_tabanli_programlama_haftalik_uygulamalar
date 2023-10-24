using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta3_uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            if (username == "admin" && password == "1111")
            {
                MessageBox.Show("Admin Girişi Yapıldı ");
                this.BackColor = Color.Red;
            }
            else if (username == "yonetici" && password == "2222")
            {
                MessageBox.Show("Yönetici Girişi Yapıldı");
                this.BackColor = Color.Pink;
            }

            else if (username == "standart" && password == "3333") 
            {
                MessageBox.Show("Kullanıcı Girişi Yapıldı");
                this.BackColor = Color.Purple;

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre");
            }

        }
    }
}

