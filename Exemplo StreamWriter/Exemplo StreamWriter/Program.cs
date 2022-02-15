using System;
using System.IO;

namespace Exemplo_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\aars\Documents\Curso C#\Teste.txt";
            string targetPath = @"C:\Users\aars\Documents\Curso C#\Teste 2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Anerror has occurred: " + e.Message);
            }
        }
    }
}
