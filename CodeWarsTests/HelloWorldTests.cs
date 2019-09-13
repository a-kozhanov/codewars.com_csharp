using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HelloWorldTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("hello world!", HelloWorld.greet());
        }
    }
}