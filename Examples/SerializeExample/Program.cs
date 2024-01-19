using System;


namespace SerializeExample
{


    class Program
    {
        static void Main(string[] args)
        {
            JsonSerializerExample.ShowExample();

            XmlSerializeExample.ShowExample();

            XmlDeserializeExample.ShowExample();

            BinarySerializeExample.ShowExample();

            Console.ReadLine();
        }
    }
}
