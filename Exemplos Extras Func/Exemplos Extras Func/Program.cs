using System;
using System.Collections.Generic;
using System.Linq;

namespace Exemplos_Extras_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda function Examples:");
            Console.WriteLine();
            Console.WriteLine("Expressão Lambda de linha única:");
            Console.WriteLine();

            #region Expressão Lambda de linha única

            // Função lambda pra mostrar o quadrado de um número
            //Func<int, int> quadrado = num => num * num;

            // A expressão acima equivale ao seguinte método:  public int quadrado(int num)
            //                                                 {
            //                                                      return num * num;
            //                                                 }

            // Você pode chamar a função lambda como se fosse chamar um método

            //Console.WriteLine(quadrado(4));

            // Digamos que você tenha uma lista de números e precise enquadrar cada valor e
            // retornar uma nova coleção com esses valores. Eu posso usar o Linq e passar na
            // expressão lambda “quadrado” que criei acima para fazer isso. O código ficaria assim:

            //IEnumerable<int> numeros = new List<int> { 2, 3, 4, 5 };

            //var quadradoNumeros = numeros.Select(quadrado);

            //Console.WriteLine(String.Join("", quadradoNumeros));

            // Forma Embutida: 
            // var quadradoNumeros = numeros.Select(num => num * num);

            #endregion

            Console.WriteLine("Expressão Lambda de várias linhas:");
            Console.WriteLine();

            #region Expressão Lambda de várias linhas

            IEnumerable<int> numeros = new List<int> { 2, 3, 4, 5 };

            Func<int, int> quadradoMulti = num =>
            {
                Console.WriteLine("Antes do valor: " + num);
                int sq = num * num;
                Console.WriteLine("Depois do valor: " + num);
                return sq;
            };

            var quadradoNumeros = numeros.Select(quadradoMulti);


            // Forma Embutida: 

            //var quadradoNumeros = numeros.Select(num =>
            //{
            //    Console.WriteLine("Antes do valor: " + num);
            //    int sq = num * num;
            //    Console.WriteLine("Depois do valor: " + num);
            //    return sq;
            //}

            #endregion

            Console.WriteLine("Expressão Lambda com Vários Parâmetros:");
            Console.WriteLine();

            #region Expressão Lambda com Vários Parâmetros

            Func<int, int, int, int> addThreeNumbers = (n1, n2, n3) => n1 + n2 + n3;

            Console.WriteLine(addThreeNumbers(1, 2, 3));

            // Forma Embutida: 


            #endregion


        }
    }
}
