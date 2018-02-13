using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcs.Day1
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolderName, double balance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            this.Balance = balance;
        }

        public void Withdraw(double amount)
        {
            if (amount > this.Balance)
                throw new ArgumentException("Withdrawal amount cannot be more than balance");
            else
                this.Balance -= amount;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void TransferTo(double amount, BankAccount another)
        {
            this.Withdraw(amount);
            another.Deposit(amount);
        }

        public double Show()
        {
            return Balance;
        }
    }
}
