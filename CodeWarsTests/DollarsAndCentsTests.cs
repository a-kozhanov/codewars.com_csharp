using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DollarsAndCentsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("$39.99", DollarsAndCents.FormatMoney(39.99), "That's not formatted the way we expected.");
        }
    }
}