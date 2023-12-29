using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveCSharpExamples
{
    class Program
    {
        public const int BUFFER_SIZE = 1024; //編譯時常數
        public static readonly int BUFFER_SIZE2 = 512; //運行時常數

        static void Main(string[] args)
        {
            byte[] bytes = new byte[BUFFER_SIZE];       //在編譯後會被編譯器替換成該常數值
            byte[] otherbytes = new byte[BUFFER_SIZE2]; //該常數值在運行時才會被計算，編譯後並不會被編譯器替換常數值

            var f = GetMagicNumber();
            var total = 100 * f / 6;
            Console.WriteLine($"Declared Type: {total.GetType().Name}, Value: {total}");

            Console.ReadKey();
        }

        //static int GetMagicNumber()
        //{
        //    return 10;
        //}

        //static double GetMagicNumber()
        //{
        //    return 10.0;
        //}

        //static Single GetMagicNumber()
        //{
        //    return 10;
        //}

        static Decimal GetMagicNumber()
        {
            return 10;
        }
    }
}
