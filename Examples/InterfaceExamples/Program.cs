using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sample = new SampleClass();

            IControl control = sample;
            ISurface surface = sample;

            sample.Paint();
            control.Paint();
            surface.Paint();

            Console.ReadKey();
        }
    }
}
