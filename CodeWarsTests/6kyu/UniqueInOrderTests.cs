using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class UniqueInOrderTests
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", KataUniqueInOrder.UniqueInOrder(""));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", KataUniqueInOrder.UniqueInOrder("AAAABBBCCDAABBB"));
        }
    }
}