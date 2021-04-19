using System;
using System.Collections.Generic;
using System.Text;
using ExercicioInterface.Entities;
using System.Globalization;

namespace ExercicioInterface.Services
{
    class ContractService
    {
        public IOnlinePaymentServices _paymentService { get; set; }

        public ContractService(IOnlinePaymentServices paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contrato, int meses)
        {
            double valorParcela = contrato.TotalValue / meses;

            for (int i = 1; i <= meses; i++)
            {
                DateTime date = contrato.ContractDate.AddMonths(i);

                double valorParcelaAtualizado = valorParcela + _paymentService.Interest(valorParcela, i);
                double valorTotal = valorParcelaAtualizado + _paymentService.PaymentFee(valorParcelaAtualizado);
                contrato.AddInstallment(new Installment(date, valorTotal));
            }
        }
    }

}
