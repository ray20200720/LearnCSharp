using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Example01.ShowExample();

            Example02.ShowExample();

            Example03.ShowExample();

            Example04.ShowExample();

            Example05.ShowExample();

            Example05.ShowExample2();

            Example06.ShowExample();

            Utl.PrintTitle("Distinct Example ");

            #region Distinct Example 
            // Distinct
            var datas = new List<Person>();
            int idx = 0;
            for (idx = 0; idx < 10; idx ++)
            {
                datas.Add(new Person() { ID = idx.ToString(), Name = "Larray" });
            }
            datas.Add(new Person() { ID = idx.ToString(), Name = "LastLarray" });

            // 直接做Distinct()無效
            //var distinctDatas = datas.Distinct();
            //ShowDatas(distinctDatas);

            // 編寫一個 PersonCompare
            var distinctDatas = datas.Distinct(new PersonCompare());
            ShowDatas(distinctDatas);

            //var distinctDatas = from data in datas group data by data.Name into g select g.First();

            //var distinctDatas = datas.Select(x => x.Name).Distinct();

            //var distinctDatas = datas.GroupBy(x => x.Name)
            //    .Select(x => new 
            //    { 
            //        Name = x.Key,
            //        Count = x.Count()
            //    }).Distinct();

            //foreach(var data in distinctDatas)
            //{
            //    Console.WriteLine("{0} {1}", data.Name, data.Count);
            //}

            //ShowDatas(distinctDatas);
            #endregion

            Utl.PrintTitle("Example Using LINQ Query Syntax in C#");
            
            #region Example Using LINQ Query Syntax in C#
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var IntegerListQuerySyntax = from obj in integerList    // Data Source
                                         where obj > 5              // Condition
                                         select obj;                // Selection

            foreach(var item in IntegerListQuerySyntax)
            {
                Console.Write(item + " ");
            }
            #endregion

            Utl.PrintTitle("Example Using LINQ Method Syntax in C#");

            #region Example Using LINQ Method Syntax in C#
            var methodSyntax = integerList.Where(obj => obj > 5).ToList();
            foreach (var item in methodSyntax)
            {
                Console.Write(item + " ");
            }
            #endregion

            Utl.PrintTitle("Example Using LINQ Mixed Syntax in C#");

            #region Example Using LINQ Mixed Syntax in C#
            var mixedSyntax = (from obj in integerList
                                 where obj > 5
                                 select obj).Sum();

            Console.Write("Sum Is : " + mixedSyntax);
            #endregion

            #region IEnumerable and IQueryable in C#
            // Reference: https://dotnettutorials.net/lesson/ienumerable-iqueryable-csharp/

            // IEnumerable<T> & IQueryable<T> Common Data
            List< Student > studentList = new List<Student>
            {
                new Student() { ID = 1, Name = "James", Gender = "Male" },
                new Student() { ID = 2, Name = "Sara", Gender = "Female" },
                new Student() { ID = 3, Name = "Steve", Gender = "Male" },
                new Student() { ID = 4, Name = "Pam", Gender = "Female" },
            };

            Utl.PrintTitle("IEnumerable<T> Example");

            #region IEnumerable<T> Example

            IEnumerable<Student> QuerySyntax = from std in studentList
                                               where std.Gender == "Male"
                                               select std;
            foreach(var student in QuerySyntax)
            {
                Console.WriteLine($"ID : {student.ID} Name: {student.Name}");
            }

            #endregion

            Utl.PrintTitle("IQueryable<T> Example");

            #region IQueryable<T> Example

            IQueryable < Student > MethodSyntax = studentList.AsQueryable()
                .Where(std => std.Gender == "Male");

            foreach(var student in MethodSyntax)
            {
                Console.WriteLine($"ID : {student.ID} Name: {student.Name}");
            }
            #endregion

            #endregion

            Console.ReadKey();
        }

        private static void ShowDatas<T>(IEnumerable<T> datas)
        {
            foreach (var data in datas)
            {
                Console.WriteLine(data.ToString());
            }
        }

        
    }
}
