namespace Exercicio_Pessoa_Fisica_e_Juridica.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        double result;

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000)
            {
                result = AnualIncome = AnualIncome * (15 / 100);
            }
            else if (AnualIncome >= 20000)
            {
                result = AnualIncome = AnualIncome * (25 / 100);
            }

            return result;
        }
    }
}
