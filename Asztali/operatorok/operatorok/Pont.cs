using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorok
{
    internal class Pont
    {
        public int X;
        public int Y;

        public Pont(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Pont(int x) 
        {
            X = x;
            Y = 0;
        }
        public Pont() 
        {
            X=0;
            Y=0;
        }

        public static Pont operator + (Pont a, Pont b) 
        {
            return new Pont (a.X+b.X, a.Y+b.Y);
        }

        public override string ToString()
        {
            return $"X:{X}, X:{Y}";
        }
    }
}
