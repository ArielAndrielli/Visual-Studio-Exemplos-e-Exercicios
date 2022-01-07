using System;

namespace Exemplo_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = null; <--- N irá funcionar pois double é 'Non-nullable'
            //Nullable<double> x = null;

            //Forma mais simples de se escrever
            double? x = null;

            //O nullable possui 3 operações básicas: 
            //GetValueOrDefault | HasValue | Value (lança uma exceção se n houver valor)
            //Um Nullable n pode ser atibuído para um STRUCT comum

            double? a = null;
            double? b = 5;

            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(b.GetValueOrDefault());

            Console.WriteLine(a.HasValue);
            Console.WriteLine(b.HasValue);

            if (a.HasValue)
                Console.WriteLine(a.Value);
            else
                Console.WriteLine("a is null!");

            if (b.HasValue)
                Console.WriteLine(b.Value);
            else
                Console.WriteLine("b is null!");

            //Operador de coalescência nula

            double? c = null;
            double? d = 10;

            double h = c ?? 25;
            double j = d ?? 7;

            Console.WriteLine(h);
            Console.WriteLine(j);
        }
    }
}
