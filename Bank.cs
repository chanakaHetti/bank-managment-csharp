using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bank_managment_csharp
{
    public class Bank
    {
        private List<Customer> customers = new List<Customer>();
        private List<BankAccount> accounts = new List<BankAccount>();

        public Customer CreateCustomer(string name)
        {
            int customerId = customers.Count + 1;
            Customer newCustomer = new(customerId, name);
            customers.Add(newCustomer);
            Console.WriteLine($"Created Customer: {name} with Customer ID: {customerId}\n");
            return newCustomer;
        }

        public BankAccount CreateAccount(Customer customer)
        {
            int accountNumber = (customers.Count * 100) + accounts.Count + 1;
            BankAccount newAccount = new(accountNumber);
            accounts.Add(newAccount);
            Console.WriteLine($"Created Account number: {accountNumber} for Customer ID: {customer.CustomerId}\n");
            return newAccount;
        }

        public void DisplayAllCustomers()
        {
            Console.WriteLine("Bank Customers:");
            foreach (var customer in customers)
            {
                customer.DisplayCustomerInfo();
            }
        }

        public void DisplayAllAccounts()
        {
            Console.WriteLine("Bank Accounts:");
            foreach (var account in accounts)
            {
                account.DisplayAcocuntInfo();
            }
        }
    }
}