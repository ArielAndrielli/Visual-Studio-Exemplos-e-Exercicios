using System;
using System.IO;

namespace Exemplo_FileStream_e_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\aars\Documents\Curso C#\Teste.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

            #region Forma resumida

            /*   

            string path = @"c:\temp\file1.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }

            */

            //As streams instanciadas (fs e sr) são recursos externos, ou seja, você está falando ao S.O que você está abrindo um arquivo.
            //Este recurso não é gerenciado pelo CLR do .NET. Como ele não é gerenciado pelo CLR, eu vou ter que fechar esse recurso MANUALMENTE
            //O fechamento desses recursos está no FINALLY acima.

            #endregion
        }
    }
}
