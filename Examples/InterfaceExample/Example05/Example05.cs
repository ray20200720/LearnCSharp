using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample05
{
    class Example05
    {
        /// <summary>
        /// // https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/interfaces/how-to-explicitly-implement-interface-members
        /// </summary>
        public static void ShowExample()
        {
            // Declare a class instance box1:
            Box box1 = new Box(30.0f, 20.0f);

            // Declare an interface instance dimensions:
            IDimensions dimensions = box1;
            //var dimensions = box1 as IDimensions;

            // The following commented lines would produce compilation
            // errors because they try to access an explicitly implemented
            // interface member from a class instance:
            //System.Console.WriteLine("Length: {0}", box1.GetLength());
            //System.Console.WriteLine("Width: {0}", box1.GetWidth());

            // Print out the dimensions of the box by calling the methods
            // from an instance of the interface:
            Console.WriteLine("Length: {0}", dimensions.GetLength());
            Console.WriteLine("Width: {0}", dimensions.GetWidth());
        }
    }
}
