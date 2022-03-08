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
            string path = Console.ReadLine();

            Console.WriteLine("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());

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

            var avg = from p in list
                      where p.Salary > 1500
                      orderby p.Email
                      select p;


            var sumLetterM = from p in list
                             where p.Name.Contains("M")
                             select p;

            Console.WriteLine("Email of people whose salary is greater than 2000.00");

        }
    }
}
