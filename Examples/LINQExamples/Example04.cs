using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    class Example04
    {
        /// <summary>
        /// Example 4: Retrieve a sequence of elements but transform them to a new type of object.
        /// </summary>
        public static void ShowExample()
        {
            // https://learn.microsoft.com/zh-tw/dotnet/csharp/linq/get-started/query-expression-basics

            Utl.PrintTitle("Example 4: Retrieve a sequence of elements but transform them to a new type of object.");

            int[] scores = { 97, 92, 81, 60 };

            IEnumerable<string> highScoresQuery2 =
                from score in scores
                where score > 80
                orderby score descending
                select $"The score is {score}";

            foreach (var query in highScoresQuery2)
            {
                Console.WriteLine("{0,1} ", query);
            }
        }
    }
}
