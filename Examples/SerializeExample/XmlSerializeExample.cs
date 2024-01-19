using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializeExample
{
    public class XmlSerializeExample
    {
        public static void ShowExample()
        {
            var person = new Person
            {
                FirstName = "Ray",
                LastName = "Kuo",
                Age = 30
            };

            var serializer = new XmlSerializer(typeof(Person));
            using(var stream = new FileStream(@"..\..\person.xml", FileMode.Create))
            {
                serializer.Serialize(stream, person);
            }
        }
    }
}
