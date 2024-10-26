namespace bank_managment_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            // Create customer 1 and account
            Customer customer1 = bank.CreateCustomer("Chanaka HA");
            BankAccount account1 = bank.CreateAccount(customer1);

            // Create customer 2 and account
            Customer customer2 = bank.CreateCustomer("Amila Jay");
            BankAccount account2 = bank.CreateAccount(customer2);

            // Perform transactions
            account1.Deposit(1200);
            account1.Withdraw(100);

            account2.Deposit(8000);
            account2.Withdraw(2100);
            account2.Withdraw(8000);

            // Display all customers
            bank.DisplayAllCustomers();
        }
    }
}