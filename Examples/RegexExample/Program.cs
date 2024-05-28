using System;

namespace RegexExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            string pattern = "Hello";
            bool result = System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
            Console.WriteLine(result);

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
