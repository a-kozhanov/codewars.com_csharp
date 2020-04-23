using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AllUniqueTests
    {
        [Test]
        public void TestHasUniqueChars1()
        {
            Assert.IsTrue(AllUnique.HasUniqueChars("abcdef"));
        }

        [Test]
        public void TestHasUniqueChars2()
        {
            Assert.False(AllUnique.HasUniqueChars("++-"));
        }

        [Test]
        public void TestHasUniqueChars3()
        {
            Assert.False(AllUnique.HasUniqueChars("  nAa"));
        }

        [Test]
        public void TestHasUniqueChars4()
        {
            Assert.False(AllUnique.HasUniqueChars("aba"));
        }
    }
}