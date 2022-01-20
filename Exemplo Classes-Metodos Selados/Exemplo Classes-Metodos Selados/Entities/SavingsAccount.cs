using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Classes_Metodos_Selados.Entities
{
    /*sealed*/ class SavingsAccount : Account
    {

        //Classe Selada: Remover comentário a cima para funcionar

        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            //Método Selado: Esse método não poderá ser sobrescrito novamente. Remover comentário a cima para funcionar
            //Balance -= amount;

            base.Withdraw(amount); //<--- Saque realizado conforme regra da SuperClasse
            Balance -= 2.0;
        }


    }
}
