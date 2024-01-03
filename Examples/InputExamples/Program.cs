using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            
            string yourName = Console.ReadLine();

            Console.WriteLine("Hi, {0}", yourName);

            Console.WriteLine("How old are you?");

            int yourAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is: {0}", yourAge);

            Console.ReadKey();
        }
    }
}
