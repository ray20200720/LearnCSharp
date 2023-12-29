using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Example04
    {
        public static void ShowExample()
        {
            Utl.PrintTitle("Example 4: Multidimensional arrays");

            int[,] array2DDeclaration = new int[4, 2];
            int[,,] array3DDeclaration = new int[4, 2, 3];

            // Two - dimensional array.
            int[,] array2DInitialization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // Three-dimensional array.
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4,   5,  6 } },
                                            { { 7, 8, 9 }, { 10, 11, 12 } } };
            // Accessing array elements.
            System.Console.WriteLine(array2DInitialization[0, 0]);
            System.Console.WriteLine(array2DInitialization[0, 1]);
            System.Console.WriteLine(array2DInitialization[1, 0]);
            System.Console.WriteLine(array2DInitialization[1, 1]);

            System.Console.WriteLine(array2DInitialization[3, 0]);
            System.Console.WriteLine(array2DInitialization[3, 1]);

            System.Console.WriteLine(array3D[1, 0, 1]);
            System.Console.WriteLine(array3D[1, 1, 2]);

            // Getting the total count of elements or the length of a given dimension.
            var allLength = array3D.Length;
            var total = 1;
            for (int i = 0; i < array3D.Rank; i++)
            {
                total *= array3D.GetLength(i);
            }
            System.Console.WriteLine($"{allLength} equals {total}");
        }
    }
}
