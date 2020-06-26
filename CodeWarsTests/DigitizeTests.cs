using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DigitizeTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(new int[] {1, 2, 3}, Digitize.digitize(123));
            Assert.AreEqual(new int[] {1}, Digitize.digitize(1));
            Assert.AreEqual(new int[] {0}, Digitize.digitize(0));
            Assert.AreEqual(new int[] {1, 2, 3, 0}, Digitize.digitize(1230));
            Assert.AreEqual(new int[] {8, 6, 7, 5, 3, 0, 9}, Digitize.digitize(8675309));
        }
    }
}