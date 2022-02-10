using Exercicio_Pessoa_Fisica_e_Juridica.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Pessoa_Fisica_e_Juridica
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the Number of Tax Payers: ");
            int taxPayers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= taxPayers; i++)
            {
                Console.WriteLine($"#{i} tax payer data: ");
                Console.Write("Individual or Company (i/c)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double ai = double.Parse(Console.ReadLine());

                if (option == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double exp = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, ai, exp));
                }

                if (option == 'c')
                {
                    Console.Write("Number of Employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, ai, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer txp in list)
            {
                Console.WriteLine(txp.Name + ": $" + txp.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("TOTAL TAXES: ");
            Console.WriteLine();






        }
    }
}
