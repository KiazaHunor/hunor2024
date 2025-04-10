using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvvizsga
{
    internal class NyelvAdat
    {
        public string nyelv;
        public List<EvAdat> vizsgak = new List<EvAdat>(); 

        public NyelvAdat(string sor, int[] evszamok)
        {
            string[] vag=sor.Split(";");
            nyelv=vag[0];
            
        }
        public NyelvAdat(string nyelv, int[] adatok, int[] evszamok)
        {
            this.nyelv = nyelv;

            for (int i = 0; i < adatok.Length; i++) 
            {
                this.vizsgak.Add(new EvAdat(evszamok[i], adatok[i]));
            }
        }
    }
}
