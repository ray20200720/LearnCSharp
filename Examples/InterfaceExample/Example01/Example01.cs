using System;

namespace InterfaceExample01
{
    class Example01
    {
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        }

        /// <summary>
        /// https://learn.microsoft.com/zh-tw/dotnet/csharp/language-reference/keywords/interface
        /// </summary>
        public static void ShowExample()
        {
            IPoint p = new Point(3, 4);
            Console.Write("My Point: ");
            PrintPoint(p);
            Console.WriteLine("My Point Distance: {0}", p.Distance);
        }
    }
}
