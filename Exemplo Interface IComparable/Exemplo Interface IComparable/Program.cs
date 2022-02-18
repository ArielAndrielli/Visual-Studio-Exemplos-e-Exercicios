using System;
using System.Collections.Generic;

namespace Exemplo_Interface_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            Console.WriteLine("Name List");
            Console.WriteLine("");
            Console.Write("How many names do you wish to record? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Type the names below: ");
            Console.WriteLine("");

            for (int i = 1; i <= n; i++)
            {
                Console.Write("-> ");
                string names = Console.ReadLine();
                list.Add(names);
            }
            Console.WriteLine("");

            Console.WriteLine("__________List of Names:__________");

            foreach(string item in list)
            {
                Console.WriteLine("|     " + item);
            }

            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
        }
    }
}
