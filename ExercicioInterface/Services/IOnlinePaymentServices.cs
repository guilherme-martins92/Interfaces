using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterface.Services
{
    interface IOnlinePaymentServices
    {
        double Interest(double amount, int months);
        double PaymentFee(double amount);
    }
}
