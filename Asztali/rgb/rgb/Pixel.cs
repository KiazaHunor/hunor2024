using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgb
{
    internal class Pixel
    {
        public int x;
        public int y;
        public szin rgb;

        public Pixel (int x, int y, szin rgb)
        {
            this.x = x;
            this.y = y;
            this.rgb = rgb;
        }
    }
}
