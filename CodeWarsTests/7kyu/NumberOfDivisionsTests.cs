using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NumberOfDivisionsTests
    {
        [Test, Description("Sample Tests")]
        public void Test()
        {
            Assert.AreEqual(2, NumberOfDivisions.Divisions(6, 2));
            Assert.AreEqual(6, NumberOfDivisions.Divisions(100, 2));
            Assert.AreEqual(4, NumberOfDivisions.Divisions(2450, 5));
            Assert.AreEqual(8, NumberOfDivisions.Divisions(9999, 3));
            Assert.AreEqual(0, NumberOfDivisions.Divisions(2, 3));
            Assert.AreEqual(1, NumberOfDivisions.Divisions(5, 5));
        }
    }
}