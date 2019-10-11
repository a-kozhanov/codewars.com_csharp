using CodeWars;
using NUnit.Framework;


namespace CodeWarsTests
{
    [TestFixture]
    public class ReturningStringsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(ReturningStrings.Greet("Ryan"), Is.EqualTo("Hello, Ryan how are you doing today?"));
        }
    }
}