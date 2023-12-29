using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Console.WriteLine(check ? "Checked" : "Not checked");

            int num = 123;
            Console.WriteLine($"{num.GetType()} {num}");

            // 數值後綴加上 f or F,則為 float 類型. 
            var f = 1.23F;
            Console.WriteLine($"{f.GetType()} {f}");

            // 數值沒有後綴,則為 double 類型. 
            // 數值後綴加上 d or D則為 double 類型.
            var d = 12.3;
            Console.WriteLine($"{d.GetType()} {d}");

            // decimal 需要加上後綴 m or M
            decimal myMoney = 3_000.5m;
            decimal yourMoney = 400.75M;

            Console.WriteLine($"MyMoney:{myMoney.GetType()} {myMoney} YourMoney:{yourMoney.GetType()} {yourMoney}");


            char c = 'a';
            Console.WriteLine($"{c.GetType()} {c}");

            string name = "ray";
            Console.WriteLine($"{name.GetType()} {name}");

            int[] source = { 0, 1, 2, 3, 4, 5 };
            Console.WriteLine($"{source.GetType()} : {source[0]}");

            var limit = 3;
            var query = from item in source
                        where item <= limit
                        select item;
            Console.WriteLine($"{query.GetType()}");

            var o = new object();
            Console.WriteLine($"{o.GetType()}");

            Season currentSeason = Season.Winters;
            Console.WriteLine($"{currentSeason.GetType()} : {currentSeason}");

            ErrorCode error = ErrorCode.Unknown;
            Console.WriteLine($"{error.GetType()} : {error}");

            Coords coords = new Coords(10, 20);
            Console.WriteLine($"{coords.GetType()} : {coords.ToString()}");

            Book book1;
            book1.title = "C# Programming";
            book1.author = "Allen";
            book1.price = 29;

            Console.WriteLine("Book 1 title : {0}", book1.title);
            Console.WriteLine("Book 1 author : {0}", book1.author);
            Console.WriteLine("Book 1 price :{0}", book1.price);
            Console.WriteLine($"{book1.GetType()}");


            Console.ReadLine();
        }
    }
}
