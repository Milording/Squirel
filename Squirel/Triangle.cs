using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squirel
{
    public class Triangle:ISquarable
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public bool IsRight {
            get
            {
                var sides = new List<double> { A, B, C };
                var hypotenuse = sides.Max();
                sides.Remove(hypotenuse);
                var sum = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
                return Math.Pow(hypotenuse, 2) == sum;
            }
        }


        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("All sides must be positive.");

            A = a;
            B = b;
            C = c;
        }

        public double Square()
        {
            var p = (A + B + C) / 2;
            var square = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return square;
        }
    }
}
