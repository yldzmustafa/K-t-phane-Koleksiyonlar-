using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Koleksiyonformuygulama0602
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable admin = new Hashtable();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            admin.Add("1234", "mustafa");
            admin.Add("4321", "yıldız");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciadi = (textBox1.Text).ToLower();
            string sifre = textBox2.Text;

            if (admin.ContainsKey(sifre)  && admin.ContainsValue(kullaniciadi))
                {
                    MessageBox.Show("Giriş Başarılı");
                    this.Hide();
                    Form2 frm = new Form2();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız.Lütfen Kullanıcı adı ve şifrenizi kontrol edin !");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Select();
                }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
