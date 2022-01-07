using System;
using System.Collections.Generic;
using System.Text;

namespace Ref_e_Out
{
    class Calculator
    {
        //Ref
        /*public static void Triple(ref int x)
        {
            x = x * 3;
        }*/

        //Out
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
