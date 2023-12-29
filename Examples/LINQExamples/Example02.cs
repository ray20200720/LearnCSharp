using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    class Example02
    {
        /// <summary>
        /// Example 2: Three Parts of a Query Operation
        /// </summary>
        public static void ShowExample()
        {
            // https://learn.microsoft.com/zh-tw/dotnet/csharp/linq/get-started/introduction-to-linq-queries

            Utl.PrintTitle("Example 2: Three Parts of a Query Operation");

            // 1.Obtain the data source.
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            // 2.Create the query.
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            // 3.Execute the query.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }
    }
}
