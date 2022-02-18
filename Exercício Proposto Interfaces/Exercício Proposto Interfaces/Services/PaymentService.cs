using System;
using Exercício_Proposto_Interfaces.Entities;

namespace Exercício_Proposto_Interfaces.Services
{
    class PaymentService
    {
        private ITaxService _onlinePaymentService;

        public PaymentService(ITaxService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}