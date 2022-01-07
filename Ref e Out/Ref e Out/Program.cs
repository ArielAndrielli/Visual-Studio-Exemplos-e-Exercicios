using System;

namespace Ref_e_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Ref
                /*static void Main(string[] args)
                {
                    int a = 10;
                    Calculator.Triple(ref a);
                    Console.WriteLine(a);
                }*/

                //Out

                int a = 10;
                int triple;

                Calculator.Triple(a, out triple);
                Console.WriteLine(triple);
            }
        }
    }
}
