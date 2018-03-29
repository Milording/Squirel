using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squirel
{
    public class Circle : ISquarable
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Value must be positive.");

            Radius = radius;
        }

        public double Square()
            => Math.PI * Math.Pow(Radius, 2);
    }
}
