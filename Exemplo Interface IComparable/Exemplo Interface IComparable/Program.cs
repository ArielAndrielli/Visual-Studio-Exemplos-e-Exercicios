using System;
using System.Collections.Generic;
using System.IO;

namespace Exemplo_Interface_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Lista sem uso de operações de arquivos
            /*
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

            foreach (string item in list)
            {
                Console.WriteLine("|     " + item);
            }

            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            */
            #endregion

            #region Lista com operções de arquivos

            string path = @"C:\Users\aars\Documents\Curso C#\Testes\Lista.txt";

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }

                    list.Sort();
                    foreach(string str in list)
                    {
                        Console.WriteLine(str);
                    }


                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }

            #endregion
        }
    }
}
