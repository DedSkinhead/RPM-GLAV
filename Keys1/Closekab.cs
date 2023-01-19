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
    public partial class Closekab : Form
    {
        Kabinet kabin ;
        public Closekab()
        {
            InitializeComponent();
        }
        public Closekab(Kabinet kabin)
        {
            this.kabin = kabin;
            InitializeComponent();
        }

        public void Da_Click(object sender, EventArgs e)
        {
            kabin.sos = 0;
            Bd bd = new Bd();
            bd.Bod(kabin);
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Net_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
