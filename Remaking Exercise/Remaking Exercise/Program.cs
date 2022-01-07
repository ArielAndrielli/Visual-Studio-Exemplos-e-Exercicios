using System;
using System.Globalization;
using System.Linq;

namespace Remaking_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region primeiros-exercícios.pdf
            /*
            ClasseLegal c1 = new ClasseLegal();
            ClasseLegal c2 = new ClasseLegal();
            
            Console.WriteLine("First Employee data: ");
            Console.WriteLine("Name: ");
            c1.Name = Console.ReadLine();
            Console.WriteLine("Salary: ");
            c1.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Second Employee Data: ");
            Console.WriteLine("Name: ");
            c2.Name = Console.ReadLine();
            Console.WriteLine("Salary: ");
            c2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            double media = (c1.Salary + c2.Salary) / 2.0;
            Console.WriteLine("Medium Salary: " + media.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Verificar se número informado é par ou ímpar
            /*
            Console.WriteLine("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            int r = n % 2;

            if (r == 1)
            {
                Console.WriteLine("Número Ímpar!");
            }
            else
            {
                Console.WriteLine("Número Par!");
            }
            */
            #endregion

            #region Ler a idade de 10 pessoas e ver quantas têm 18 anos ou mais

            Console.WriteLine("Input the amount of ages you wish to record down below: ");
            int ages = int.Parse(Console.ReadLine());
            Idade[] vet = new Idade[ages];

            for (int i = 0; i < ages; i++)
            {
                Console.WriteLine("Idade " + i);
                int people = int.Parse(Console.ReadLine());
                vet[i] = new Idade { Age = ages };

                if (i >= 18)
                {
                    Console.WriteLine("Indivíduos com mais de dezoito anos: ");
                    vet.ToList().ForEach(i => Console.WriteLine(i.ToString()));
                }
                else
                {
                    return;
                }
            }
            
            


            
            #endregion
        }
    }
}
