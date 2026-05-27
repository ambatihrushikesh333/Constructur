using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private double balance;

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
        }
        public double GetBalance()
        {
            return balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.Deposit(10000);
            account.Withdraw(3000);
            Console.WriteLine("Balance: " + account.GetBalance());
        }
    }
}
