using Exemplo_Delegate.Service;
using System;

namespace Exemplo_Delegate
{

    //delegate double BinaryNumericOperation(double n1, double n2);  <- Delegate Normal
    delegate void BinaryNumericOperation(double n1, double n2); // <- Multicast Delegate

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            // double result = op.Invoke(a, b);  Ao invés de fazer da forma grande (CalculationService.Sum(a)) eu posso DELEGAR a função para a instância 'op' do delegate 
            op.Invoke(a, b);

            //Console.WriteLine(result);

        }
    }
}