using ClassLibraryExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqaure = new Rectangle(2, 2);
            Console.WriteLine("Square Length: {0}, Width: {1}", 2, 2);
            Console.WriteLine("Square Area: {0}", sqaure.CalculateArea());
            Console.WriteLine("Square Perimeter: {0}", sqaure.CalculatePerimeter());

            Utility.PrintDelimiter();

            var circle = new Circle(2);
            Console.WriteLine("Circle radius: {0}", 2);
            Console.WriteLine("Circle area: {0}", circle.CalculateArea());
            Console.WriteLine("Circle Perimeter: {0}", circle.CalculatePerimeter());

            Console.Read();
        }
    }
}
