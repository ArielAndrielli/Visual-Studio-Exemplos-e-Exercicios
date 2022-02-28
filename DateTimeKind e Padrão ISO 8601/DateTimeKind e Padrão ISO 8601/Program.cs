using System;

namespace DateTimeKind_e_Padrão_ISO_8601
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DateTimeKind

            /*

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());
            Console.WriteLine("----------------------");
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to UTC: " + d2.ToUniversalTime());
            Console.WriteLine("----------------------");
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to UTC: " + d3.ToUniversalTime());

            */

            #endregion

            #region Padrão ISO 8601
            


            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());
            Console.WriteLine("----------------------");
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to UTC: " + d2.ToUniversalTime());
            Console.WriteLine("----------------------");
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // Caution!!!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
            


            #endregion

        }
    }
}
