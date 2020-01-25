using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOfNumbersFrom0ToNTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("0+1+2+3+4+5+6 = 21", SumOfNumbersFrom0ToN.ShowSequence(6));
        }
    }
}