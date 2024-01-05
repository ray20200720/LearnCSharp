using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    public class Example03
    {
        public static void ShowExample()
        {
            var obj = new Example03();
            Callback d1 = obj.Method1;
            Callback d2 = obj.Method2;
            Callback d3 = Example01.DelegateMethod;

            Callback allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;


        }

        // Create a method for a delegate.
        public void Method1(string message) { }
        public void Method2(string message) { }
    }
}
