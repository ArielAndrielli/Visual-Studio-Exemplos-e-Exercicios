namespace Exercicio_Resolvido_Polimorfismo
{
    class Employee
    {
        public string Emp { get; set; }

        public int Hours { get; set; }

        public int ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string employee, int hours, int vph)
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
