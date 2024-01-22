using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int randomNumber = random.Next(); // 傳回非負值隨的機整數
            Console.WriteLine("randomNumber is {0}", randomNumber);

            randomNumber = random.Next(100); // 傳回小於指定之最大值的非負值隨機整數
            Console.WriteLine("randomNumber is {0}", randomNumber);

            randomNumber = random.Next(1, 6); // 傳回指定範圍內的隨機整數
            Console.WriteLine("randomNumber is {0}", randomNumber);

            Console.ReadKey();

        }
    }
}
