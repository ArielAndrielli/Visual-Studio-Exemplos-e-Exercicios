using Exercício_Proposto_Conta_Bancaria.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Proposto_Conta_Bancaria.Entities
{
    class Account
    {

        public int Number { get; set; }

        public string Holder { get; set; }

        public double Balance { get; set; }

        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("An error has occurred while trying to withdraw: you don't have enough funds!");
            }
            if (WithdrawLimit < amount)
            {
                throw new DomainException("An error has occurred while trying to withdraw: the value exceeds the withdraw limit!");
            }

            Balance -= amount;
        }

    }
}
