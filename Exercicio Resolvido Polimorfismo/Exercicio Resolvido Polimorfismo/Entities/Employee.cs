namespace Exercicio_Resolvido_Polimorfismo.Entities
{
    class Employee
    {
        public string Emp { get; set; }

        public int Hours { get; set; }

        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string employee, int hours, double vph)
        {
            Emp = employee;
            Hours = hours;
            ValuePerHour = vph;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

    }
}
