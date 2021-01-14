using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BuildSquareTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("", BuildSquare.GenerateShape(0));
            Assert.AreEqual("+", BuildSquare.GenerateShape(1));
            Assert.AreEqual("++\n++", BuildSquare.GenerateShape(2));
            Assert.AreEqual("+++\n+++\n+++", BuildSquare.GenerateShape(3));
        }
    }
}