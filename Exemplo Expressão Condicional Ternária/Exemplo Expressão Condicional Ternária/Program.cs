using System;
using System.Globalization;

namespace Exemplo_Expressão_Condicional_Ternária
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sem Estrutura Ternária
            /*
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }


            Console.WriteLine(desconto);
            */
            #endregion 

            #region Com Estrutura Ternária

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

            #endregion
        }
    }
}
