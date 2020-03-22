using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OfficeVISabbaticalTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Sabbatical! Boom!", OfficeVISabbatical.Sabb("Can I have a sabbatical?", 5, 5));
            Assert.AreEqual("Back to your desk, boy.", OfficeVISabbatical.Sabb("Why are you shouting?", 7, 2));
            Assert.AreEqual("Sabbatical! Boom!", OfficeVISabbatical.Sabb("What do you mean I cant learn to code??", 8, 9));
            Assert.AreEqual("Back to your desk, boy.", OfficeVISabbatical.Sabb("Please calm down", 9, 1));
        }
    }
}