using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample01
{
    class Program
    {
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        }

        static void Main(string[] args)
        {
            //https://learn.microsoft.com/zh-tw/dotnet/csharp/language-reference/keywords/interface
            IPoint p = new Point(3, 4);
            Console.Write("My Point: ");
            PrintPoint(p);
            Console.WriteLine("My Point Distance: {0}", p.Distance);

            Console.ReadKey();
        }
    }
}
