using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Example02
    {
        public static void ShowExample()
        {
            Utl.PrintTitle("Example 02: Single-dimensional arrays");

            int[] array = new int[5];
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            Console.WriteLine(weekDays[0]);
            Console.WriteLine(weekDays[1]);
            Console.WriteLine(weekDays[2]);
            Console.WriteLine(weekDays[3]);
            Console.WriteLine(weekDays[4]);
            Console.WriteLine(weekDays[5]);
            Console.WriteLine(weekDays[6]);
        }
    }
}
