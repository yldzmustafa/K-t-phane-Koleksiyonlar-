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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void kitapListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public List<string> kitap = new List<string>();
        private void kullanıcıGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(kitap);
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void kitaplarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(kitap);
            frm4.MdiParent = this;
            frm4.Show();

        }
    }
}
