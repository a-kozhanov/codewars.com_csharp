using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CorrectTimeStringTests
    {
        [Test]
        public void NullTest()
        {
            Assert.AreEqual(null, CorrectTimeString.Correct(null));
        }

        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", CorrectTimeString.Correct(""));
        }

        [Test]
        public void InvalidFormatTests()
        {
            Assert.AreEqual(null, CorrectTimeString.Correct("001122"));
            Assert.AreEqual(null, CorrectTimeString.Correct("00;11;22"));
            Assert.AreEqual(null, CorrectTimeString.Correct("0a:1c:22"));
        }

        [Test]
        public void CorrectionTests()
        {
            Assert.AreEqual("09:10:01", CorrectTimeString.Correct("09:10:01"));
            Assert.AreEqual("12:10:10", CorrectTimeString.Correct("11:70:10"));
            Assert.AreEqual("20:40:39", CorrectTimeString.Correct("19:99:99"));
            Assert.AreEqual("00:01:01", CorrectTimeString.Correct("24:01:01"));
            Assert.AreEqual("04:01:01", CorrectTimeString.Correct("52:01:01"));
        }
    }
}