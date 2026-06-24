using System;

// Exercise 1: Singleton Pattern
// The Logger class should have only one instance throughout the application.

namespace SingletonPatternExample
{
    // Singleton Logger class
    class Logger
    {
        // Step 1: private static variable to hold the single instance
        private static Logger instance = null;

        // Step 2: private constructor so no one can do "new Logger()" from outside
        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        // Step 3: public static method to get the one and only instance
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        // A simple log method
        public void Log(string message)
        {
            Console.WriteLine("LOG: " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Pattern - Logger\n");

            // Get logger instance in two different places
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("Application started.");
            logger2.Log("User logged in.");

            // Check if both variables point to the same object
            if (logger1 == logger2)
            {
                Console.WriteLine("\nBoth logger1 and logger2 are the SAME instance. Singleton works!");
            }
            else
            {
                Console.WriteLine("\nDifferent instances - Singleton NOT working.");
            }
        }
    }
}
