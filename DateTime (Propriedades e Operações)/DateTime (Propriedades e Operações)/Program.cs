using System;

namespace DateTime__Propriedades_e_Operações_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2020, 12, 27, 20, 30, 45, 328);

            #region Propriedades do DateTime
            /*

            Console.WriteLine(d);
            Console.WriteLine("----------------------------");
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            */
            #endregion

            #region Formatação DateTime
            /*

            //Console.WriteLine(d.ToLongDateString());

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd  HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd  HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine("-----------------");
            Console.WriteLine(s5);
            Console.WriteLine("-----------------");
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            */
            #endregion

            #region Operações DateTime
            
            //As operações são essas depois do d, d2 (ex: .Subtract() / .AddHours())
            
            /*
            DateTime d = DateTime.Now;
            DateTime d2 = d.AddDays(7);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            */

            /*
            DateTime d1 = new DateTime(2000, 10, 15);
            DateTime d2 = new DateTime(2000, 10, 20);

            TimeSpan t = d2.Subtract(d1);

            Console.WriteLine(t);
            */

            #endregion
        }
    }
}
