using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample05
{
    class Box : IDimensions
    {
        float lengthInches;
        float widthInches;

        public Box(float length, float width)
        {
            lengthInches = length;
            widthInches = width;
        }

        float IDimensions.GetLength()
        {
            return lengthInches;
        }

        float IDimensions.GetWidth()
        {
            return widthInches;
        }
    }
}
