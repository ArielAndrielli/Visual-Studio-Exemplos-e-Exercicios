using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_STRUCT
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }

    }
}
