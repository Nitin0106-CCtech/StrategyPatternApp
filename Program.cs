using System;
using StrategyPatternApp.Context;
using StrategyPatternApp.Strategies;

namespace StrategyPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentContext paymentContext =
                new PaymentContext(new CreditCardPayment());

            Console.WriteLine("=== Strategy Pattern Demo ===\n");

            paymentContext.ProcessPayment(1000);

            paymentContext.SetPaymentStrategy(
                new PayPalPayment());

            paymentContext.ProcessPayment(2500);

            paymentContext.SetPaymentStrategy(
                new UPIPayment());

            paymentContext.ProcessPayment(500);

            paymentContext.SetPaymentStrategy(
                new BankTransferPayment());

            paymentContext.ProcessPayment(7000);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
