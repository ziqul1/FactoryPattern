using FactoryPattern.Enums;
using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PaymentProcessor
    {
        IPaymentGateway paymentGateway = null;
        
        public void MakePayment(EPaymentMethod method, Product product)
        {
            PaymentGatewayFactory2 factory = new PaymentGatewayFactory2();
            this.paymentGateway = factory.CreatePaymentGateway(method, product);
            this.paymentGateway.MakePayment(product);
        }
    }
}
