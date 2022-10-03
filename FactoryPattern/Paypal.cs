using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Paypal : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            // Metoda to pozwala na dokonanie płatności za pomocą trzeciego sposobu
            Console.WriteLine("Trzeci rodzaj płatności (PayPal) za {0}, kwota {1}", product.Name, product.Price);
        }
    }
}
