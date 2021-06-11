using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CorrectDateStringTests
    {
        [Test]
        public void NullTest()
        {
            Assert.AreEqual(null, CorrectDateString.Correct(null));
        }
        
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", CorrectDateString.Correct(""));
        }
        
        [Test]
        public void InvalidFormatTests()
        {
            Assert.AreEqual(null, CorrectDateString.Correct("01112016"));
            Assert.AreEqual(null, CorrectDateString.Correct("01,11,2016"));
            Assert.AreEqual(null, CorrectDateString.Correct("0a.1c.2016"));
        }

        [Test]
        public void CorrectionTests()
        {
            Assert.AreEqual("01.03.2016", CorrectDateString.Correct("30.02.2016"));
            Assert.AreEqual("10.07.2015", CorrectDateString.Correct("40.06.2015"));
            Assert.AreEqual("11.01.2015", CorrectDateString.Correct("11.13.2014"));
            Assert.AreEqual("07.02.2011", CorrectDateString.Correct("99.11.2010"));
        }
    }
}