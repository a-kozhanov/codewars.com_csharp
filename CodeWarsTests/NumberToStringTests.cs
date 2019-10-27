using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NumberToStringTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual("123", NumberToString.A);
        }

    }
}