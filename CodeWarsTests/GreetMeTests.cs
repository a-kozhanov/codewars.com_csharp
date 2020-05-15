using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GreetMeTests
    {
        [Test]
        public void SampleTest()
        {
            // Additional sample tests are left as an exercise to the user.
            // Feel free to add more tests using the "Assert.That(actual, Is.EqualTo(expected))" syntax
            Assert.That(GreetMe.Greet("riley"), Is.EqualTo("Hello Riley!"));
        }
    }
}