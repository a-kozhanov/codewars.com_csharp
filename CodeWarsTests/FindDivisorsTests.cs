using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindDivisorsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 3, 5 }, FindDivisors.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, FindDivisors.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, FindDivisors.Divisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, FindDivisors.Divisors(24));
            Assert.AreEqual(new int[] { }, FindDivisors.Divisors(13));
        }
    }
}