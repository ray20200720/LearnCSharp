using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample03
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sample = new SampleClass();

            IControl control = sample;
            ISurface surface = sample;

            // The following lines all call the same method.
            //sample.Paint();   // Compiler error.
            control.Paint();    // Calls IControl.Paint on SampleClass.
            surface.Paint();    // Calls ISurface.Paint on SampleClass.

            Console.Read();
        }
    }
}
