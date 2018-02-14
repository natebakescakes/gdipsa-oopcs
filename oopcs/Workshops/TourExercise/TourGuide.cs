using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourExercise
{
    public class TourGuide
    {
        private string name;
        private string address;
        private int salary;

        public TourGuide(string name, string address, int salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
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

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
