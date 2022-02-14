using System;
using Exercício_Proposto_Conta_Bancaria.Entities;
using Exercício_Proposto_Conta_Bancaria.Entities.Exceptions;

namespace Exercício_Proposto_Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account();

                Console.WriteLine("Enter Account Data: ");
                Console.Write("Number: ");
                account.Number = int.Parse(Console.ReadLine());
                Console.Write("Initial Balance: ");
                account.Balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                account.WithdrawLimit = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Enter the amount for withdraw: ");
                double withValue = double.Parse(Console.ReadLine());
                account.Withdraw(withValue);
                Console.Write("New Balance: " + account.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Operation Error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unanticipated Error: " + e.Message);
            }
        }
    }
}
