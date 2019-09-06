using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperPersonalizedMessageTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Hello boss", GrasshopperPersonalizedMessage.Greet("Daniel", "Daniel"));
            Assert.AreEqual("Hello guest", GrasshopperPersonalizedMessage.Greet("Greg", "Daniel"));
        }
    }
}