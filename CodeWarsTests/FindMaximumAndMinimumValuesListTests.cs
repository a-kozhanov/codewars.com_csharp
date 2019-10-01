using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindMaximumAndMinimumValuesListTests
    {
        [Test]
        public void TestExamples()
        {
            Assert.AreEqual(-110, new FindMaximumAndMinimumValuesList().Min(new[] { -52, 56, 30, 29, -54, 0, -110 }));
            Assert.AreEqual(0, new FindMaximumAndMinimumValuesList().Min(new[] { 42, 54, 65, 87, 0 }));
            Assert.AreEqual(566, new FindMaximumAndMinimumValuesList().Max(new[] { 4, 6, 2, 1, 9, 63, -134, 566 }));
            Assert.AreEqual(5, new FindMaximumAndMinimumValuesList().Max(new[] { 5 }));
        }
    }
}