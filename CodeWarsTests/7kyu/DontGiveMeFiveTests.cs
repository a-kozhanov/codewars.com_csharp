using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataDontGiveMeFiveTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(8, KataDontGiveMeFive.DontGiveMeFive(1, 9));
            Assert.AreEqual(12, KataDontGiveMeFive.DontGiveMeFive(4, 17));
        }
    }
}