using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindCombinationTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(3, FindCombination.CountCombinations("hellohellohello", "hello"),
                "Try again! These words don't need spaces in between.");
        }
    }
}