using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        private List<Customer> _customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
            Console.WriteLine($"Customer {customer.Name} added\n");
        }

        public void RemoveCustomer(Customer customer)
        {
            if(_customers.Remove(customer))
                Console.WriteLine($"Customer {customer.Name} has been succesfully deleted\n");
            else
                Console.WriteLine($"Customer {customer.Name} could not be deleted\n");
        }

        public void ListCustomers()
        {
            Console.WriteLine("List of customers; \n ");
            foreach (Customer customer in _customers)
            {
                Console.WriteLine("####################################");

                Console.WriteLine(
                    $"Id: {customer.Id}\n" +
                    $"Name: {customer.Name}\n" +
                    $"Last Name: {customer.LastName}");


                Console.WriteLine("####################################\n");
            }
               
        }
    }
}
