using Exercício_Proposto_Interfaces.Entities;
using Exercício_Proposto_Interfaces.Services;
using System;
using System.Globalization;

namespace Exercício_Proposto_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("________________Contract Payment Program_________________");
            Console.WriteLine("|                                                       |");
            Console.WriteLine("| Enter the contract data:                              |");
            Console.WriteLine("| Number:                                               |");
            Console.Write("| "); int number = int.Parse(Console.ReadLine());
            Console.WriteLine("|                                                       |");
            Console.WriteLine("| Date (dd/MM/yyyy):                                    |");
            Console.Write("| "); DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("| Contract Value:                                       |");
            Console.Write("| "); double value = double.Parse(Console.ReadLine());
            Console.WriteLine("| Enter Number of Installments:                         |");
            Console.Write("| "); int months = int.Parse(Console.ReadLine());


            Contract myContract = new Contract(number, date, value);

            PaymentService ps = new PaymentService(new PayPalService());
            ps.ProcessContract(myContract, months);

            Console.WriteLine("| Installments:                                         |");
            Console.WriteLine("|                                                       |");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine("| " + installment + "                                  |");
            }
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");


        }
    }
}
