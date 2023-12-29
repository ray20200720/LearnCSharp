using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Example05
    {
        public static void ShowExample()
        {
            Utl.PrintTitle("Example 5: ");

            int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            foreach(int i in numbers2D)
            {
                System.Console.Write($"{i} ");
            }
            // Output: 9 99 3 33 5 55
            
            Console.WriteLine();

            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            foreach (int i in array3D)
            {
                System.Console.Write($"{i} ");
            }
            // Output: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
        }
    }
}
