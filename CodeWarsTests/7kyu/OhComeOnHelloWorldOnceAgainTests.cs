using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OhComeOnHelloWorldOnceAgainTests
    {
        [Test]
        public void CheckForHelloWorld()
        {
            Assert.AreEqual("Hello, world!", OhComeOnHelloWorldOnceAgain.F());
        }
    }
}