using System;

namespace Conta_Banco
{
    class Program
    {
        static void Main(string[] args)
        {   
            Conta cont = new Conta();        
            Console.WriteLine("Informe o número da conta: ");
            cont.Num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe o nome do titular: ");
            cont.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Haverá depósito inicial?");
            cont.TemDeposito = bool.Parse(Console.ReadLine());
            Console.WriteLine();
            if (cont.TemDeposito == true)
            {
                Console.WriteLine("Informe o valor do depósito: ");
                cont.Deposito = double.Parse(Console.ReadLine());
                cont.AdicionarSaldo();
                Console.WriteLine();
            }
            else
            {
                cont.Saldo = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine("Nº: " + cont.Num + " | Nome do titular: " + cont.Nome + " | Saldo total: " + cont.Saldo);
            Console.WriteLine();

            Console.WriteLine("Entre um valor para depósito: ");
            cont.Deposito = double.Parse(Console.ReadLine());
            cont.AdicionarSaldo();
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine("Nº: " + cont.Num + " | Nome do titular: " + cont.Nome + " | Saldo total: " + cont.Saldo);
            Console.WriteLine();
            Console.WriteLine("Entre um valor para saque: ");
            cont.Saque = double.Parse(Console.ReadLine());
            cont.RemoverSaldo();
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine("Nº: " + cont.Num + " | Nome do titular: " + cont.Nome + " | Saldo total: " + cont.Saldo);
            Console.WriteLine();

            

            /* Solução do Curso
            Conta conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Insira o nome do titular: ");
            string nome = Console.RedLine();
            Console.Write("Haverá depósito inicial?");
            char resp = Char.Parse(Console.ReadLine());
            if(resp == "s" || resp == "S")
            {
                Console.Write("Insira o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, depositoInicial);
            }else{
                conta = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ")
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Insira um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Insira um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
             
             */
        }
    }
}
