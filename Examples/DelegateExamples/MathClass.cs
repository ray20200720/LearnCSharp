using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    delegate void MultiplyCallback(int i, double d);

    class MathClass
    {
        public static void ShowExample()
        {
            MathClass m = new MathClass();

            MultiplyCallback d = m.MultiplyNumbers;

            for(int i = 1; i <= 5; i++)
            {
                d(i, 2);
            }
        }

        void MultiplyNumbers(int m, double d)
        {
            Console.Write(m * d + " ");
        }
    }
}
