using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample04
{
    class Program
    {
        static void Main(string[] args)
        {
            ILeft middle = new Middle();
            IRight middleToRight = middle as IRight;
            
            Console.WriteLine("{0}", middle.P);
            Console.WriteLine("{0}", middleToRight.P());

            Console.Read();
        }
    }
}
