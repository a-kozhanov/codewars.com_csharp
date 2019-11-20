using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Kata5WithoutNumbersTests
    {
        [Test]
        public void Test()
        {
            Assert.That(Kata5WithoutNumbers.UnusualFive(), Is.EqualTo(5));
        }
    }
}