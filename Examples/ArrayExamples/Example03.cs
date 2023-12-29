using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Example03
    {
        public static void ShowExample()
        {
            Utl.PrintTitle("Example 3: Pass single-dimensional arrays as arguments");

            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            DisplayArray(weekDays);
            Console.WriteLine();

            ChangeArray(weekDays);
            Console.WriteLine("Array weekDays after the call to ChangeArray:");
            DisplayArray(weekDays);
            Console.WriteLine();

            ChangeArrayElements(weekDays);
            Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
            DisplayArray(weekDays);
        }

        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));
        static void ChangeArray(string[] arr) => Array.Reverse(arr);

        static void ChangeArrayElements(string[] arr)
        {
            arr[0] = "Mon";
            arr[1] = "Wed";
            arr[2] = "Fri";
        }
    }
}
