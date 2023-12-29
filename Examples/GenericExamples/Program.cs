using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExamples
{
    class GenericList<T>
    {
        public void Add(T input) { }
    }

    class GenericTypeConstraintList<T> where T : IComparable
    {
        public void Add(T input) { }

        public int Compare(GenericTypeConstraintList<T> other)
        {
            if (other == null) return 1;

            return 0;
        }
    }

    class Ahui<T, T2> where T : IComparable where T2 : IComparable
    {
        public T Age;
        public T2 Name;
    }

    class ExampleClass { }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);

            GenericList<string> list2 = new GenericList<string>();
            list2.Add("");

            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());

            GenericTypeConstraintList<int> list4 = new GenericTypeConstraintList<int>();
            list4.Add(1);

            GenericTypeConstraintList<int> list5 = null;

            var ret = list4.Compare(list5);
            Console.WriteLine(ret);

            Ahui<int, string> ahui = new Ahui<int, string>();
            ahui.Name = "ahui";
            ahui.Age = 18;

            Ahui<string, string> ahui1 = new Ahui<string, string>();
            ahui1.Name = "AHui";
            ahui1.Age = 18.ToString();


            Console.ReadKey();
        }
    }
}
