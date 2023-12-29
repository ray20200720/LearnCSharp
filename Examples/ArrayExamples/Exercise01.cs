using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Exercise01
    {
        public static void DoWork()
        {
            Utl.PrintTitle("Exercise 01: ");

            int[] myArray = { 1, 2, 3, 4, 5 };
            int[,] my2DArray = { { 1, 2 }, { 3, 4 } };
            int[,,] my3DArray = new int[2,2,2];
            
            Console.WriteLine(myArray.Rank);
            Console.WriteLine(my2DArray.Rank);
            Console.WriteLine(my3DArray.Rank);

            foreach(var item in my3DArray)
            {
                Console.WriteLine(item);
            }

            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5,  6 } },
                                { { 7, 8, 9 }, { 10, 11, 12 } } };

            foreach (var item in array3D)
            {
                Console.WriteLine(item);
            }
        }
    }
}
