using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    public class Utl
    {
        public static void PrintTitle(string title, int num = 50)
        {
            Console.WriteLine();

            for (int i = 1; i < num / 2; i++)
            {
                Console.Write("=");
            }

            Console.Write("{0}", title);

            for (int i = 1; i < num / 2; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();
        }
    }
}
