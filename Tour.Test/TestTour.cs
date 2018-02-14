using Microsoft.VisualStudio.TestTools.UnitTesting;
using TourExercise;

namespace TourExercise.Test
{
    [TestClass]
    public class TestTour
    {
        Tour t1, t2, t3, t4;

        [TestInitialize]
        public void InitializeTour()
        {
            t1 = new Tour("Paris", 3400, 3);
            t2 = new Tour("London", 3200, 3);
            t3 = new Tour("Munich", 3100, 2);
            t4 = new Tour("Milan", 3500, 3);
        }

        [TestMethod]
        public void TestToString()
        {
            //"Name: {name}, Cost: {cost}, Duration: {duration}"
            Assert.AreEqual("Name: Paris, Cost: 3400, Duration: 3", t1.ToString());
            Assert.AreEqual("Name: London, Cost: 3200, Duration: 3", t2.ToString());
            Assert.AreEqual("Name: Munich, Cost: 3100, Duration: 2", t3.ToString());
            Assert.AreEqual("Name: Milan, Cost: 3500, Duration: 3", t4.ToString());
        }
    }
}
