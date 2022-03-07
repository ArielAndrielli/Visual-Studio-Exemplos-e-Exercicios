using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Proposto_LINQ_e_Lambda.Entities
{
    class Employees
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employees()
        {
        }

        public Employees(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
