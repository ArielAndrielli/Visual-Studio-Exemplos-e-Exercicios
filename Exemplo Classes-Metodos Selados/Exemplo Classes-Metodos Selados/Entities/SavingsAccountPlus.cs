namespace Exemplo_Classes_Metodos_Selados.Entities
{
    class SavingsAccountPlus : /*Savings*/Account
    {
        //Classe exemplo pra mostrar que classes SEALED não podem ser Herdadas

        public double Bonus { get; set; }

        public SavingsAccountPlus()
        {
        }

        public SavingsAccountPlus(int number, string holder, double balance, double bonus) : base(number, holder, balance)
        {
            Bonus = bonus;
        }
    }
}
