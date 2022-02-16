using System;
using System.Globalization;

namespace Exercício_Proposto_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Contract Payment Program ----------------");
            Console.WriteLine("|                                                       |");
            Console.WriteLine("| Enter the contract data:                              |");
            Console.WriteLine("| Number:                                               |");
            Console.Write("|                           "); int number = int.Parse(Console.ReadLine()); Console.Write("|");
            Console.WriteLine("| Date (dd/MM/yyyy):                                    |");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("| Contract Value:                                       |");
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine("| Enter Number of Installments:                         |");
            int installment = int.Parse(Console.ReadLine());
            Console.WriteLine("| Installments:                                         |");

        }
    }
}
