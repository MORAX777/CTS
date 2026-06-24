using System;


namespace AdapterPatternExample
{
    
    interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }

    

    class PayPalGateway
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine("PayPal: Processing payment of $" + amount);
        }
    }

    class StripeGateway
    {
        public void ChargeCard(double amount)
        {
            Console.WriteLine("Stripe: Charging card for $" + amount);
        }
    }

    class RazorpayGateway
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Razorpay: Initiating payment of $" + amount);
        }
    }

   

    class PayPalAdapter : IPaymentProcessor
    {
        private PayPalGateway paypal = new PayPalGateway();

        public void ProcessPayment(double amount)
        {
            
            paypal.MakePayment(amount);
        }
    }

    class StripeAdapter : IPaymentProcessor
    {
        private StripeGateway stripe = new StripeGateway();

        public void ProcessPayment(double amount)
        {
            stripe.ChargeCard(amount);
        }
    }

    class RazorpayAdapter : IPaymentProcessor
    {
        private RazorpayGateway razorpay = new RazorpayGateway();

        public void ProcessPayment(double amount)
        {
            razorpay.Pay(amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter Pattern - Payment Processing\n");

            
            IPaymentProcessor processor;

            Console.WriteLine(" Paying via PayPal ");
            processor = new PayPalAdapter();
            processor.ProcessPayment(250.00);

            Console.WriteLine("\n Paying via Stripe ");
            processor = new StripeAdapter();
            processor.ProcessPayment(180.50);

            Console.WriteLine("\n Paying via Razorpay ");
            processor = new RazorpayAdapter();
            processor.ProcessPayment(99.99);
        }
    }
}
