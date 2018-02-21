using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops.Workshop6
{
    class Customer : IComparable, IComparable<Customer>, IEquatable<Customer>
    {
        private string name;
        private string address;
        private double balance;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
        }
        public Customer(string n, string a, double b)
        {
            name = n;
            address = a;
            balance = b;
        }

        #region Object equality overrides
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Customer))
                return false;

            return Equals(obj as Customer);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Address.GetHashCode();
        }
        #endregion

        #region IEquatable<Customer> Implementation
        public bool Equals(Customer other)
        {
            return this.Name == other.Name && this.Address == other.Address;
        }
        #endregion

        #region IComparable, IComparable<Customer> Implementation
        public int CompareTo(Customer other)
        {
            return this.balance.CompareTo(other.balance);
        }

        public int CompareTo(object obj)
        {
            if (obj == null || !(obj is Customer))
                throw new ArgumentException("Object must be of type Customer");

            return CompareTo(obj as Customer);
        }
        #endregion

        #region Operator Overrides
        public static bool operator <(Customer c1, Customer c2)
        {
            return c1.CompareTo(c2) == -1;
        }

        public static bool operator >(Customer c1, Customer c2)
        {
            return c1.CompareTo(c2) == 1;
        }

        public static bool operator <=(Customer c1, Customer c2)
        {
            return c1.CompareTo(c2) == -1 || c1.CompareTo(c2) == 0;
        }

        public static bool operator >=(Customer c1, Customer c2)
        {
            return c1.CompareTo(c2) == 1 || c1.CompareTo(c2) == 0;
        }

        public static bool operator ==(Customer c1, Customer c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Customer c1, Customer c2)
        {
            return !c1.Equals(c2);
        }
        #endregion
    }
}
