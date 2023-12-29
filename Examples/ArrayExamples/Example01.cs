using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Example01
    {
        public static void ShowExample()
        {
            //https://learn.microsoft.com/zh-tw/dotnet/csharp/language-reference/builtin-types/arrays

            Utl.PrintTitle("Example 1: creates single-dimensional, multidimensional, and jagged arrays:");

            Utl.PrintTitle("Declare a single-dimensional array of 5 integers.", 10);
            // Declare a single-dimensional array of 5 integers.
            int[] array1 = new int[5];

            foreach (var item in array1)
            {
                Console.Write("{0, 1} ", item);
            }

            Utl.PrintTitle("Declare and set array element values.", 10);
            // Declare and set array element values.
            int[] array2 = { 1, 2, 3, 4, 5 };


            foreach (var item in array2)
            {
                Console.Write("{0, 1} ", item);
            }

            Utl.PrintTitle("Declare a two dimensional array.", 10);
            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            foreach (var item in multiDimensionalArray1)
            {
                Console.Write("{0, 1} ", item);
            }

            Utl.PrintTitle("Declare and set array element values.", 10);
            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach (var item in multiDimensionalArray2)
            {
                Console.Write("{0, 1} ", item);
            }

            Utl.PrintTitle("Declare a jagged array.", 10);
            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[4];

            foreach (var arr in jaggedArray)
            {
                if (arr == null)
                    continue;
                else
                {
                    Console.Write("In array : ");
                    foreach (var item in arr)
                    {
                        Console.Write("{0, 1} ", item);
                    }
                }
            }
        }
    }
}
