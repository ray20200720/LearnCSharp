using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample02
{
    class Example02
    {
        /// <summary>
        /// https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/interfaces/explicit-interface-implementation
        /// </summary>
        public static void ShowExample()
        {
            
            SampleClass sample = new SampleClass();
            IControl control = sample;
            ISurface surface = sample;

            // The following lines all call the same method.
            sample.Paint();
            control.Paint();
            surface.Paint();
        }
    }
}
