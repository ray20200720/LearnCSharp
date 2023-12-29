using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIListExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> iList = new List<string>();
            iList.Add("HP");
            iList.Add("Apple");
            iList.Add("Dell");
            iList.Add("Microsoft");

            List<string> list = new List<string>();
            list.Add("HP");
            list.Add("Apple");
            list.Add("Dell");
            list.Add("Microsoft");

            // iList.Sort(); IList<T>沒有實作Sort()方法,所以用不了
            foreach (string lst in iList)
            {
                Console.WriteLine(lst);
            }

            var reverseiList = iList.Reverse();

            foreach (string lst in reverseiList)
            {
                Console.WriteLine(lst);
            }

            var c = iList.Count;
            Console.WriteLine($"count: {c}");

            var readOnly = iList.IsReadOnly;
            Console.WriteLine($"readOnly: {readOnly}");

            list.Sort();
            
            foreach (string lst in list)
            {
                Console.WriteLine(lst);
            }

            list.Reverse();

            foreach (string lst in list)
            {
                Console.WriteLine(lst);
            }

            Console.ReadLine();
        }
    }
}
