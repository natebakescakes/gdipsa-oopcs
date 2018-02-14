using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourExercise
{
    public class Booking
    {
        private Trip trip;
        private Customer customer;
        private int noOfTravellers;
        private double cost;

        public Booking(Customer customer, Trip trip, int noOfTravellers)
        {
            this.customer = customer;
            this.trip = trip;
            this.noOfTravellers = noOfTravellers;
        }

        public Trip Trip
        {
            get { return trip; }
            set { trip = value; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public int NoOfTravellers
        {
            get { return noOfTravellers; }
            set { noOfTravellers = value; }
        }

        public double Cost
        {
            get
            {
                if (NoOfTravellers > 5)
                    cost = Trip.Tour.Cost * NoOfTravellers * 0.95;
                else
                    cost = Trip.Tour.Cost * NoOfTravellers;

                return cost;
            }
        }
    }
}
