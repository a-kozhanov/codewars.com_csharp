using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TransportationVacationTests
    {

        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            testing(TransportationVacation.RentalCarCost(1), 40);
            testing(TransportationVacation.RentalCarCost(3), 100);
            testing(TransportationVacation.RentalCarCost(7), 230);
        }
    }
}