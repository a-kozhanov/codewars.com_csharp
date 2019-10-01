using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class JennySecretMessageTests
    {
        [Test]
        public static void ShouldGreetJimNormally()
        {
            Assert.AreEqual("Hello, Jim!", JennySecretMessage.greet("Jim"));
        }
        [Test]
        public static void ShouldGreetJaneNormally()
        {
            Assert.AreEqual("Hello, Jane!", JennySecretMessage.greet("Jane"));
        }
        [Test]
        public static void ShouldGreetSimonNormally()
        {
            Assert.AreEqual("Hello, Simon!", JennySecretMessage.greet("Simon"));
        }

        [Test]
        public static void ShouldGreetJohnnySpecially()
        {
            Assert.AreEqual("Hello, my love!", JennySecretMessage.greet("Johnny"));
        }
    }
}