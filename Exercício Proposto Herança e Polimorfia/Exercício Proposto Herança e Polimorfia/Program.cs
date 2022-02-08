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
            char n = char.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product # " + i + " data: ");
                Console.Write("Common, Used or Imported (c/u/i)?");
                char option = char.Parse(Console.ReadLine());
                if (option == 'i')
                {
                    Console.Write("Name: ");
                    string nameImport = Console.ReadLine();
                    Console.Write("Price: ");
                    double priceImport = double.Parse(Console.ReadLine());
                    Console.WriteLine("Customs Fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(nameImport, priceImport, fee));
                }
                else if (option == 'u')
                {
                    Console.Write("Name: ");
                    string nameProd = Console.ReadLine();
                    Console.Write("Price: ");
                    double priceProd = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture Date: ");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    list.Add(new UsedProduct(nameProd, priceProd, date));
                }
                else if (option == 'c')
                {
                    Console.Write("Name: ");
                    string nameCommon = Console.ReadLine();
                    Console.Write("Price: ");
                    double priceCommon = double.Parse(Console.ReadLine());
                    list.Add(new Product(nameCommon, priceCommon));
                }
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.Name + "- $ " + prod.Price );
            }
            foreach (ImportedProduct imp in list)
            {
                Console.WriteLine(imp.Name + "- $ " + imp.Price, imp.TotalPrice());
            }
            foreach(UsedProduct use in list)
            {
                Console.WriteLine(use.Name + "- $ " + use.Price, use.ManufactureDate);
            }

        }
    }
}
