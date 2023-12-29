using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    class Example06
    {
        /// <summary>
        /// Query variable
        /// </summary>
        public static void ShowExample()
        {
            // https://learn.microsoft.com/zh-tw/dotnet/csharp/linq/get-started/query-expression-basics

            Utl.PrintTitle("Example 6: Query variable");

            int[] scores = [90, 71, 82, 93, 75, 82];

            IEnumerable<int> scoreQuery = from score in scores
                                          where score > 80
                                          orderby score descending
                                          select score;

            foreach(var testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }
        }
    }
}
