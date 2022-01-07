using System;
using System.Globalization;

namespace Exemplo_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo 1

            /*

            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for(int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Average Height: " + avg.ToString("F2",CultureInfo.InvariantCulture));

            */

            #endregion

            #region Exemplo 2
            /*
            int num = int.Parse(Console.ReadLine());
            Product[] vector = new Product[num];

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Inform the name and the price: ");
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vector[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for(int i = 0; i < num; i++)
            {
                sum += vector[i].Price;
            }

            double avg = sum / num;

            Console.WriteLine("Average Price: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Exercício Proposto - Refazendo de novo

            int rooms = int.Parse(Console.ReadLine());
            Product[] vect = new Product[rooms];

            for (int i = 0; i < rooms; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Product(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }

            }

            #endregion
        }
    }
}
