using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_Resolvido_Polimorfismo.Entities;

namespace Exercicio_Resolvido_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int employees = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= employees; i++)
            {
                Console.WriteLine("Employee #"+ i + " data");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Emp + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
