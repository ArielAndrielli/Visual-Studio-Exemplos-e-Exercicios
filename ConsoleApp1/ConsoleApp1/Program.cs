using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> studentsA = new HashSet<int>();
            HashSet<int> studentsB = new HashSet<int>();
            HashSet<int> studentsC = new HashSet<int>();

            Console.WriteLine("How many students for course A?");
            int courseA = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i < courseA; i++)
            {
                Console.WriteLine($"Student {i}#");
                int cod = int.Parse(Console.ReadLine());
                studentsA.Add(cod);
            }

            Console.WriteLine("How many students for course B?");
            int courseB = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i < courseB; i++)
            {
                Console.WriteLine($"Student {i}#");
                int cod = int.Parse(Console.ReadLine());
                studentsB.Add(cod);
            }
            Console.WriteLine("How many students for course C?");
            int courseC = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i < courseC; i++)
            {
                Console.WriteLine($"Student {i}#");
                int cod = int.Parse(Console.ReadLine());
                studentsC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(studentsA);

            all.UnionWith(studentsB);
            all.UnionWith(studentsC);
            Console.WriteLine();
            Console.WriteLine($"Total de Alunos: {all.Count}");
          
        }
    }
}
