using System;
using Exemplo_LINQ_com_Lambda.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exemplo_LINQ_com_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Main Solution

            static void Print<T>(string message, IEnumerable<T> collection)
            {
                Console.WriteLine(message);
                foreach (T obj in collection)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }

                Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
                Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
                Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

                List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
                };

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

            //Sintaxe Alternativa (similar à sintaxe do SQL): 
            var r1 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900.0
                     select p;
                Print("1) - TIER 1 AND PRICE < 900:", r1);

            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);

            // Sintaxe Alternativa (similar à sintaxe do SQL)
            var r2 = from p in products
                     where p.Category.Name == "Tools"
                     select p.Name;
                Print("2) - NAMES OF PRODUCTS FROM TOOLS", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });

            //Sintaxe Alternativa:

            var r3 = from p in products
                     where p.Name.Contains("C")
                     select new
                     {
                         p.Name,
                         p.Price,
                         CategoryName = p.Category.Name
                     };

                Print("3) - NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);

            //Sintaxe Alternativa

            var r4 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;
                Print("4) - TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //var r5 = r4.Skip(2).Take(4);

            //Sintaxe Alternativa

            var r5 =
            (from p in r4
             select p).Skip(2).Take(4);

                Print("5) - TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

                var r6 = products.FirstOrDefault();
                Console.WriteLine("6) - First or default test1: " + r6);
                var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
                Console.WriteLine("7) - First or default test2: " + r7);
                Console.WriteLine();

                var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
                Console.WriteLine("8) - Single or default test1: " + r8);
                var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
                Console.WriteLine("9) - Single or default test2: " + r9);
                Console.WriteLine();

                var r10 = products.Max(p => p.Price);
                Console.WriteLine("10) - Max price: " + r10);
                var r11 = products.Min(p => p.Price);
                Console.WriteLine("11) - Min price: " + r11);
                var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
                Console.WriteLine("12) - Category 1 Sum prices: " + r12);
                var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
                Console.WriteLine("13) - Category 1 Average prices: " + r13);
                var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("14) - Category 5 Average prices: " + r14);
                var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
                Console.WriteLine("15) - Category 1 aggregate sum: " + r15);
                Console.WriteLine();

                var r16 = products.GroupBy(p => p.Category);
                foreach (IGrouping<Category, Product> group in r16)
                {
                    Console.WriteLine("Category " + group.Key.Name + ":");
                    foreach (Product p in group)
                    {
                        Console.WriteLine(p);
                    }
                    Console.WriteLine();
                }
            
                    #endregion

                    #region Alternative Solution
                    /*

                    Category c1 = new Category() { Id = 1, Name = "Screwdriver", Tier = 2 };
                    Category c2 = new Category() { Id = 2, Name = "Hammer", Tier = 3 };
                    Category c3 = new Category() { Id = 3, Name = "Saw", Tier = 1 };

                    List<Product> list = new List<Product>();

                    Console.WriteLine("How many products do you wish to register? ");
                    int qtt = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Type in the product(s) data: ");

                    try
                    {
                        for (int i = 1; i <= qtt; i++)
                        {
                            Console.WriteLine($"Product {i}#: ");
                            Console.Write("ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Category category = c1;

                            Console.WriteLine();
                            list.Add(new Product(id, name, price, category));
                        }
                    }
                    catch(IOException e)
                    {
                        Console.WriteLine("An unexpected error has occurred: " + e.Message);
                    }

                    Console.WriteLine("Produtos Adicionados: ");
                    foreach(Product p in list)
                    {
                        Console.WriteLine(p);
                    }

                    */
                    #endregion

        }
    }
}
