using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReturnMissingElementTests
    {
        [Test]
        public void EightIsMissing()
        {
            Assert.AreEqual(8, ReturnMissingElement.GetMissingElement(new int[9] {0, 5, 1, 3, 2, 9, 7, 6, 4}));
        }

        [Test]
        public void ThreeIsMissing()
        {
            Assert.AreEqual(3, ReturnMissingElement.GetMissingElement(new int[9] {9, 2, 4, 5, 7, 0, 8, 6, 1}));
        }

        [Test]
        public void ThreeIsMissing9()
        {
            Assert.AreEqual(9, ReturnMissingElement.GetMissingElement(new int[9] {3, 2, 4, 5, 7, 0, 8, 6, 1}));
        }

        [Test]
        public void ThreeIsMissing1()
        {
            Assert.AreEqual(1, ReturnMissingElement.GetMissingElement(new int[9] {9, 2, 4, 5, 7, 0, 8, 6, 3}));
        }
    }
}