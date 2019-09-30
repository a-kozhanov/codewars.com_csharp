using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountingChangeCombinationsTests
    {
        [Test]
        public static void SimpleCase()
        {
            Assert.AreEqual(3, CountingChangeCombinations.CountCombinations(4, new[] { 1, 2 }));
        }

        [Test]
        public static void AnotherSimpleCase()
        {
            Assert.AreEqual(4, CountingChangeCombinations.CountCombinations(10, new[] { 5, 2, 3 }));
        }

        [Test]
        public static void NoChange()
        {
            Assert.AreEqual(0, CountingChangeCombinations.CountCombinations(11, new[] { 5, 7 }));
        }
    }
}