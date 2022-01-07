using System;
using System.Globalization;

namespace Produto_em_Estoque
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Qtd { get; private set; }

        //O nome tem uma lógica particular (if), então ele fica da mesma forma
        public string Nome
        {
            get { return _nome; }
            set {
                    if (value != null && value.Length > 1)  
                    {
                        _nome = value;
                    }
                }
        }

        /* Propertie normal
         * public double Preco 
        {
            get { return _preco; }
        } */


        public Produto(string nome, double preco)
        {
           _nome = nome;
            Preco = preco;
        }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int qtd)
        {
            _nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Qtd;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Qtd += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Qtd -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + 
            Qtd + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
