namespace Exercicio_Proposto_Dictionary.Entities
{
    class Candidate
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Candidate()
        {
        }

        public Candidate(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}
