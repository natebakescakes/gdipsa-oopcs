using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourExercise
{
    public class Tour
    {
        protected string name;
        protected double cost;
        protected int duration;

        public Tour(string name, double cost, int duration)
        {
            this.name = name;
            this.cost = cost;
            this.duration = duration;
        }

        public string Name
        {
            get { return name; }
        }

        public virtual int Duration
        {
            get { return duration; }
        }

        public virtual double Cost
        {
            get { return cost; }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Cost: {Cost}, Duration: {Duration}";
        }
    }
}
