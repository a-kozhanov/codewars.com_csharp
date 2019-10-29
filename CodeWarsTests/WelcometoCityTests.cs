using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WelcomeToCityTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Hello, John Smith! Welcome to Phoenix, Arizona!", WelcomeToCity.SayHello(new string[] { "John", "Smith" }, "Phoenix", "Arizona"));
        }
    }
}