using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun144DistinctDigitYearTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun144DistinctDigitYear();
            Assert.AreEqual(2013, kata.DistinctDigitYear(1987));
            Assert.AreEqual(2014, kata.DistinctDigitYear(2013));
        }
    }
}