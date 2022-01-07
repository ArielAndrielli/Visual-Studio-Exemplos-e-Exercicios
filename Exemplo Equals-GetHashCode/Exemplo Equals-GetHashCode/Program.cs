using System;

namespace Exemplo_Equals_GetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Outro Exemplo

            //string a = "Maria";
            //string b = "Gerson";

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            #endregion

            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
