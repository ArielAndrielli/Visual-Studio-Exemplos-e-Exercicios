using System;

namespace Exemplo_STRUCT
{
    class Program
    {
        static void Main(string[] args)
        {
            // n se pode simplesmente tentar imprimir o valor de p na tela (Console.WriteLine(p)).
            // É preciso, primeiro, inicializar o valor de p
            Point p;

            //Inicializando
            p.X = 10;
            p.Y = 20;

            p = new Point();
            Console.WriteLine(p);
        }
    }
}
