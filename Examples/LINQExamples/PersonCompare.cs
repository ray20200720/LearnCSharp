using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    class PersonCompare : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
