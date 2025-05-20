using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar2004
{
    internal class Eredmeny
    {
        public string hazai;
        public string idegen;
        public int hazaiPont;
        public int idegenPont;
        public string hely;
        public DateOnly ido;


        public Eredmeny(string hazai,string idegen, int hazaiPont, int idegenPont, string hely, DateOnly ido) 
        {
            this.hazai = hazai;
            this.idegen = idegen;
            this.hazaiPont = hazaiPont;
            this.idegenPont = idegenPont;
            this.hely = hely;
            this.ido = ido;
        }
    }
}
