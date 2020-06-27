using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SayHelloTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(SayHello.greet("Niks"), "hello Niks!");
            Assert.AreEqual(SayHello.greet(""), null);
            Assert.AreEqual(SayHello.greet(null), null);
        }
    }
}