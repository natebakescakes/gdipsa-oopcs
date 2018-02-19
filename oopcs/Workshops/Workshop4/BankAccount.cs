using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops.Workshop4
{
    public class BankAccount
    {
        private static double _interestRate = 0;

        public string AccountNumber { get; set; }
        public Customer AccountHolder { get; set; }
        public double Balance { get; set; }
        public virtual double InterestRate
        {
            get { return _interestRate; }
        }

        public BankAccount(string accountNumber, Customer accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
            accountHolder.AddAccount(this);
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
            Balance += amount;
        }

        public void TransferTo(double amount, BankAccount other)
        {
            Withdraw(amount);
            other.Deposit(amount);
        }

        public double CalculateInterest()
        {
            return Balance * InterestRate;
        }

        public void CreditInterest()
        {
            Deposit(CalculateInterest());
        }
    }
}
