using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bank_managment_csharp
{
    public class Customer(string customerName, int customerId)
    {
        public string CustomerName { get; private set; } = customerName;
        public int CustomerId { get; private set; } = customerId;
        public List<BankAccount> Accounts { get; private set; } = new List<BankAccount>();

        public void AddAccount(BankAccount account)
        {
            Accounts.Add(account);
            Console.WriteLine($"Account added for {CustomerName} with Account Number: {account.AccountNumber}\n");
        }
    }
}
