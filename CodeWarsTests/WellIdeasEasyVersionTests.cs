using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WellIdeasEasyVersionTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Fail!", WellIdeasEasyVersion.Well(new string[] { "bad", "bad", "bad" }));
            Assert.AreEqual("Publish!", WellIdeasEasyVersion.Well(new string[] { "good", "bad", "bad", "bad", "bad" }));
            Assert.AreEqual("I smell a series!", WellIdeasEasyVersion.Well(new string[] { "good", "bad", "bad", "bad", "bad", "good", "bad", "bad", "good" }));
        }
    }
}