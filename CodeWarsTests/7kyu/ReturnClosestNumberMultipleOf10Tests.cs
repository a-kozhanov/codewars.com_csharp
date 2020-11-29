using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReturnClosestNumberMultipleOf10Tests
    {
        private ReturnClosestNumberMultipleOf10 kata = new ReturnClosestNumberMultipleOf10();

        [Test]
        public void _0_ShouldReturn10ForNumbersFrom10To14()
        {
            for (int i = 10; i <= 14; ++i)
            {
                Assert.AreEqual(10, kata.ClosestMultiple10(i));
            }
        }

        [Test]
        public void _1_ShouldReturn20ForNumbersFrom15To20()
        {
            for (int i = 15; i <= 20; ++i)
            {
                Assert.AreEqual(20, kata.ClosestMultiple10(i));
            }
        }
    }
}