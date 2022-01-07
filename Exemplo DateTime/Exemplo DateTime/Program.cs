using System;
using System.Globalization;

namespace Exemplo_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
               DateTime d1 = DateTime.Now;
               Console.WriteLine(d1);
               Console.WriteLine(d1.Ticks);
            */

            DateTime d1 = new DateTime(2022, 1, 5);
            DateTime d2 = new DateTime(2022, 1, 5, 11, 15, 20);
            DateTime d3 = new DateTime(2022, 1, 5, 11, 15, 20, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            DateTime d7 = DateTime.Parse("2008-08-15");
            DateTime d8 = DateTime.Parse("2008-08-15 13:05:58");

            DateTime d9 = DateTime.Parse("15/08/2008");
            DateTime d10 = DateTime.Parse("15/08/2008 13:08:58");

            DateTime d11 = DateTime.ParseExact("2008-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2008", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine("----------------------");
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine("----------------------");
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine("----------------------");
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine("----------------------");
            Console.WriteLine(d11);
            Console.WriteLine(d12);

        }
    }
}
