using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TidyNumberSpecialNumbersSeries9Tests
    {
        [TestCase(12)]
        [TestCase(2789)]
        [TestCase(2335)]
        public void BasicTestsTrue(int n)
        {
            Assert.IsTrue(TidyNumberSpecialNumbersSeries9.TidyNumber(n));
        }

        [TestCase(102)]
        [TestCase(9672)]
        public void BasicTestsFalse(int n)
        {
            Assert.IsFalse(TidyNumberSpecialNumbersSeries9.TidyNumber(n));
        }
    }
}