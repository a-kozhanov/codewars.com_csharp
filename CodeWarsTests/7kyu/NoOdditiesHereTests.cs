using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NoOdditiesHereTests
    {
        [Test]
        public void OneThroughFive()
        {
            Assert.AreEqual(new int[] {2, 4}, NoOdditiesHere.NoOdds(new int[] {1, 2, 3, 4, 5}));
        }
    }
}