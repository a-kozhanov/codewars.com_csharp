using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindMultiplesOfNumberTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new List<int> { 5, 10, 15, 20, 25 }, FindMultiplesOfNumber.FindMultiples(5, 25));
            Assert.AreEqual(new List<int> { 1, 2 }, FindMultiplesOfNumber.FindMultiples(1, 2));
        }
    }
}