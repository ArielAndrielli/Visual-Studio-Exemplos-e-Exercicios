using System;
using System.Collections.Generic;
using Exercício_Proposto_LINQ_e_Lambda.Entities;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Exercício_Proposto_LINQ_e_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the full file path here: ");

            Console.WriteLine("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());
            string path = Console.ReadLine();

            List<Employees> list = new List<Employees>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employees(name, email, salary));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average Price; " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            Console.WriteLine("Email of people whose salary is greater than 2000.00");

        }
    }
}
