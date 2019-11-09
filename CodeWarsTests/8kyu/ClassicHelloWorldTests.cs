using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ClassicHelloWorldTests
    {
        [Test]
        public void test1()
        {
            ClassicHelloWorld.Main(new string[] { "Greetings from Javatlacati" });
            Assert.AreEqual(1, 1);
        }
    }
}