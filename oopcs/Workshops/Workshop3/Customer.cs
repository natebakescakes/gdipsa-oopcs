using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops.Workshop3
{
    public class Customer
    {
        private string _name;
        private string _address;
        private string _passportNo;
        private DateTime _dateOfBirth;

        public Customer(string name, string address, string passportNo, DateTime dateOfBirth)
        {
            _name = name;
            _address = address;
            _passportNo = passportNo;
            _dateOfBirth = dateOfBirth;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string PassportNo
        {
            get { return _passportNo; }
            set { _passportNo = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public double GetAge()
        {
            // Non-static TimeSpan.TotalDays returns double, which can be floored after dividing
            // no. of days in a year
            return Math.Floor((DateTime.Today - this.DateOfBirth).TotalDays / 365);
        }
    }
}
