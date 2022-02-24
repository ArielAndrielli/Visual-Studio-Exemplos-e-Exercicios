using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio_Proposto_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            string targetPath = @"C:\Users\aars\Documents\Curso C#\Candidates.csv";
            Dictionary<string, int> dict = new Dictionary<string, int>();

            Console.WriteLine("|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_Votação para presidente do mundo_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|");
            Console.WriteLine("|_|                                                                                                          |_|");
            Console.WriteLine("|_| Insira o caminho do arquivo com as informações:                                                          |_|");
            Console.WriteLine($"|_| {path = Console.ReadLine()}                                                                                   |_|");
            Console.WriteLine("|_|                                                                                                          |_|");
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int quantity = int.Parse(line[1]);

                        if (dict.ContainsKey(name))
                        {
                            dict[name] += quantity;
                        }
                        else
                        {
                            dict[name] = quantity;
                        }

                        using (StreamWriter sw = File.AppendText(targetPath))
                        {
                            foreach (string linee in line)
                            {
                                sw.WriteLine(linee.ToUpper());
                            }
                        }
                    }

                    Console.WriteLine("Total Votes: ");
                    foreach (KeyValuePair<string, int> item in dict)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
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
