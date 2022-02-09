using Course.Entities;
using Exercício_Proposto_Herança_e_Polimorfia.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercício_Proposto_Herança_e_Polimorfia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product # " + i + " data: ");
                Console.Write("Common, Used or Imported (c/u/i)? ");
                char option = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                
                if(option == 'c')
                {
                    list.Add(new Product(name, price));
                }

                else if (option == 'u')
                {
                    Console.Write("Manufacture Date: ");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    list.Add(new UsedProduct(name, price, date));
                }

                else
                {
                    Console.WriteLine("Customs Fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, fee));
                }

            }
            Console.WriteLine(" ");
            Console.WriteLine("PRICE TAGS: ");
            
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.priceTag());
            }
        }
    }
}
