using System;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace PracticeFinal
{
	public class Customer
	{
        
        private int customerId;
		private string customerName;
		private double balance;
        public int CustomerId
        {
            get => customerId;
            set
            {
                if (value < 0)
                    throw new InvalidPropertyValueException("CustomerId cannot be negative.");
                customerId = value;
            }
        }
        public string CustomerName
        {
            get => customerName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidPropertyValueException("CustomerName cannot be null or empty.");
                customerName = value;
            }
        }
        public double Balance
        {
            get => balance;
            set
            {
                if (value < 0)
                    throw new InvalidPropertyValueException("Balance cannot be negative.");
                balance = value;
            }
        }

        public Customer(int customerId, string customerName, double balance)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Balance = balance;
        }

        public void Display()
        {
            Console.WriteLine($"{CustomerId}, {CustomerName}, {Balance:F1}");
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
	}
}

