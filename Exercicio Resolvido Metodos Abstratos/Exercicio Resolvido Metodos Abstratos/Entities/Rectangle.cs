using Exercicio_Resolvido_Metodos_Abstratos.Enums;

namespace Exercicio_Resolvido_Metodos_Abstratos.Entities

{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return (2 * Width) + (2 * Height);
        }
    }
}
