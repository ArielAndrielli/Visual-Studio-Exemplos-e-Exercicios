using System;

namespace Exemplo_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService_T<string> ps = new PrintService_T<string>();
            //PrintServiceString ps = new PrintServiceString();

            Console.WriteLine("How many values?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //int x = int.Parse(Console.ReadLine());
                string x = Console.ReadLine();
                ps.addValue(x);
            }

            //Utilizando o 'object' a gente resolve o problema de ter que criar toda uma nova classe só pra um tipo de dado(string, int etc)
            //Porém, fazendo desse modo não há type safety e até tem um probleminha de performance
            ps.print();
            Console.WriteLine("First: " + ps.First());
        }
    }
}
