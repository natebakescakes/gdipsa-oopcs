using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Day5
{
    public class Customer /*: IComparable, IComparable<Customer>*/
    {
        private string name;
        private int creditLimit;

        public Customer(string name, int creditLimit)
        {
            this.name = name;
            this.creditLimit = creditLimit;
        }

        #region IComparable, IComparable<T> Implementation
        public int CompareTo(Customer other)
        {
            return this.name.CompareTo(other.name);

            //return this.creditLimit.CompareTo(other.creditLimit);
        }

        public int CompareTo(object obj)
        {
            if (obj == null || !(obj is Customer))
                throw new ArgumentException("Object must be of type Customer.");

            return CompareTo(obj as Customer);
        }
        #endregion

        public override string ToString()
        {
            return $"[Customer: {name}, Credit Limit: {creditLimit}]";
        }
    }
}
