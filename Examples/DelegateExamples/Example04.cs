using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    delegate void CustomCallback(string s);
    class Example04
    {
        static void Hello(string s)
        {
            Console.WriteLine($" Hello, {s}!");
        }

        static void Goodbye(string s)
        {
            Console.WriteLine($" Goodbye, {s}!");
        }

        public static void ShowExample()
        {
            CustomCallback hiDel, byeDel, multiDel, multiMinusHiDel;

            hiDel = Hello;
            byeDel = Goodbye;
            multiDel = hiDel + byeDel;
            multiMinusHiDel = multiDel - hiDel;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");

            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("B");

            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("C");

            Console.WriteLine("Invoking delegate multiMinusHiDel:");
            multiMinusHiDel("D");
        }
    }
}
