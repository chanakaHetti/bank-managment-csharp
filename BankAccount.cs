using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bank_managment_csharp
{
    public class BankAccount(int accountNumber)
    {
        public int AccountNumber { get; private set; } = accountNumber;
        public decimal Balance = 0m;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount:C} to Account Number {AccountNumber}. New balance: {Balance:C}\n");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive. \n");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw {amount:C} from Account Number {AccountNumber}. New balance: {Balance:C}\n");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.\n");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.\n");
            }
        }

        public void DisplayAcocuntInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }
}
