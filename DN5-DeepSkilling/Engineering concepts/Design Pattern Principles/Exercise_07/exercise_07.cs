using System;
using System.Collections.Generic;


namespace ObserverPatternExample
{
   
    interface IObserver
    {
        void Update(string stockName, double newPrice);
    }

    
    interface IStock
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    
    class StockMarket : IStock
    {
        private List<IObserver> observers = new List<IObserver>();
        private string stockName;
        private double price;

        public StockMarket(string stockName, double initialPrice)
        {
            this.stockName = stockName;
            this.price     = initialPrice;
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine(observer.GetType().Name + " subscribed to " + stockName);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
            Console.WriteLine(observer.GetType().Name + " unsubscribed from " + stockName);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(stockName, price);
            }
        }

       
        public void SetPrice(double newPrice)
        {
            Console.WriteLine("\n" + stockName + " price changed to $" + newPrice);
            price = newPrice;
            NotifyObservers();
        }
    }

    

    class MobileApp : IObserver
    {
        private string userName;

        public MobileApp(string userName)
        {
            this.userName = userName;
        }

        public void Update(string stockName, double newPrice)
        {
            Console.WriteLine("  MobileApp (" + userName + "): " + stockName + " is now $" + newPrice);
        }
    }

    class WebApp : IObserver
    {
        public void Update(string stockName, double newPrice)
        {
            Console.WriteLine("  WebApp: Dashboard updated - " + stockName + " = $" + newPrice);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer Pattern - Stock Market Monitor\n");

            StockMarket apple = new StockMarket("AAPL", 150.00);

            
            MobileApp user1 = new MobileApp("Alice");
            MobileApp user2 = new MobileApp("Bob");
            WebApp     web   = new WebApp();

            apple.RegisterObserver(user1);
            apple.RegisterObserver(user2);
            apple.RegisterObserver(web);

            
            apple.SetPrice(155.50);
            apple.SetPrice(148.75);

            
            Console.WriteLine();
            apple.RemoveObserver(user2);
            apple.SetPrice(160.00);
        }
    }
}
