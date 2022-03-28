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
    public partial class Form4 : Form
    {
        public List<string> kitaplar = new List<string>();
        public Form4(List<string> kitap)
        {
            InitializeComponent();
            this.kitaplar = kitap;
        }

        List<string> k = new List<string>();
        private void Form4_Load(object sender, EventArgs e)
        {
            k.Add("Tutunamayanlar");
            k.Add("Oğuz Atay");
            k.Add("1972");
            k.Add("1000");
            k.Add("Serenad");
            k.Add("Zülfü Livaneli");
            k.Add("2011");
            k.Add("780");
            int y = 0;
            for (int i = 0; i < k.Count()/4; i++)
            {
                string ad, yazar, yıl, adet;
                ad = k[i + y];
                yazar = k[i + y+1];
                yıl = k[i + y+2];
                adet = k[i + y+3];
                y = y + 3;

                string[] satır = { ad, yazar, yıl, adet };

                ListViewItem item = new ListViewItem(satır);
                listView1.Items.Add((item));
            }

            int x = 0;
            for (int q = 0; q < kitaplar.Count() / 4; q++)
            {
                string ad, yazar, yıl, adet;
                ad = kitaplar[q + x];
                yazar = kitaplar[q + x + 1];
                yıl = kitaplar[q + x + 2];
                adet = kitaplar[q + x + 3];
                x = x + 3;

                string[] satır1 = { ad, yazar, yıl, adet };

                ListViewItem item = new ListViewItem(satır1);
                listView1.Items.Add((item));
            }

        }
    }
}
