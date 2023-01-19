using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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
            TT();
        }
        public void TT()
        {
           Bd bd= new Bd();
            List<Kabinet> jh = bd.Vse();
            int x = 100;
            int y = 100;
            foreach (Kabinet i in jh)
            {
                AddButton(x, y, i);
                x += 100;
            }

        }
        public async void kab10_Click(object sender, EventArgs e, Kabinet kabin, Button buttonDyn)
        {
            if (kabin.sos == 0)
            {
                Openkab kabinet = new Openkab(kabin);
                kabinet.ShowDialog();
                int kabSos = new Bd().id(kabin.getIdkab());
                if (kabSos == 1)
                {
                    kabin.sos = kabSos;
                    buttonDyn.BackColor = Color.Green;

                }
            } else
            {
                Closekab kabinet = new Closekab(kabin);
                kabinet.ShowDialog();
                int kabSos = new Bd().id(kabin.getIdkab());
                if (kabSos == 0)
                {
                    kabin.sos = kabSos;
                    buttonDyn.BackColor = Color.Red;

                }
            }
            


        }
        public void AddButton(int x, int y, Kabinet kabin)
        {
           Button buttonDyn = new System.Windows.Forms.Button();
            buttonDyn.Location = new System.Drawing.Point(x, y);
            buttonDyn.Text = "kabinet " +kabin;
            buttonDyn.Name = "button1";
            buttonDyn.Size = new System.Drawing.Size(100, 100);
            buttonDyn.TabIndex = 0;
            buttonDyn.UseVisualStyleBackColor = true;
            buttonDyn.Click += (sender, EventArgs) => { kab10_Click(sender, EventArgs, kabin, buttonDyn); };

            Controls.Add(buttonDyn);
            if(kabin.getSos()==1)
            {
                buttonDyn.BackColor = Color.Green;
            }
            else
            {
                buttonDyn.BackColor = Color.Red;
            }
        }
    }
}
