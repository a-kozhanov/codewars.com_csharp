using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SelectiveFearOfNumbersTests
    {
        [Test]
        public static void TestFixed()
        {
            Assert.AreEqual(false, SelectiveFearOfNumbers.AmIAfraid("Monday", 13));
            Assert.AreEqual(true, SelectiveFearOfNumbers.AmIAfraid("Sunday", -666));
            Assert.AreEqual(false, SelectiveFearOfNumbers.AmIAfraid("Tuesday", 2));
            Assert.AreEqual(true, SelectiveFearOfNumbers.AmIAfraid("Tuesday", 965));
            Assert.AreEqual(true, SelectiveFearOfNumbers.AmIAfraid("Friday", 2));
        }
    }
}