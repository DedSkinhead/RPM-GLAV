using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keys
{
    public class Kabinet
    {
        public int idkab;
        public string nomer;
        public int sos;
        public Kabinet()
        {
        }

        public Kabinet(int idkab, string nomer, int sos)
        {
            this.idkab = idkab;
            this.nomer = nomer;
            this.sos = sos;
        }
        public int getIdkab() {
            return idkab;
        }
        public string getNomer()
        {
            return  nomer;
        }
        public int getSos()
        {
            return sos;
        }
    }
}
