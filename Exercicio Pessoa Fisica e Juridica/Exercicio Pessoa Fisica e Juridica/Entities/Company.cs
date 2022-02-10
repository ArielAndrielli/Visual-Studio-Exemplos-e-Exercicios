namespace Exercicio_Pessoa_Fisica_e_Juridica.Entities
{
    class Company : TaxPayer
    {
        public int Employees { get; set; }

        double result;

        public Company()
        {
        }

        public Company(string name, double anualIncome, int employees) :base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {

            if (Employees < 10)
            {
                result = AnualIncome = AnualIncome * (16 / 100);
            }
            else if (AnualIncome >= 10)
            {
                result = AnualIncome = AnualIncome * (14 / 100);
            }

            return result;
        }
    }
}
