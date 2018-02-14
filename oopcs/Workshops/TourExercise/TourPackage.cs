using System.Collections.Generic;

namespace TourExercise
{
    public class TourPackage : Tour
    {
        private List<Tour> listOfTours;

        public TourPackage(string name) : base(name, 0, 0)
        {
            listOfTours = new List<Tour>();
        }

        public override int Duration
        {
            get
            {
                int totalDuration = 0;

                for (int i = 0; i < ListOfTours.Count; i++)
                {
                    totalDuration += ListOfTours[i].Duration;
                }

                duration = totalDuration;

                return duration;
            }
        }

        public override double Cost
        {
            get
            {
                double totalCost = 0;

                for (int i = 0; i < ListOfTours.Count; i++)
                {
                    totalCost += ListOfTours[i].Cost;
                }

                cost = totalCost * 0.9;

                return cost;
            }
        }

        public List<Tour> ListOfTours
        {
            get { return listOfTours; }
            set { listOfTours = value; }
        }

        public void ConsistsOf(Tour tour)
        {
            ListOfTours.Add(tour);
        }
    }
}
