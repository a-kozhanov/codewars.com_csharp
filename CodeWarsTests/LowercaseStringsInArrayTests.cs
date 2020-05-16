using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LowercaseStringsInArrayTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(new object[] {"red", "green"},
                LowercaseStringsInArray.ArrayLowerCase(new object[] {"Red", "Green"}));
        }
    }
}