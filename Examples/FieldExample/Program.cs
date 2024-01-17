using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldExample
{
    public class Constants
    {
        public const double Pi = 3.1416;    // 常數，它的值是在設計階段指派。 雖然並不會使用 static 關鍵字定義，但是這些常數都是類別的靜態成員。
        public readonly DateTime BirthDate; // 唯讀變數，其值可以在類別建構函式中進行指派。

        public Constants(DateTime birthDate)
        {
            this.BirthDate = birthDate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Constants con = new Constants(new DateTime(1974, 8, 18));
            Console.Write(Constants.Pi + "\n");
            Console.Write(con.BirthDate.ToString("d") + "\n");

            Console.ReadKey();
        }
    }
}
