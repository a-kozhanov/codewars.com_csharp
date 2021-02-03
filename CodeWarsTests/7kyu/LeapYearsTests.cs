using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LeapYearsTests
    {
        [Test]
        public static void Year1234()
        {
            Assert.AreEqual(false, LeapYears.IsLeapYear(1234), "Year 1234");
        }

        [Test]
        public static void Year1984()
        {
            Assert.AreEqual(true, LeapYears.IsLeapYear(1984), "Year 1984");
        }

        [Test]
        public static void Year2000()
        {
            Assert.AreEqual(true, LeapYears.IsLeapYear(2000), "Year 2000");
        }

        [Test]
        public static void Year2010()
        {
            Assert.AreEqual(false, LeapYears.IsLeapYear(2010), "Year 2010");
        }

        [Test]
        public static void Year2013()
        {
            Assert.AreEqual(false, LeapYears.IsLeapYear(2013), "Year 2013");
        }
    }
}