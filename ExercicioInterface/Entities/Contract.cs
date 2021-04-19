using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioInterface.Entities
{
    class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int contractNumber, DateTime contractDate, double totalValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            TotalValue = totalValue;
            Installments = new List<Installment>(); ;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
