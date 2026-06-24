using System;


namespace StrategyPatternExample
{
    
    interface IPaymentStrategy
    {
        void Pay(double amount);
    }

   

    class CreditCardPayment : IPaymentStrategy
    {
        private string cardNumber;

        public CreditCardPayment(string cardNumber)
        {
            this.cardNumber = cardNumber;
        }

        public void Pay(double amount)
        {
            Console.WriteLine("Paid $" + amount + " using Credit Card ending in " + cardNumber.Substring(cardNumber.Length - 4));
        }
    }

    class PayPalPayment : IPaymentStrategy
    {
        private string email;

        public PayPalPayment(string email)
        {
            this.email = email;
        }

        public void Pay(double amount)
        {
            Console.WriteLine("Paid $" + amount + " using PayPal account: " + email);
        }
    }

    class UPIPayment : IPaymentStrategy
    {
        private string upiId;

        public UPIPayment(string upiId)
        {
            this.upiId = upiId;
        }

        public void Pay(double amount)
        {
            Console.WriteLine("Paid $" + amount + " using UPI ID: " + upiId);
        }
    }

    
    class PaymentContext
    {
        private IPaymentStrategy strategy;

       
        public void SetStrategy(IPaymentStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecutePayment(double amount)
        {
            if (strategy == null)
            {
                Console.WriteLine("No payment method selected.");
                return;
            }
            strategy.Pay(amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern - Payment System\n");

            PaymentContext context = new PaymentContext();

           
            Console.WriteLine(" Checkout with Credit Card ");
            context.SetStrategy(new CreditCardPayment("4111111111111234"));
            context.ExecutePayment(500.00);

            
            Console.WriteLine("\n Checkout with PayPal ");
            context.SetStrategy(new PayPalPayment("alice@example.com"));
            context.ExecutePayment(299.99);

            
            Console.WriteLine("\n Checkout with UPI ");
            context.SetStrategy(new UPIPayment("alice@upi"));
            context.ExecutePayment(150.00);
        }
    }
}
