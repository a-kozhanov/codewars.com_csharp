using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FunctionalAdditionTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(4, FunctionalAddition.Add(1)(3));
        }
    }
}