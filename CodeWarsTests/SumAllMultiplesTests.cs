using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumAllMultiplesTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(8, SumAllMultiples.findSum(5));
            Assert.AreEqual(33, SumAllMultiples.findSum(10));
        }
    }
}