using System;
using System.Collections.Generic;
using System.IO;

namespace Exemplo_Directory__DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\aars\Documents\Curso C#\Testes";

            try
            {
                //Essa operação vai pegar todas as subpastas a partir de uma pasta original
                //Você pode trocar o IEnumerable<string> por var se você quiser. Aí pode apagar o System.Collections.Generic também
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach(string s in files)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("CREATING FOLDER");
                Directory.CreateDirectory(path + @"/CreatedFolder");


            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }
        }
    }
}
