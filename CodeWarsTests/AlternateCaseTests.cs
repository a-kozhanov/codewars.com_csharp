using CodeWars;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AlternateCaseTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("ABC", AlternateCase.alternateCase("abc"));
            Assert.AreEqual("abc", AlternateCase.alternateCase("ABC"));
            Assert.AreEqual("hELLO wORLD", AlternateCase.alternateCase("Hello World"));
        }
    }
}