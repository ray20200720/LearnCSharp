using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    class SampleClass : IControl, ISurface
    {
        public void Paint()
        {
            Console.WriteLine("Paint method in SampleClass");
        }

        void IControl.Paint()
        {
            System.Console.WriteLine("IControl.Paint");
        }

        void ISurface.Paint()
        {
            System.Console.WriteLine("ISurface.Paint");
        }
    }
}
