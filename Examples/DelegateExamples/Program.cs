using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/delegates/using-delegates

            //Example01.ShowExample();
            //Example02.ShowExample();
            //Example03.ShowExample();

            //MathClass.ShowExample();

            //SampleClass sc = new SampleClass();

            //CallbackInSampleClass d = sc.InstanceMethod;
            //d();

            //d = SampleClass.StaticMethod;
            //d();

            //Example04.ShowExample();

            Example05.ShowExample();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
