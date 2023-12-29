using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductID = "A3C027847", Model = "PCIW94YEQ00Y", CUSTSN = "C2L35104DH", CartonSN = "A3C200001", DeliveryNo = "4128319764000010", PalletNo = "0377102418", UnitWeight = 2.22m },
                new Product { ProductID = "A3C027848", Model = "PCIW94YEQ00Y", CUSTSN = "C2L35104DJ", CartonSN = "A3C200001", DeliveryNo = "4128319764000010", PalletNo = "0377102418", UnitWeight = 2.22m },
                new Product { ProductID = "A3C027849", Model = "PCIW94YEQ00Y", CUSTSN = "C2L35104DK", CartonSN = "A3C200001", DeliveryNo = "4128319764000010", PalletNo = "0377102418", UnitWeight = 2.22m },
                new Product { ProductID = "A3C027850", Model = "PCIW94YEQ00Y", CUSTSN = "C2L35104DL", CartonSN = "A3C200001", DeliveryNo = "4128319764000010", PalletNo = "0377102418", UnitWeight = 2.22m },
                new Product { ProductID = "A3C027851", Model = "PCIW94YEQ00Y", CUSTSN = "C2L35104DM", CartonSN = "A3C200001", DeliveryNo = "4128319764000010", PalletNo = "0377102418", UnitWeight = 2.22m },
                new Product { ProductID = "A3C027852", Model = "PCIW94YEQ00Y", CUSTSN = "C2L35104DN", CartonSN = "A3C200002", DeliveryNo = "4128319764000010", PalletNo = "0377102419", UnitWeight = 2.21m },
                new Product { ProductID = "A3C027853", Model = "PCIW94YEQ00Y", CUSTSN = "C2L35104DP", CartonSN = "A3C200002", DeliveryNo = "4128319764000010", PalletNo = "0377102419", UnitWeight = 2.21m },
                new Product { ProductID = "A3C027854", Model = "PCIW94YEQ00Y", CUSTSN = "C2L35104DQ", CartonSN = "A3C200002", DeliveryNo = "4128319764000010", PalletNo = "0377102419", UnitWeight = 2.21m },
                new Product { ProductID = "A3C027855", Model = "PCIW94YEQ00Y", CUSTSN = "C2L35104DR", CartonSN = "A3C200002", DeliveryNo = "4128319764000010", PalletNo = "0377102419", UnitWeight = 2.21m },
                new Product { ProductID = "A3C027856", Model = "PCIW94YEQ00Y", CUSTSN = "C2L35104DS", CartonSN = "A3C200002", DeliveryNo = "4128319764000010", PalletNo = "0377102419", UnitWeight = 2.21m },
            };

            var list = products.Where(x => !string.IsNullOrEmpty(x.CartonSN)).Select(x => x.CartonSN).Distinct().ToList();

            if (list.Count == 0)
            {
                list = products.Select(x => x.ProductID).ToList();
            }

            foreach (var item in list)
            {
                Console.WriteLine(string.Format("item: {0}", item));

                var SYSSERIALNO = products.Where(x => x.CartonSN == item || x.ProductID == item).FirstOrDefault().CUSTSN;
                Console.WriteLine(string.Format("SYSSERIALNO: {0}", SYSSERIALNO));

                //var DeliveryDatestamp = products.Where(x => x.CartonSN == item || x.ProductID == item).FirstOrDefault().Delivery.ShipDate;

                var DeliveryNo = products.Where(x => x.CartonSN == item || x.ProductID == item).FirstOrDefault().DeliveryNo;
                Console.WriteLine(string.Format("DeliveryNo: {0}", DeliveryNo));

                //var PO = products.Where(x => x.CartonSN == item || x.ProductID == item).FirstOrDefault().Delivery.PoNo;

                var Weight = Math.Round((decimal)(((double)products.Where(x => x.CartonSN == item || x.ProductID == item).Sum(y => y.UnitWeight)) * 2.20462), 2);
                Console.WriteLine(string.Format("Weight: {0}", Weight));
            }

            // Select: 返回IEnumerable<string>
            var list2 = products.Select(x => x.ProductID);
            foreach (var productID in list2)
            {
                Console.WriteLine(string.Format("ProductID:{0}", productID));
            }

            // Where: 返回IEnumerable<Proudct>
            var matchProductID = "A3C027851";
            var list3 = products.Where(x => x.ProductID == matchProductID);
            foreach (var product in list3)
            {
                Console.WriteLine(product.ProductID);
                Console.WriteLine(product.CUSTSN);
                Console.WriteLine(product.CartonSN);
            }

            // Distinct: 返回IEnumerable<Proudct>
            var list4 = products.Distinct();
            foreach (var item in list4)
            {
                Console.WriteLine(string.Format("list4 ProductID:{0}", item.ProductID));
            }

            //先Select再Distinct: 返回IEnumerable<string>
            var list5 = products.Select(x => x.CartonSN).Distinct();
            foreach (var item in list5)
            {
                Console.WriteLine(string.Format("list5 item:{0}", item));
            }

            //先Where再Distinct: 返回IEnumerable<Proudct>
            var list6 = products.Where(x => x.DeliveryNo == "4128319764000010" && x.PalletNo == "0377102418").Distinct();
            foreach (var item in list6)
            {
                Console.WriteLine(string.Format("list6 ProductID:{0}", item.ProductID));
            }

            //先Where再Select然後Distinct: 返回IEnumerable<string>
            var list7 = products.Where(x => x.DeliveryNo == "4128319764000010" && x.PalletNo == "0377102418").Select(x => x.PalletNo).Distinct();
            foreach (var item in list7)
            {
                Console.WriteLine(string.Format("list7 PalletNo:{0}", item));
            }

            var list8 = products.Where(x => !string.IsNullOrEmpty(x.CartonSN)).Select(x => x.CartonSN).Distinct().ToList();
            foreach (var item in list8)
            {
                var totalweight = Math.Round((decimal)(((double)products.Where(x => x.CartonSN == item || x.ProductID == item).Sum(y => y.UnitWeight)) * 2.20462), 2);
                Console.WriteLine(string.Format("totalweight: {0}", totalweight));
            }

            var groupedProducts =
                products
                .GroupBy(p => new { p.PalletNo, p.DeliveryNo })
                .Select(group => new
                {
                    PalletNo = group.Key.PalletNo,
                    DeliveryNo = group.Key.DeliveryNo,
                    Products = group.ToList()
                });

            foreach(var product in groupedProducts)
            {
                Console.WriteLine(string.Format("{0} {1}", product.PalletNo, product.DeliveryNo));
                foreach(var p in product.Products)
                {
                    Console.WriteLine(string.Format("{0} {1}", p.CUSTSN, p.ProductID));
                }
            }

            Console.ReadKey();
        }
    }
}
