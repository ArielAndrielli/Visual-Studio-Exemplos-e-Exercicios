using System;

namespace Exercicio_Resolvido_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int shapes = 0;

            for (int i = 1; i <= shapes; i++)
            {
                Console.WriteLine(shapes + "shape data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red) ");
                Console.WriteLine("Width: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Height: ");
                double height = double.Parse(Console.ReadLine());
                if (option == 'c')
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                }

            }



        }
    }
}
