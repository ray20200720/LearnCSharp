using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    delegate void NotifyCallback(string str);
    class Example05
    {
        public static void ShowExample()
        {
            NotifyCallback del1 = new NotifyCallback(Notify);
            
            del1("Bill");

            NotifyCallback del2 = Notify;
            del2("Allen");

            NotifyCallback del3 = delegate (string name)
            {
                Console.WriteLine($"Notification received for: {name}");
            };
            del3("steven");

            NotifyCallback del4 = name =>
            {
                Console.WriteLine($"Notification received for: {name}");
            };
            del4("Jobs");
        }

        static void Notify(string name)
        {
            Console.WriteLine($"Notification received for: {name}");
        }
    }
}
