using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    delegate void CallbackInSampleClass();

    class SampleClass
    {
        public void InstanceMethod()
        {
            Console.WriteLine("A message from the instance method.");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("A message from the static method.");
        }
    }
}
