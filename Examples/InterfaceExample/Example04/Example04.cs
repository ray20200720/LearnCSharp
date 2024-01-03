using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample04
{
    class Example04
    {
        public static void ShowExample()
        {
            ILeft middle = new Middle();
            IRight middleToRight = middle as IRight;

            Console.WriteLine("{0}", middle.P);
            Console.WriteLine("{0}", middleToRight.P());
        }
    }
}
