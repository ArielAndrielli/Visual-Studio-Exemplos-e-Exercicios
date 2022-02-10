namespace Exercicio_Pessoa_Fisica_e_Juridica.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }

        public double AnualIncome { get; set; }

        public TaxPayer()
        {
        }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}
