namespace Lectures.Day3
{
    public class Customer
    {
        private string _name;
        private Order order;

        public Customer(string name)
        {
            _name = name;
            order = new Order(8);
        }

        public void Buy(Product p)
        {
            order.Add(p);
        }

        public double CostOfPurchase()
        {
            return order.TotalPrice();
        }

        public override string ToString()
        {
            return order.ToString();
        }
    }
}
