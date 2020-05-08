using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CatAndMouseEasyVersionTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("Escaped!", CatAndMouseEasyVersion.CatMouse("C....m"));
            Assert.AreEqual("Caught!", CatAndMouseEasyVersion.CatMouse("C..m"));
            Assert.AreEqual("Escaped!", CatAndMouseEasyVersion.CatMouse("C.....m"));
        }
    }
}