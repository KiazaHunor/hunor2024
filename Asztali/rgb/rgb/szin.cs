using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgb
{
    internal class szin
    {
        public byte r;
        public byte g;
        public byte b;

        public szin(int red,int green, int blue) 
        {
            r = (byte)red;
            g = (byte)green;
            b = (byte)blue;
        }
        public override string ToString()
        {
            return $"RGB{r},{g},{b}";
        }
    }
}
