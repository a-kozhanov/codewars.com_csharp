using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class InitializeMyNameTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Jack Ryan", InitializeMyName.InitializeNames("Jack Ryan"));
            Assert.AreEqual("Lois M. Lane", InitializeMyName.InitializeNames("Lois Mary Lane"));
            Assert.AreEqual("Dimitri", InitializeMyName.InitializeNames("Dimitri"));
            Assert.AreEqual("Alice B. C. Davis", InitializeMyName.InitializeNames("Alice Betty Catherine Davis"));
        }
    }
}