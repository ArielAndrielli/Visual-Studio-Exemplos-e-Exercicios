using Exemplo_Heranca.Entities;
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


            Account acc = new Account(10, "Danny Boeh", 0.0);
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


            #endregion
        }
    }
}
