using Exercício_Resolvido_Enum.Entities;
using Exercício_Resolvido_Enum.Entities.Enums;
using System;
using System.Globalization;

namespace Exercício_Resolvido_Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Department's Name: ");
            string dptName = Console.ReadLine();
            Console.WriteLine("Enter worker's data: ");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine());

            Department dpt = new Department(dptName);
            Worker worker = new Worker(workerName, level, baseSalary, dpt);

            for(int i = 1; i <= contracts; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data: ");
                Console.Write("Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int Hours = int.Parse(Console.ReadLine());
                HourContract hourCon = new HourContract(date, valuePerHour, Hours);
                worker.AddContract(hourCon);
            }
            Console.WriteLine();
            Console.Write("Enter a month and year to calculate the income (MM/yyyy): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine();
            Console.WriteLine("Name: " + worker.name);
            Console.WriteLine("Department: " + worker.department.name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));

        }
    }
}
