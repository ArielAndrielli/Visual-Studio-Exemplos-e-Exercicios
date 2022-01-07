using System;

namespace Are_Per_Dia_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rtgl a = new Rtgl();


            Console.WriteLine("Informe a altura do retângulo: ");
            a.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a largura do retângulo: ");
            a.largura = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados do retângulo: " + a);

            Console.WriteLine();

            Console.WriteLine("Área do retângulo: " + a.AreaRetangulo());
            Console.WriteLine();
            Console.WriteLine("Perímetro do retângulo: " + a.PerimetroRetangulo());
            Console.WriteLine();
            Console.WriteLine("Diagonal do retângulo: " + a.DiagonalRetangulo());
            Console.WriteLine();
        }
    }
}
