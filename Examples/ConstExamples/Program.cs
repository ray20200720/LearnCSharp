using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            const int num = 1;
            //num = 2; // error

            Console.WriteLine("{0}", num);

            Console.ReadKey();
        }
    }
}
