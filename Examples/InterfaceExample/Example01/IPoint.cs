using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample01
{
    interface IPoint
    {
        int X { get; set; }
        int Y { get; set; }
        double Distance { get; }
    }
}
