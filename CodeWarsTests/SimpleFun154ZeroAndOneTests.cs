using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun154ZeroAndOneTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun154ZeroAndOne();
            Assert.AreEqual(1, kata.ZeroAndOne("01010"));
            Assert.AreEqual(6, kata.ZeroAndOne("11101111"));
            Assert.AreEqual(0, kata.ZeroAndOne("01"));
            Assert.AreEqual(0, kata.ZeroAndOne("10"));
            Assert.AreEqual(2, kata.ZeroAndOne("110110"));
            Assert.AreEqual(2, kata.ZeroAndOne("110100"));
        }
    }
}