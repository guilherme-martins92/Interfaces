using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioInterface.Entities
{
    class Installment
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }

        public override string ToString()
        {
            return "Vencimento: "
                + Date.ToString("dd/MM/yyyy")
                + " - Valor parcela R$ "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
