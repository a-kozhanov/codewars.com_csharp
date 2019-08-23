using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class IntegersRecreationOneTests
    {
        [Test]
        public void Test01()
        {
            Assert.AreEqual("[[1, 1], [42, 2500], [246, 84100]]", IntegersRecreationOne.listSquared(1, 250));
        }
        [Test]
        public void Test02()
        {
            Assert.AreEqual("[[42, 2500], [246, 84100]]", IntegersRecreationOne.listSquared(42, 250));
        }
        [Test]
        public void Test03()
        {
            Assert.AreEqual("[[287, 84100]]", IntegersRecreationOne.listSquared(250, 500));
        }
    }
}