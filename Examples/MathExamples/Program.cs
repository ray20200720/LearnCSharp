using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 10;

            Console.WriteLine("{0} and {1}, Max is: {2} ", num1, num2, Math.Max(num1, num2));
            Console.WriteLine("{0} and {1}, Min is: {2} ", num1, num2, Math.Min(num1, num2));

            var num = -4;
            Console.WriteLine("The absolute value of {0} is: {1}", num, Math.Abs(num));

            num = Math.Abs(num);
            Console.WriteLine("The square root of {0} is: {1}", num, Math.Sqrt(num));


            Console.ReadKey();
        }
    }
}
