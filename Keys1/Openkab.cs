using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keys
{
    public partial class Openkab : Form
    {
        Kabinet kabin ;
        public Openkab()
        {
            InitializeComponent();
        }
        public Openkab(Kabinet kabin)
        {
            this.kabin = kabin;
            InitializeComponent();
        }
        private void Da_Click(object sender, EventArgs e)
        {
            kabin.sos = 1;
            Bd bd= new Bd();
            bd.Bod(kabin);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void Net_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
