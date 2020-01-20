using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DisariumNumberSpecialNumbersSeries3Tests
    {
        [TestCase(89, "Disarium !!")]
        [TestCase(564, "Not !!")]
        [TestCase(1024, "Not !!")]
        [TestCase(135, "Disarium !!")]
        [TestCase(136586, "Not !!")]
        public void BasicTests(int number, string expected)
        {
            Assert.That(DisariumNumberSpecialNumbersSeries3.DisariumNumber(number), Is.EqualTo(expected));
        }
    }
}