namespace Exercicio_Resolvido_Polimorfismo
{
    class OutsourcedEmployee : Employee
    {
        public double additionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string employee, int hours, double vph, double additionalCharge) : base(employee, hours, vph)
        {
            this.additionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * additionalCharge;
        }
    }
}
