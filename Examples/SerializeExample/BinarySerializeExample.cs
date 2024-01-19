using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeExample
{
    public class BinarySerializeExample
    {
        public static void ShowExample()
        {
            var person = new Person
            {
                FirstName = "Nashinno",
                LastName = "Kako",
                Age = 30
            };

            var formatter = new BinaryFormatter();

            using (var stream = new FileStream(@"..\..\person.bin", FileMode.Create))
            {
                formatter.Serialize(stream, person);
            }

            using (var stream = new FileStream(@"..\..\person.bin", FileMode.Open))
            {
                var deserializePerson = formatter.Deserialize(stream) as Person;
                Console.WriteLine($"First Name: {deserializePerson.FirstName}");
                Console.WriteLine($"Last Name: {deserializePerson.LastName}");
                Console.WriteLine($"Age: {deserializePerson.Age}"); 
            }
        }
    }
}
