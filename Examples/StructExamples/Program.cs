using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExamples
{
    struct Product
    {
        public int ProductID;
        public double Price;
        public string Description;

        public Product(int id, double price, string desc)
        {
            ProductID = id;
            Price = price;
            Description = desc;
        }

        public void SetValues(int id, double price, string desc)
        {
            ProductID = id;
            Price = price;
            Description = desc;
        }

        public void ShowData()
        {
            Console.WriteLine("ProductID: {0}", ProductID);
            Console.WriteLine("Price: {0}", Price);
            Console.WriteLine("Description: {0}", Description);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product1;
            Product product2;

            product1.ProductID = 1;
            product1.Price = 10;
            product1.Description = "I'm Envy";

            product2.ProductID = 2;
            product2.Price = 20;
            product2.Description = "I'm XPS";

            Console.WriteLine("==================== 我是分隔線 ====================");

            Console.WriteLine("Product 1 ProductID: {0}", product1.ProductID);
            Console.WriteLine("Product 1 Price: {0}", product1.Price);
            Console.WriteLine("Product 1 Description: {0}", product1.Description);

            Console.WriteLine("==================== 我是分隔線 ====================");

            Console.WriteLine("Product 2 ProductID: {0}", product2.ProductID);
            Console.WriteLine("Product 2 Price: {0}", product2.Price);
            Console.WriteLine("Product 2 Description: {0}", product2.Description);

            Console.WriteLine("==================== 我是分隔線 ====================");

            Product proudct3 = new Product();
            proudct3.SetValues(3, 30, "I'm Mac");
            proudct3.ShowData();

            Console.WriteLine("==================== 我是分隔線 ====================");

            Product proudct4 = new Product(4, 40, "I'm Raspberry Pi 4");
            proudct4.ShowData();

            Console.ReadKey();
        }
    }
}
