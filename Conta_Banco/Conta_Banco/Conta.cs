using System;
using System.Collections.Generic;
using System.Text;

namespace Conta_Banco
{
    class Conta
    {
        public int Num;
        public string Nome { get; set; }
        public string valor;
        public bool TemDeposito;
        public double Deposito;
        public double Saldo;
        public double Saque;

        public void AdicionarSaldo()
        {
            Saldo = Saldo + Deposito;
        }

        public void RemoverSaldo()
        {
            Saldo = Saldo - Saque;
        }

        /* Solução do Curso:
         
        public int Num { get; private set; }
        public string Nome { get; set; }
        public Saldo { get; private set; }
         
        public Conta (int numero, string nome)
        {
            Num = numero;
            Nome = nome;
            Saldo = 0.0;
        }

        public Conta (int numero, string nome, double depoditoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito()
        {
            Saldo += quantia; //<-- "criar variável quantia quando for testar esse código"
        }

        public void Saque()
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta"
            + Num
            + ", Nome do titular: "
            + Nome
            + ", Saldo: "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        } 
         
         */

    }
}
