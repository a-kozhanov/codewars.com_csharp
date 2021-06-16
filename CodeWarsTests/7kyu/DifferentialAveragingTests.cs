using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DifferentialAveragingTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, DifferentialAveraging.AddToAverage(0, 0, 1));
            Assert.AreEqual(1.5, DifferentialAveraging.AddToAverage(1, 1, 2));
            Assert.AreEqual(2, DifferentialAveraging.AddToAverage(1.5, 2, 3));

            Assert.AreEqual(123, DifferentialAveraging.AddToAverage(0, 0, 123));
            Assert.AreEqual(289.5, DifferentialAveraging.AddToAverage(123, 1, 456));
            Assert.AreEqual(456, DifferentialAveraging.AddToAverage(289.5, 2, 789));
        }
    }
}