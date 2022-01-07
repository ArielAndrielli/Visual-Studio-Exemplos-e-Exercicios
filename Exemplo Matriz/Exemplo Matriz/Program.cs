using System;

namespace Exemplo_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[,] mat = new double[2, 3];

            //Length - Elementos da raiz no total
            //Console.WriteLine(mat.Length);

            //Rank - Fala quanto é a 1ª dimensão da matriz (nº de linhas)
            //Console.WriteLine(mat.Rank);

            //GetLength - Fala que a dimensão 0 tem tamanho 2 (duas linhas)
            //Console.WriteLine(mat.GetLength(0));

            Console.WriteLine("Digite o índice da matriz: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora informe os termos da matriz, linha por linha: ");
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main Diagonal");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative Numbers: " + count);
        }
    }
}
