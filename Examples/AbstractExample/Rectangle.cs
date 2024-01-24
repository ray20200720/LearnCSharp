using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    class Rectangle : Shape
    {
        double length;
        double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public override double CalculateArea()
        {
            return length * width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
}
