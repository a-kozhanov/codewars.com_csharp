using CodeWars;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GetNumberFromStringTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(1, GetNumberFromString.getNumberFromString("1"));
            Assert.AreEqual(123, GetNumberFromString.getNumberFromString("123"));
            Assert.AreEqual(7, GetNumberFromString.getNumberFromString("this is number: 7"));
        }
    }
}