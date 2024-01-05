using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    class Example02
    {
        public static void ShowExample()
        {
            Callback handler = Example01.DelegateMethod;
            // Call the delegate.
            MethodWithCallback(1, 2, handler);
        }

        // Create a method for a delegate.
        public static void MethodWithCallback(int param1, int param2, Callback callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
    }
}
