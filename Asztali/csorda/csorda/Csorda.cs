using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csorda
{
    internal class Csorda
    {
         public List<Allat> tagok = new List<Allat>();
        public Csorda() { }

        public Csorda(Allat allat) 
        {
            tagok.Add(allat);
        }
        public Csorda(Csorda csorda) 
        {
            this.tagok.AddRange(csorda.tagok);
        }

        public static Csorda operator +(Csorda cs1, Allat a1) 
        {
             cs1.tagok.Add(a1);
            return new Csorda(cs1);
        }

        public void kiir() 
        {
            for (int i = 0; i < tagok.Count; i++) 
            {
                Console.WriteLine(tagok[i]);
            }
        }
    }
}
