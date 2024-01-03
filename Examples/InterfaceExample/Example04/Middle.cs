using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample04
{
    class Middle : ILeft, IRight
    {
        public int P() { return 2; }
        int ILeft.P { get { return 1; } }
    }
}
