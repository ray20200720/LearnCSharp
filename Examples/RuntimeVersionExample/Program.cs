using System;
using System.Runtime.InteropServices;


namespace RuntimeVersionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(object).Assembly.Location);

            Console.WriteLine(Environment.Version);

            // .NET Framework 4.7.1 以上
            Console.WriteLine($"Runtime: {RuntimeInformation.FrameworkDescription}");

            Console.Read();
        }
    }
}
