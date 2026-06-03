using System;

namespace StrategyPatternApp.Strategies
{
    public class BankTransferPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} using Bank Transfer.");
        }
    }
}
