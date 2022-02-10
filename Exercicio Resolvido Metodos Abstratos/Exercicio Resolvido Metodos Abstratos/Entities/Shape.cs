using Exercicio_Resolvido_Metodos_Abstratos.Enums;

namespace Exercicio_Resolvido_Metodos_Abstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
