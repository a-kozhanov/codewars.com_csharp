using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SplitStringsTests
    {
        [TestFixture]
        public class SplitStringTests
        {
            [Test]
            public void BasicTests()
            {
                Assert.AreEqual(new string[] {"ab", "c_"}, SplitStrings.Solution("abc"));
                Assert.AreEqual(new string[] {"ab", "cd", "ef"}, SplitStrings.Solution("abcdef"));
            }
        }
    }
}