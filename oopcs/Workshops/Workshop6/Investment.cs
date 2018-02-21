using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops.Workshop6
{
    public abstract class Investment
    {
        protected double cost;
        protected double estimatedValue;
        protected DateTime dateAcquired;

        public Investment(double cost, double estimatedValue, DateTime dateAcquired)
        {
            this.cost = cost;
            this.estimatedValue = estimatedValue;
            this.dateAcquired = dateAcquired;
        }

        public abstract double Cost { get; }
        public abstract double EstimatedValue { get; }
        public abstract double Profits { get; }
        public abstract DateTime DateAcquired { get; }

        public override string ToString()
        {
            return $"{GetType()}[Cost: {cost}, Estimated Value: {estimatedValue}, Profits: {Profits}, Date Acquired: {dateAcquired}]";
        }
    }

    public class Coin : Investment
    {
        public Coin(double cost, double estimatedValue, DateTime dateAcquired) 
            : base(cost, estimatedValue, dateAcquired) { }

        public override double Cost { get { return cost; } }
        public override double EstimatedValue { get { return estimatedValue; } }
        public override double Profits { get { return estimatedValue - cost; } }
        public override DateTime DateAcquired { get { return this.dateAcquired; } }
    }

    public class Gold : Investment
    {
        public Gold(double cost, double estimatedValue, DateTime dateAcquired)
            : base(cost, estimatedValue, dateAcquired) { }

        public override double Cost { get { return cost; } }
        public override double EstimatedValue { get { return estimatedValue; } }
        public override double Profits { get { return estimatedValue - cost; } }
        public override DateTime DateAcquired { get { return dateAcquired; } }
    }

    public class Antique : Investment
    {
        public Antique(double cost, double estimatedValue, DateTime dateAcquired)
            : base(cost, estimatedValue, dateAcquired) { }

        public override double Cost { get { return cost; } }
        public override double EstimatedValue { get { return estimatedValue; } }
        public override double Profits { get { return estimatedValue - cost; } }
        public override DateTime DateAcquired { get { return dateAcquired; } }
    }

    public class Investments
    {
        private List<Investment> listOfInvestments;

        public Investments()
        {
            listOfInvestments = new List<Investment>();
        }

        public List<Investment> ListOfInvestments { get { return listOfInvestments; } }

        public void AddInvestments(Investment investment)
        {
            listOfInvestments.Add(investment);
        }

        public double TotalValue()
        {
            return listOfInvestments.Sum(x => x.EstimatedValue);
        }

        public double TotalCost()
        {
            return listOfInvestments.Sum(x => x.Cost);
        }

        public double TotalProfits()
        {
            return listOfInvestments.Sum(x => x.Profits);
        }

        public override string ToString()
        {
            return String.Join("\n", listOfInvestments);
        }
    }
}
