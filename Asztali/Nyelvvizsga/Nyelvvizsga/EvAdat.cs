using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvvizsga
{
    internal class EvAdat
    {
        public int ev;
        public int vizsgaDarab;

        public EvAdat(int ev, int darab) 
        {
            this.ev = ev;
            this.vizsgaDarab = darab;
        }

        public static int operator +(EvAdat a, EvAdat b) {return a.vizsgaDarab + b.vizsgaDarab;}

        public static int operator + (EvAdat a, int b) {return a.vizsgaDarab+b;}

        public static int operator + (int a , EvAdat b) {return a+b.vizsgaDarab;}


    }
}
