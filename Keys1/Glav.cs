using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keys
{
    public partial class Glav : Form
    {
        public Glav()
        {
            Program.f1 = this;
            InitializeComponent();
        }
        public void kab1_Click(object sender, EventArgs e)
        {
            if (kab1.BackColor==Color.Red) {
                Openkab openkabin = new Openkab();
                openkabin.Show();
            }
            else
            {
                Closekab closekabin = new Closekab();
                closekabin.Show();
            }
        }

        public void kab2_Click(object sender, EventArgs e)
        {
            if (kab2.BackColor == Color.Red)
            {
                Openkab openkabin = new Openkab();
                openkabin.Show();
            }
            else
            {
                Closekab closekabin = new Closekab();
                closekabin.Show();
            }
        }
    }
}
