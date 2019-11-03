using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NameShufflerTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("McClane john", KataNameShuffler.NameShuffler("john McClane"));
            Assert.AreEqual("jeggins Mary", KataNameShuffler.NameShuffler("Mary jeggins"));
            Assert.AreEqual("jerry tom", KataNameShuffler.NameShuffler("tom jerry"));
        }
    }
}