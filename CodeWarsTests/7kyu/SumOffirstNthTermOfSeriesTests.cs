using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOffirstNthTermOfSeriesTests
    {
        [TestFixture]
        public class NthSeriesTests
        {
            [Test]
            public void Test1()
            {
                Assert.AreEqual("0.00", SumOffirstNthTermOfSeries.seriesSum(0));
            }

            [Test]
            public void Test2()
            {
                Assert.AreEqual("1.77", SumOffirstNthTermOfSeries.seriesSum(9));
            }
        }
    }
}