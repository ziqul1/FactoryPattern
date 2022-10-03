using FactoryPattern;
using FactoryPattern.Enums;


// Tworzenie instancji klasy w której znajduje się metoda do dokonania płatności
PaymentProcessor pre = new PaymentProcessor();
// Definiujemy produkt - to jest tylko przykład
Product prod = new Product();
prod.Name = "Audi RS6";
prod.Price = 560000;
prod.Description = "Bardzo szybkie rodzinne kombi";
// Dokonujemy płatności pierwszym sposobem.
pre.MakePayment(EPaymentMethod.PAYPAL, prod);
Console.ReadKey();
pre.MakePayment(EPaymentMethod.BANK_ONE, prod);
Console.ReadKey();
