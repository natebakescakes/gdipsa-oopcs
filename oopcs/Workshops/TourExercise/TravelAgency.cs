using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourExercise
{
    public class TravelAgency
    {
        private string name;
        private List<Customer> customers;
        private List<Tour> tours;
        private List<Trip> trips;

        public TravelAgency(string name)
        {
            this.name = name;
            customers = new List<Customer>();
            tours = new List<Tour>();
            trips = new List<Trip>();
        }

        public List<Trip> Trips
        {
            get { return trips; }
            set { trips = value; }
        }

        public List<Tour> Tours
        {
            get { return tours; }
            set { tours = value; }
        }

        public List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Add(Customer customer) { customers.Add(customer); }
        public void Add(Tour tour) { tours.Add(tour); }
        public void Add(Trip trip) { trips.Add(trip); }

        public Tour FindTour(string city)
        {
            for (int i = 0; i < tours.Count; i++)
            {
                if (tours[i].Name == city)
                    return tours[i];
            }

            return null;
        }

        public Trip FindTrip(string city)
        {
            for (int i = 0; i < trips.Count; i++)
            {
                if (trips[i].Tour.Name == city)
                    return trips[i];
            }

            return null;
        }

        public Customer FindCustomer(string name)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Name == name)
                    return customers[i];
            }

            return null;
        }

        public void ListTours()
        {
            for (int i = 0; i < tours.Count; i++)
            {
                Console.WriteLine($"{tours[i]}");
            }
        }

        public void ListTrips()
        {
            for (int i = 0; i < trips.Count; i++)
            {
                Console.WriteLine($"{trips[i].Tour}");
            }
        }

        public void MakeBooking(Customer customer, Trip trip, int noOfTravellers)
        {
            trip.Book(customer, noOfTravellers);
        }
    }
}
