using Exemplo_Classes_Metodos_Selados.Entities;
using System;

namespace Exemplo_Classes_Metodos_Selados
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1, "Adrian", 500.0);
            Account acc2 = new SavingsAccount(2, "Beatrice", 500.0, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
