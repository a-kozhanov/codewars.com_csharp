using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DeodorantEvaporatorTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(22, DeodorantEvaporator.evaporator(10, 10, 10));
        }
    }
}