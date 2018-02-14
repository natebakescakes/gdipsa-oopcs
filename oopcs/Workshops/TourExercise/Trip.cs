using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourExercise
{
    public class Trip
    {
        private Tour tour;
        private DateTime when;
        private int maximum;
        private List<Booking> bookings;

        public Trip(Tour tour, DateTime when, int maximum)
        {
            this.tour = tour;
            this.when = when;
            this.maximum = maximum;
            this.bookings = new List<Booking>();
        }

        public Tour Tour
        {
            get { return tour; }
        }

        public List<Booking> Bookings
        {
            get { return bookings; }
        }

        public DateTime When
        {
            get { return when; }
        }

        public int Maximum
        {
            get { return maximum; }
        }

        public void Book(Customer customer, int N)
        {
            if (N > maximum)
                throw new ApplicationException("Customer booking exceeds maximum size of trip.");

            bookings.Add(new Booking(customer, this, N));
        }

        public double GetRevenue()
        {
            double totalRevenue = 0;

            for (int i = 0; i < bookings.Count; i++)
            {
                totalRevenue += Bookings[i].Cost;
            }

            return totalRevenue;
        }
    }
}
