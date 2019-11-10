using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataTemplateStringsTests
    {
        [Test]
        public void TempleStrings()
        {
            Assert.AreEqual("Animals are Good", KataTemplateStrings.TempleStrings("Animals", "Good"));
        }
    }
}