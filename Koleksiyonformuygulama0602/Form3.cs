using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koleksiyonformuygulama0602
{
    public partial class Form3 : Form
    {
        public List<string> kitaplar = new List<string>();
        public Form3(List<string> kitap)
        {
            InitializeComponent();
            this.kitaplar = kitap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitaplar.Add(textBox1.Text);
            kitaplar.Add(textBox2.Text);
            kitaplar.Add(textBox3.Text);
            kitaplar.Add(textBox4.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Select();
        }
    }
}
