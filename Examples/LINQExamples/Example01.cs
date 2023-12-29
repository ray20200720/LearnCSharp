using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    class Example01
    {
        /// <summary>
        /// Example 1: Language Integrated Query (LINQ) 
        /// </summary>
        public static void ShowExample()
        {
            //https://learn.microsoft.com/en-us/dotnet/csharp/linq/

            Utl.PrintTitle("Example 1: Language Integrated Query (LINQ) ");

            int[] scores = { 97, 92, 81, 60 };

            IEnumerable<int> scoreQuery = from score in scores
                                          where score > 80
                                          select score;

            foreach (var i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }
    }
}
