using Exemplo_Heranca.Entities;
using System.Collections.Generic;
using System.Globalization;
using System;

namespace Exemplo_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1

            /*
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 250.00, 200.00);

            Console.WriteLine(account.Balance);

            // account.Balance = 10; <-- isso não é permitido pois a propriedade Balance é protected

            */
            #endregion

            #region 2

            /*
            Account acc = new Account(10, "Danny Boeh", 0.0);  // <- Está com erro pois foi mudada a classe Account para Abstract Account
            BusinessAccount bacc = new BusinessAccount(7, "Adanit", 150.0, 25.0);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(27, "MEEEEEDIIIIIIIC", 0.0, 200.0);
            Account acc3 = new SavingsAccount(28, "Demopan", 0.0, 100.0);

            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            //BusinessAccount acc5 = (BusinessAccount)acc3; <--- No código o erro não é sublinhado mas na compilação dá erro

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3; <--- Outra forma de fazer o casting
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3; <--- Outra forma de fazer o casting
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            */

            #endregion

            #region 3


            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alexandre", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Thiago", 500.0, 400));
            list.Add(new SavingsAccount(1003, "Icaro", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Gabriel", 500.0, 500));

            double sum = 0.0;
            
            foreach (Account ac in list)
            {
                sum += ac.Balance;
            }

            foreach(Account ac in list)
            {
                ac.Withdraw(10.0);
            }
            foreach(Account ac in list)
            {
                Console.WriteLine("Update balance for account:"
                    + ac.Number
                    + ": "
                    + ac.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }



            #endregion
        }
    }
}
