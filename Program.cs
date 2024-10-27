using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bank_managment_csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new();

            // Create first customer and accounts
            Customer customer1 = bank.CreateCustomer("Chanaka");
            BankAccount account1 = bank.CreateAccount(customer1);

            // Create second customer and accounts
            Customer customer2 = bank.CreateCustomer("Amila");
            BankAccount account2 = bank.CreateAccount(customer2);

            // Perform transactions
            account1.Deposit(50000);
            account1.Withdraw(8565);

            account2.Deposit(1000);
            account2.Withdraw(1200);
            account2.Withdraw(20);

            // Display all customers and accounts
            bank.DisplayAllCustomers();
            bank.DisplayAllAccounts();
        }
    }
}