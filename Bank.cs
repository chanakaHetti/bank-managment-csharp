using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bank_managment_csharp
{
    public class Bank
    {
        private List<Customer> customers = new List<Customer>();

        public Customer CreateCustomer(string name)
        {
            int customerId = customers.Count + 1;
            Customer newCustomer = new(name, customerId);
            customers.Add(newCustomer);
            Console.WriteLine($"Created Customer: {name} with Customer ID: {customerId}\n");
            return newCustomer;
        }

        public BankAccount CreateAccount(Customer customer)
        {
            int accountNumber = (customers.Count * 100) + customer.Accounts.Count + 1;
            BankAccount newAccount = new(accountNumber, customer);
            customer.AddAccount(newAccount);
            return newAccount;
        }

        public void DisplayAllCustomers()
        {
            Console.WriteLine("Bank Customers:");

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer ID: {customer.CustomerId}, Name: {customer.CustomerName}");
                Console.WriteLine("Accounts:");

                foreach (var account in customer.Accounts)
                {
                    account.DisplayAccountInfo();
                }
            }
        }
    }
}