using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CreditCardMaskTests
    {
        [Test]
        public void ExamplesTests()
        {
            Assert.AreEqual("############5616", CreditCardMask.Maskify("4556364607935616"));
            Assert.AreEqual("1", CreditCardMask.Maskify("1"));
            Assert.AreEqual("#1111", CreditCardMask.Maskify("11111"));
        }
    }
}