using System;

namespace Exemplo_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Type a number: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Type another number: ");
                int n2 = int.Parse(Console.ReadLine());

                int sum = n1 / n2;


                Console.Write("Sum result: " + sum);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error! Division by zero is not allowed!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
        }
    }
}
