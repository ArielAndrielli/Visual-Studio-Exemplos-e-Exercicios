using System;

namespace Exercício_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the number of rows and columns, respectively: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Inform the matrix's terms, row by row: ");
            int[,] mat = new int[m, n];

            for (int i = 0; i < n && i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n && j < m; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Insert a number currently present at the matrix above to know it's location and the other numbers around it: ");
            int nPos = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == nPos)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
