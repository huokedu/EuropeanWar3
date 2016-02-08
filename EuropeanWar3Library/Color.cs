using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanWar3Library
{
    public class Color
    {
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public int a { get; set; }

        public static int MIN_COLOR = 0;
        public static int MAX_COLOR = 255;

        public Color()
        {

        }

        public Color(int r, int g, int b, int a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public override string ToString()
        {
            return "r: " + r + " g: " + g + " b: " + b + " a: " + a;
        }
    }
}
