using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var DBContext = new HPIMESEntities())
            {
                //var query = context.Product
                //                   .Where(s => s.ProductID == "Bill")
                //                   .FirstOrDefault<Product>();

                #region IEnumerable

                //IEnumerable<Product> listProducts = DBContext.Product.Where(x => x.Model == "PCHF4002M00Y");
                //listProducts = listProducts.Take(2);

                //Console.WriteLine("Top 2 Product Where Model = PCHF4002M00Y");
                //foreach (var product in listProducts)
                //{
                //    Console.WriteLine(product.Model + " " + product.ProductID);
                //}

                #endregion

                #region IQueryable

                IQueryable<Product> listProducts2 = DBContext.Product
                                                    .AsQueryable()
                                                    .Where(x => x.Model == "PCHF4002M00Y");
                
                listProducts2 = listProducts2.Take(2);
                
                Console.WriteLine("Top 2 Product Where Model = PCHF4002M00Y");

                foreach (var product in listProducts2)
                {
                    Console.WriteLine(product.Model + " " + product.ProductID);
                }

                #endregion
            }

            Console.ReadKey();
        }
    }
}
