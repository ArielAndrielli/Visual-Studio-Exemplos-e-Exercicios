using System;
using System.Globalization;

namespace Produto_em_Estoque
{
    class Program
    {
        static void Main(string[] args)

        {
            Produto p = new Produto("TV", 500.0, 10);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Qtd);

            //Sem encapsulamento, o programador pode colocar, por exemplo, p.Qtd = -10;

            #region Primeira Versão
            /*Console.WriteLine("Insira os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            //Construtor padrão: quando a classe n tem construtores o construtor padrão tmb pode ser usado 
            Produto p2 = new Produto();

            Produto p3 = new Produto { Nome = "TV", Preco = 500.0, Qtd = 20 };

            Console.WriteLine();

            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qtdprod = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtdprod);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qtdprod = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtdprod);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);*/
            #endregion
        }
    }
}
