using System;
using System.Globalization;

namespace Circunferencia
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //chamada das operações diretamente pelo nome da classe
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de P.I: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        
    }
}
