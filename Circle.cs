using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullTaskForInhertance
{
    internal class Circle : Shape
    {
        public double reduis;

        public override double getArea(double width, double height, double reduis)
        {
            this.reduis = reduis;

            return reduis * reduis;
        }

        public override double getPerimeter(double r, double length, double width)
        {
            return 3.14 * r * r;

        }
    }
}
