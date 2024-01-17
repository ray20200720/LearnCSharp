using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public enum ComputerType
    {
        Desktop = 0,
        Laptop = 1,
        Server = 2
    }

    class Program
    {
        static string GetComputerType(ComputerType type)
        {
            return string.Format("{0}", Enum.GetName(type.GetType(), type));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===============================");

            ComputerType iWant = ComputerType.Laptop;

            Console.WriteLine("{0}", iWant);
            Console.WriteLine("{0}", Enum.GetName(iWant.GetType(), iWant));
            
            Console.WriteLine("===============================");

            ComputerType youWant = ComputerType.Server;

            Console.WriteLine("{0}", youWant.GetType());
            Console.WriteLine("{0}", Enum.GetName(youWant.GetType(), youWant));
            Console.WriteLine("{0}", GetComputerType(youWant));

            Console.WriteLine("===============================");

            var someType = ComputerType.Desktop;
            var values = Enum.GetValues(someType.GetType());
            foreach(var value in values)
            {
                Console.WriteLine("{0}", value);
            }

            Console.ReadKey();
        }
    }
}
