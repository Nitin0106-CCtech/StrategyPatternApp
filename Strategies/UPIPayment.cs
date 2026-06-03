using System;

namespace StrategyPatternApp.Strategies
{
    public class UPIPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} using UPI.");
        }
    }
}
