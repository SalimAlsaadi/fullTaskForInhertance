using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullTaskForInhertance
{
    internal class Regtangle : Shape
    {
        public double width;
        public double height;
        

        public override double getArea(double width, double height, double reduis)
        {
            this.width = width;
            this.height = height;
            
            return width*height;
           

        }

        public override double getPerimeter(double r, double length, double width)
        {
            return length + length + width + width;

        }
    }
}
