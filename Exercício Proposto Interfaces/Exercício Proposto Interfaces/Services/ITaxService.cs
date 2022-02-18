namespace Exercício_Proposto_Interfaces.Services
{
    interface ITaxService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
