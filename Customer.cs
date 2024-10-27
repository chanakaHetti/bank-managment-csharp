using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bank_managment_csharp
{
    public class Customer(int customerId, string customerName)
    {
        public int CustomerId { get; private set; } = customerId;
        public string CustomerName { get; private set; } = customerName;

        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer ID: {CustomerId}, Name: {CustomerName}");
        }
    }
}
