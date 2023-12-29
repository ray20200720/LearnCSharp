using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    class Example03
    {
        /// <summary>
        /// Example 3: Query expression basics
        /// </summary>
        public static void ShowExample()
        {
            // https://learn.microsoft.com/zh-tw/dotnet/csharp/linq/get-started/query-expression-basics

            Utl.PrintTitle("Example 3: Query expression basics");

            int[] scores = { 97, 92, 81, 60 };

            IEnumerable<int> highScoresQuery =
                 from score in scores
                 where score > 80
                 orderby score ascending
                 select score;

            foreach (int score in highScoresQuery)
            {
                Console.Write("{0,1} ", score);
            }
        }
    }
}
