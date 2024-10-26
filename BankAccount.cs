using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bank_managment_csharp
{
    public class BankAccount(int accountNumber, Customer accountHolder)
    {
        public int AccountNumber { get; private set; } = accountNumber;
        public decimal Balance { get; private set; } = 0m;
        public Customer AccountHolder { get; private set; } = accountHolder;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C} to Account Number {AccountNumber}. New Balance: {Balance:C}\n");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from Account Number {AccountNumber}. New Balance: {Balance:C}\n");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.\n");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolder.CustomerName}");
            Console.WriteLine($"Balance: {Balance:C}\n");
        }
    }
}
