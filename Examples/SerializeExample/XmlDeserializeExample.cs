using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializeExample
{
    public class XmlDeserializeExample
    {
        public static void ShowExample()
        {
            var serilizer = new XmlSerializer(typeof(Person));
            using (var stream = new FileStream(@"..\..\person.xml", FileMode.Open))
            {
                var person = serilizer.Deserialize(stream) as Person;
                Console.WriteLine($"First Name: {person.FirstName}");
                Console.WriteLine($"Last Name: {person.LastName}");
                Console.WriteLine($"Age: {person.Age}");
            }

        }
    }
}
