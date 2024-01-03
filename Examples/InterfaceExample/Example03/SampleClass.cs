using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample03
{
    class SampleClass : IControl, ISurface
    {
        // 若要根據使用的介面呼叫不同的實作，您可以明確地實作介面成員。
        void IControl.Paint()
        {
            Console.WriteLine("IControl.Paint");
        }

        void ISurface.Paint()
        {
            Console.WriteLine("ISurface.Paint");
        }
    }
}
