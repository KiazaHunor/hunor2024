using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace JackieConsole
{
    internal class Versenyev
    {
        public int ev;
        public int versenyDarab;
        public int nyert;
        public int dobogos;
        public int pole;
        public int leggyorsabbKorokSzama;
        public int evtized;



        public Versenyev(int ev, int versenyDarab, int nyert, int pole, int leggyorsabbKorSzama,int dobogos)
        {
            this.ev = ev;
            this.versenyDarab = versenyDarab;
            this.nyert = nyert;
            this.dobogos = dobogos;
            this.pole = pole;
            this.leggyorsabbKorokSzama = leggyorsabbKorokSzama;

            evtized = (this.ev - 1900) / 10;
            evtized *= 10;
        }
        
    }
    
}
