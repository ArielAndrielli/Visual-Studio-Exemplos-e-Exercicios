using Course;
using System;

namespace Modificador_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //int s1 = Calculator.Sum(new int[] { 2, 3 });
            //int s2 = Calculator.Sum(new int[] { 2, 4, 3 });

            //Instanciando com params

            int s1 = Calculator.Sum( 2, 3 );
            int s2 = Calculator.Sum( 2, 4, 3 );

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
