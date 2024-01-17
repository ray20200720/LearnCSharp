using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstExamples
{
    public class Constants
    {
        public const double PI = 3.1416;

        public class Letter
        {
            public const char A = 'A';
            public const char B = 'B';
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int num = 1;
            //num = 2; // error

            Console.WriteLine("{0}", num);

            Console.WriteLine("{0}", Constants.PI);

            Console.WriteLine("{0}", Constants.Letter.A);

            Console.ReadKey();
        }
    }
}
