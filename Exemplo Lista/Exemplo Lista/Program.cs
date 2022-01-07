using System;
using System.Collections.Generic;
namespace Exemplo_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma lista vazia
            //List<string> list = new List<string>();

            //Criando uma lista com itens
            //List<string> list2 = new List<string> { "Roberto", "Frederico", "Cácia" };

            //.Add ---> Adiciona elementos
            //.Insert ---> Insere um elemento na posição desejada

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Jorge");
            list.Add("Clarice");
            list.Add("Greg");
            list.Add("Mary");
            list.Add("Clair");
            list.Insert(2, "Monica");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //.Count ---> mostra o tamanho da lista
            Console.WriteLine("List Count: " + list.Count);

            //Encontrar primeira ou última posição de elemento da lista
            //N é necessário o método (static) para fazer isso
            //pode-se fazer atrvés de uma função Lambda(x => x[0] == 'M')

            /* static bool Test(string s)
             {
                 return s[0] == 'A';
             } */

            string s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine("First M: " + s1);

            string s2 = list.FindLast(x => x[0] == 'C');
            Console.WriteLine("Last C: " + s2);

            //Encontrar primeira ou última posição de elemento da lista

            int pos1 = list.FindIndex(x => x[0] == 'C');
            Console.WriteLine("First position C " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("Last position M: " + pos2);

            //Filtro que traz todos os registros de acordo com um predicado
            List<string> filter = list.FindAll(x => x.Length == 5);

            //Remover elementos da lista
            list.Remove("Greg");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //RemovAll: remove com base em um predicado
            list.RemoveAll(x => x[0] == 'C');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //RemoveAt: remove em certa posição
            list.RemoveAt(3);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //RemoveRange: remove de acordo com a posição (posição, nº de itens para deletar)
            list.RemoveRange(3, 2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
