namespace Exemplo_Interfaces.Services
{
    class BrazilTaxService : ITaxService  //NÃO É HERANÇA!!! É UMA REALIZAÇÃO DE INTERFACE
                                          //Se for sem interface, remover ': ITaxService' da frente do nome da classe
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
