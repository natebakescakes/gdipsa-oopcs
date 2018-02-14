using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourExercise
{
    public class Customer
    {
        private string name;
        private string address;
        private string id;

        public Customer(string name, string address, string id)
        {
            this.name = name;
            this.address = address;
            this.id = id;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Id
        {
            get { return id; }
        }
    }
}
