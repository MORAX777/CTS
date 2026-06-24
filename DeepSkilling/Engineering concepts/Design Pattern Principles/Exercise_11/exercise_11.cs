using System;


namespace DependencyInjectionExample
{

    interface ICustomerRepository
    {
        string FindCustomerById(int id);
    }


    class CustomerRepositoryImpl : ICustomerRepository
    {
        public string FindCustomerById(int id)
        {

            if (id == 1) return "Alice Johnson";
            if (id == 2) return "Bob Smith";
            if (id == 3) return "Charlie Brown";
            return null;
        }
    }


    class CustomerService
    {

        private ICustomerRepository repository;


        public CustomerService(ICustomerRepository repository)
        {
            this.repository = repository;
        }

        public void PrintCustomer(int id)
        {
            string name = repository.FindCustomerById(id);

            if (name != null)
                Console.WriteLine("Customer found  - ID: " + id + ", Name: " + name);
            else
                Console.WriteLine("Customer not found for ID: " + id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Injection - Customer Management\n");


            ICustomerRepository repo = new CustomerRepositoryImpl();


            CustomerService service = new CustomerService(repo);


            service.PrintCustomer(1);
            service.PrintCustomer(2);
            service.PrintCustomer(3);
            service.PrintCustomer(99);   
        }
    }
}
