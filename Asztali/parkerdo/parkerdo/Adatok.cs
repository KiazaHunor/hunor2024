using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkerdo
{
    internal class Adatok
    {
        public int kezd;
        public int veg;
        public string szin;

        public Adatok(string sor) 
        {
            string[] vag = sor.Split(" ");
            kezd=int.Parse(vag[0]);
            veg=int.Parse(vag[1]);
            szin=vag[2];
        }
    }
}
