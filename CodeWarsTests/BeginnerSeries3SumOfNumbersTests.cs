using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BeginnerSeries3SumOfNumbersTests
    {
        BeginnerSeries3SumOfNumbers s = new BeginnerSeries3SumOfNumbers();

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, s.GetSum(0, 1));
            Assert.AreEqual(-1, s.GetSum(0, -1));
        }
        
    }
}