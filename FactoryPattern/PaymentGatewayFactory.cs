using FactoryPattern.Enums;
using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PaymentGatewayFactory
    {
        public virtual IPaymentGateway CreatePaymentGateway(EPaymentMethod method, Product prod)
        {
            IPaymentGateway paymentGateway = null;
            switch(method)
            {
                case EPaymentMethod.BANK_ONE:
                    paymentGateway = new BankOne();
                    break;
                case EPaymentMethod.BANK_TWO:
                    paymentGateway = new BankTwo();
                    break;
                // tutaj nie wiem czy nie zamienić kolejnosci 22 z 23 ale to byłoby chyba bez sensu
                default:
                    break;
            }
            return paymentGateway;
        }
    }
}
