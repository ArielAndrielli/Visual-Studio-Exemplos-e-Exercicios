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

            try { 

            Console.Write("Insert the full file path here: ");
            string path = Console.ReadLine();

            Console.WriteLine("Enter salary limit: ");
            double limit = double.Parse(Console.ReadLine());

            List<Employees> list = new List<Employees>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employees(name, email, salary));
                }
            }

            var emails = list.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);

            var sumLetterG = list.Where(obj => obj.Name[0] == 'G').Sum(obj => obj.Salary);

            Console.WriteLine("Email of people whose salary is greater than R$" + limit);
            Console.WriteLine();

            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine();

            Console.WriteLine("Sum of salary of people whose name starts with 'G': R$" + sumLetterG.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }

        }
    }
}
