using System;
using System.Globalization;

namespace Dolar_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar?: ");
            double ttdolares = double.Parse(Console.ReadLine());

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
