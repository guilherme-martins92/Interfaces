using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterface.Services
{
    class PaypalService : IOnlinePaymentServices
    {
        public double Interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
