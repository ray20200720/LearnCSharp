using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeExamples
{
    enum ErrorCode : ushort
    {
        None = 0,
        Unknown = 1,
        ConnectionLost = 100,
        OutlierReading = 200
    }
}
