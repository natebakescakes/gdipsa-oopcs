using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops.Workshop4
{
    public class SavingsAccount : BankAccount
    {
        private static double _interestRate = 0.01;

        public SavingsAccount(string accountNumber, Customer accountHolder, double balance) 
            : base(accountNumber, accountHolder, balance)
        {
        }

        public override double InterestRate
        {
            get { return _interestRate; }
        }
    }

    public class CurrentAccount : BankAccount
    {
        private static double _interestRate = 0.0025;

        public CurrentAccount(string accountNumber, Customer accountHolder, Double balance)
            : base(accountNumber, accountHolder, balance)
        {
        }

        public override double InterestRate
        {
            get { return _interestRate; }
        }
    }

    public class OverDraftAccount : BankAccount
    {
        private static double _interestRate = 0.0025;
        private static double _creditRate = 0.06;

        public OverDraftAccount(string accountNumber, Customer accountHolder, Double balance)
            : base(accountNumber, accountHolder, balance)
        {
        }

        public override double InterestRate
        {
            get { return _interestRate; }
        }

        public double CreditRate
        {
            get { return _creditRate; }
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public override double CalculateInterest()
        {
            if (Balance > 0)
                return Balance * InterestRate;
            else
                return Balance * CreditRate;
        }

        public override void CreditInterest()
        {
            if (Balance > 0)
                Deposit(CalculateInterest());
            else
                Withdraw(Math.Abs(CalculateInterest()));
        }
    }
}
