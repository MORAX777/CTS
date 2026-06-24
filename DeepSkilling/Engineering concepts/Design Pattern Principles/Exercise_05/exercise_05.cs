using System;


namespace DecoratorPatternExample
{
    
    interface INotifier
    {
        void Send(string message);
    }

    
    class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }


    abstract class NotifierDecorator : INotifier
    {
        protected INotifier wrappedNotifier;

        public NotifierDecorator(INotifier notifier)
        {
            wrappedNotifier = notifier;
        }

       
        public virtual void Send(string message)
        {
            wrappedNotifier.Send(message);
        }
    }

    

    class SMSNotifierDecorator : NotifierDecorator
    {
        public SMSNotifierDecorator(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);                              
            Console.WriteLine("SMS: " + message);          
        }
    }

    class SlackNotifierDecorator : NotifierDecorator
    {
        public SlackNotifierDecorator(INotifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);                             
            Console.WriteLine("Slack: " + message);         
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Pattern - Notification System\n");

            
            Console.WriteLine(" Email only ");
            INotifier notifier = new EmailNotifier();
            notifier.Send("Server is down!");

            
            Console.WriteLine("\n Email + SMS ");
            notifier = new SMSNotifierDecorator(new EmailNotifier());
            notifier.Send("Disk space is low!");

           
            Console.WriteLine("\n Email + SMS + Slack ");
            notifier = new SlackNotifierDecorator(
                            new SMSNotifierDecorator(
                                new EmailNotifier()));
            notifier.Send("Critical error in production!");
        }
    }
}
