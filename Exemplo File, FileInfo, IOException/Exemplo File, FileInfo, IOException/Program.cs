using System;
using System.IO;

namespace Exemplo_File__FileInfo__IOException
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Variables

            string sourcePath = @"C:\Users\aars\Documents\Curso C#\ExemploBanco - Alterações.txt";
            string targetPath = @"C:\Users\aars\Documents\Curso C#\ExemploBanco - Alterações (teste).txt";

            #endregion

            #region Operations

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                Console.WriteLine("File Successfully Copied!");
                Console.WriteLine();
                Console.WriteLine("File Content: ");
                Console.WriteLine();
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.Write("An error occurred: ");
                Console.WriteLine(e.Message);
            }

            #endregion

        }
    }
}
