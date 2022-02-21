using System;
using System.Collections.Generic;
using System.IO;
using Exemplo_Interface_IComparable_2.Entities;

namespace Exemplo_Interface_IComparable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\aars\Documents\Curso C#\Testes\Funcionarios.txt";

            try
            {

                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();

                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }

        }

    }

}
