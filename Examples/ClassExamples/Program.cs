using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Product macAir = new Product("Mac Air");
                macAir.Price = 10;
                //macAir.Name = "I'm not Mac Air"; // error, Name is readonly
                Console.WriteLine("{0} {1}", macAir.Name, macAir.Price);

                Product mac = new Product("Mac");
                mac.Price = 20;
                Console.WriteLine("{0} {1}", mac.Name, mac.Price);

                Product iPhone = new Product("iPhone");
                iPhone.Price = -99;
                Console.WriteLine("{0} {1}", iPhone.Name, iPhone.Price);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadKey();
        }
    }
}
