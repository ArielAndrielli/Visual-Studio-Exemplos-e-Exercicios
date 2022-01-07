using Exercício_Resolvido_Enum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Resolvido_Enum.Entities
{
    class Worker
    {
        public string name { get; set; }

        public WorkerLevel LevelWorker { get; set; }

        public double BaseSalary { get; set; }

        public Department department { get; set; }

        public List<HourContract> contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }
        public Worker(string name, WorkerLevel levelWorker, double baseSalary, Department department)
        {
            this.name = name;
            LevelWorker = levelWorker;
            BaseSalary = baseSalary;
            this.department = department;
        }

        public void AddContract(HourContract contract)
        {
            contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in contracts)
            {
                if (contract.date.Year == year && contract.date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }   
    }
}
