using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    public delegate void Callback(string message); 
    class Example01
    {
        public static void ShowExample()
        {
            // Instantiate the delegate.
            Callback handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");
        }

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
