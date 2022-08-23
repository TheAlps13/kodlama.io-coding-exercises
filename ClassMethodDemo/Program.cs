using System;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Alper",
                LastName = "Tasci"
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Kemal",
                LastName = "Johnson"
            };

            Customer customer3 = new Customer
            {
                Id = 3,
                Name = "Goldy",
                LastName = "King"
            };

            ///////////////////////////////////////////////////////////////

            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);

            customerManager.ListCustomers();

            customerManager.RemoveCustomer(customer2);

            customerManager.ListCustomers();
        }
    }
}
