using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MakeUpperCaseTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("HELLO", MakeUpper.MakeUpperCase("hello"));
        }
    }
}