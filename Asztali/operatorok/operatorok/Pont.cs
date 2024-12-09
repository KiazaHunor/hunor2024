using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorok
{
    internal class Pont
    {
<<<<<<< HEAD
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
=======
        public int x;
        public int y;
        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Pont(int x)
        {
            this.x = x;
            y = 0;
        }
        public Pont()
        {
            y = 0;
            x = 0;
        }
        public static Pont operator +(Pont a, Pont b)
        {
            return new Pont(a.x + b.x, a.y + b.y);
        }

        public static Pont operator +(Pont a, int b)
        {
            return new Pont(a.x + b, a.y + b);
        }
        public static Pont operator +(int b, Pont a)
        {
            return new Pont(a.x + b, a.y + b);
        }
        public static Pont operator -(Pont a, Pont b)
        {
            return new Pont(a.x - b.x, a.y - b.y);
        }

        public static Pont operator -(Pont a, int b)
        {
            return new Pont(a.x - b, a.y - b);
        }
        public static Pont operator -(int b, Pont a)
        {
            return new Pont(a.x - b, a.y - b);
        }
        public static Pont operator *(Pont a, Pont b)
        {
            return new Pont(a.x * b.x, a.y * b.y);
        }

        public static Pont operator *(Pont a, int b)
        {
            return new Pont(a.x * b, a.y * b);
        }
        public static Pont operator *(int b, Pont a)
        {
            return new Pont(a.x * b, a.y * b);
        }
        public static Pont operator /(Pont a, Pont b)
        {
            return new Pont(a.x / b.x, a.y / b.y);
        }

        public static Pont operator /(Pont a, int b)
        {
            return new Pont(a.x / b, a.y / b);
        }
        public static Pont operator /(int b, Pont a)
        {
            return new Pont(a.x / b, a.y / b);
        }

        public static Pont operator ++(Pont a)
        {
            return new Pont(a.x++, a.y++);
        }
        public static Pont operator --(Pont a)
        {
            return new Pont(a.x--, a.y--);
        }

        public override bool Equals(object obj)
        {

            if (obj == null) 
            {
                return false;
            }
            

            Pont other = obj as Pont;
            if(other == null) 
            {return false;}

            return  x==other.x && y==other.y;
        }


        public string bool operator ==(Pont a, Pont b)
        {
            return a.Equals(b);
        }
        public string bool operator != (Pont a,Pont b) 
        {
            return !a.Equals(b);
>>>>>>> b9a9d92a942e473ebd9ca786040f16714de68136
        }

        public override string ToString()
        {
<<<<<<< HEAD
            return $"X:{X}, X:{Y}";
        }
    }
}
=======
            return $"x:{x}, y:{y}";
            //"x: " + x + ", y: " + y;
        }
    }
}

>>>>>>> b9a9d92a942e473ebd9ca786040f16714de68136
