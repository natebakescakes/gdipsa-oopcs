using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshops.Workshop4;

namespace Workshops.Workshop5
{
    public class BankBranch
    {
        private string _branchName;
        private string _branchManager;
        private List<BankAccount> _bankAccounts;

        public BankBranch(string branchName, string branchManager)
        {
            _branchName = branchName;
            _branchManager = branchManager;
            _bankAccounts = new List<BankAccount>();
        }

        public string BranchName
        {
            get { return _branchName; }
        }

        public string BranchManager
        {
            get { return _branchManager; }
        }

        public List<BankAccount> BankAccounts
        {
            get { return _bankAccounts; }
        }

        public void AddAccount(BankAccount bankAccount)
        {
            _bankAccounts.Add(bankAccount);
        }

        public override string ToString()
        {
            string printString = "";

            for (int i = 0; i < _bankAccounts.Count; i++)
            {
                printString += $"{_bankAccounts[i].AccountNumber}: {_bankAccounts[i].AccountHolder.Name}";
                
                if (i != _bankAccounts.Count - 1)
                    printString += "\n";
            }

            return printString;
        }

        public double TotalDeposits()
        {
            double totalDeposits = 0;

            for (int i = 0; i < _bankAccounts.Count; i++)
            {
                totalDeposits += _bankAccounts[i].Balance; 
            }

            return totalDeposits;
        }

        public double TotalInterestPaid()
        {
            double totalInterestPaid = 0;

            for (int i = 0; i < _bankAccounts.Count; i++)
            {
                if (_bankAccounts[i].CalculateInterest() > 0)
                    totalInterestPaid += _bankAccounts[i].CalculateInterest();
            }

            return totalInterestPaid;
        }

        public double TotalInterestEarned()
        {
            double totalInterestEarned = 0;

            for (int i = 0; i < _bankAccounts.Count; i++)
            {
                if (_bankAccounts[i].CalculateInterest() < 0)
                    totalInterestEarned += _bankAccounts[i].CalculateInterest();
            }

            return Math.Abs(totalInterestEarned);
        }
    }
}
