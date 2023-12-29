using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    class Example05
    {
        /// <summary>
        /// Example 5: Retrieve a singleton value about the source data
        /// </summary>
        public static void ShowExample()
        {
            // https://learn.microsoft.com/zh-tw/dotnet/csharp/linq/get-started/query-expression-basics

            Utl.PrintTitle("Example 5: Retrieve a singleton value about the source data");

            int[] scores = { 97, 92, 81, 60 };

            var highScoreCount = (from score in scores
                                  where score > 80
                                  select score).Count();

            Console.Write("High Score Count: {0,1} ", highScoreCount);
        }

        /// <summary>
        /// use a new variable to store the concrete result
        /// </summary>
        public static void ShowExample2()
        {
            // https://learn.microsoft.com/zh-tw/dotnet/csharp/linq/get-started/query-expression-basics

            Utl.PrintTitle("Example 5: use a new variable to store the concrete result");

            int[] scores = { 97, 92, 81, 60 };

            IEnumerable<int> highScoreQuery3 = from score in scores 
                                               where score > 80 
                                               select score;

            var scoreCount = highScoreQuery3.Count();

            Console.Write("High Score Count: {0,1} ", scoreCount);
        }
    }
}
