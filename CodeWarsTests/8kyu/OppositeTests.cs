using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OppositeTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(true, Opposite.IsOpposite("ab", "AB"), "ab, AB => true");
            Assert.AreEqual(true, Opposite.IsOpposite("aB", "Ab"), "aB, Ab => true");
            Assert.AreEqual(true, Opposite.IsOpposite("aBcd", "AbCD"), "aBcd, AbCD => true");
            Assert.AreEqual(false, Opposite.IsOpposite("aBcde", "AbCD"), "aBcde, AbCD => false");
            Assert.AreEqual(false, Opposite.IsOpposite("AB", "Ab"), "AB, Ab => false");
            Assert.AreEqual(false, Opposite.IsOpposite("", ""), "String.Empty, String.Empty => false");
        }
    }
}