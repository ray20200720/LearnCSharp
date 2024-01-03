using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    class Product
    {
        private string name; // field
        public string Name // property and read-only
        { 
            get { return name; }
            //set { name = value; }
        }

        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    price = 0;
                    throw new Exception("price does not allow be negative");
                }
                else
                {
                    price = value;
                }
            }
        }
        
        public Product(string initialName)
        {
            name = initialName;
        }
    }
}
