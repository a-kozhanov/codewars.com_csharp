using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindGCFOfTwoNumbersTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(4, FindGCFOfTwoNumbers.FindGCF(8, 20));
            Assert.AreEqual(1, FindGCFOfTwoNumbers.FindGCF(5, 13));
            Assert.AreEqual(100, FindGCFOfTwoNumbers.FindGCF(100, 100));
        }
    }
}