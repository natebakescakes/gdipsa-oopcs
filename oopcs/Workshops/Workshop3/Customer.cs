using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops.Workshop3
{
    public class Customer
    {
        public Customer(string name, string address, string passportNo, DateTime dateOfBirth)
        {
            Name = name;
            Address = address;
            PassportNo = passportNo;
            DateOfBirth = dateOfBirth;
            Accounts = new List<BankAccount>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PassportNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<BankAccount> Accounts { get; set; }

        public double GetAge()
        {
            // Non-static TimeSpan.TotalDays returns double, which can be floored after dividing
            // no. of days in a year
            return Math.Floor((DateTime.Today - this.DateOfBirth).TotalDays / 365);
        }

        public void AddAccount(BankAccount account)
        {
            Accounts.Add(account);
        }
    }
}
