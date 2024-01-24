using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExample
{
    public class Utility
    {
        public static void PrintDelimiter(string title = "", int length = 50, string separator = "=")
        {
            for (int i = 0; i < length; i++)
            {
                if (i == (length - 1))
                {
                    Console.WriteLine("{0}", separator);
                }
                else if(i == (length / 2))
                {
                    Console.Write("{0}", title);
                }
                else
                {
                    Console.Write("{0}", separator);
                }
            }
        }
    }
}
