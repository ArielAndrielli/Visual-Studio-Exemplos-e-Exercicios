using Exercicio_Resolvido_Metodos_Abstratos.Entities;
using Exercicio_Resolvido_Metodos_Abstratos.Enums;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace Exercicio_Resolvido_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int shapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= shapes; i++)
            {
                Console.WriteLine($"#{i}" + " shape data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red) ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (option == 'r')
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }

            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
