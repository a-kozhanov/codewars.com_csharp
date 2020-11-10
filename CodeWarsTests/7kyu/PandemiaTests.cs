using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PandemiaTests
    {
        double tolerance = 0.00000000001;

        [Test]
        public void Test1()
        {
            Assert.AreEqual(73.33333333333333, Pandemia.infected("01000000X000X011X0X"), tolerance);
            Assert.AreEqual(72.72727272727273, Pandemia.infected("01X000X010X011XX"), tolerance);
            //Assert.AreEqual(0, Pandemia.infected("XXXXX"), tolerance);
            Assert.AreEqual(100, Pandemia.infected("0000000010"), tolerance);
            Assert.AreEqual(42.857142857142854, Pandemia.infected("X00X000000X10X0100"), tolerance);
        }
    }
}