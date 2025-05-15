using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    internal class Kutya
    {
        public int id;
        public int fajtaId;
        public int nevId;
        public int kor;
        public DateOnly datum;
        public KutyaFajta fajta;
        public KutyaNev nev;
        
        public Kutya(int id, int fajtaId, int nevId, int kor,  DateOnly datum, KutyaFajta fajta, KutyaNev nev) 
        {
            this.id = id;
            this.fajtaId = fajtaId;
            this.nevId = nevId;
            this.kor = kor;
            this.datum = datum;
            this.fajta = fajta;
            this.nev = nev;

        }

    }
}
