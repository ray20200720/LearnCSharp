using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/interfaces/explicit-interface-implementation
            SampleClass sample = new SampleClass();
            IControl control = sample;
            ISurface surface = sample;

            // The following lines all call the same method.
            sample.Paint();
            control.Paint();
            surface.Paint();

            Console.ReadKey();
        }
    }
}
