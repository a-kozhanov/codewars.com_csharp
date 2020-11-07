using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class InsertDashesTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("4547-9-3", InsertDashes.InsertDash(454793));
            Assert.AreEqual("123456", InsertDashes.InsertDash(123456));
            Assert.AreEqual("1003-567", InsertDashes.InsertDash(1003567));
        }
    }
}