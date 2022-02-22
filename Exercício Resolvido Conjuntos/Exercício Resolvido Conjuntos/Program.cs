using System;
using System.Collections.Generic;
using System.IO;

namespace Exercício_Resolvido_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.WriteLine("Insert the path for the file: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });
                        Console.WriteLine(name + instant);
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }
        }
    }
}
