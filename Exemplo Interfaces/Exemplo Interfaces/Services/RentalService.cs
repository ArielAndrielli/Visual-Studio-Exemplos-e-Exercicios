using System;
using Exemplo_Interfaces.Entities;

namespace Exemplo_Interfaces.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }

        public double PricePerDay { get; private set; }

        private ITaxService _taxService;

        // INVERSÃO DE CONTROLE POR MEIO DE INJEÇÃO DE DEPENDÊNCIA: A classe RentalService não mais vai instanciar a sua dependência.
        // Agora ela vai receber o objeto instanciado e simplesmente vai atribuir
        //private BrazilTaxService brazilTaxService = new BrazilTaxService();  <--- Quando não tem interface você usa essa linha de
        //código no lugar da de baixo e tira o ITaxService do construtor

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(Rental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment;

            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
