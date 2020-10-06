using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataMaxPossibleScoreTests
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual(1,
                KataMaxPossibleScore.MaxPossibleScore(new Dictionary<object, int> {{"a", 1}}, new object[] { }));
            Assert.AreEqual(2,
                KataMaxPossibleScore.MaxPossibleScore(new Dictionary<object, int> {{"a", 1}}, new object[] {"a"}));
            Assert.AreEqual(29,
                KataMaxPossibleScore.MaxPossibleScore(new Dictionary<object, int> {{"a", 1}, {"b", 14}},
                    new object[] {"b"}));
            Assert.AreEqual(14,
                KataMaxPossibleScore.MaxPossibleScore(new Dictionary<object, int> {{"a", 1}, {"b", 2}, {"c", 4}},
                    new object[] {"a", "b", "c"}));
            Assert.AreEqual(23,
                KataMaxPossibleScore.MaxPossibleScore(new Dictionary<object, int> {{"a", 2}, {"b", 5}, {"c", 8}},
                    new object[] {"c"}));
        }
    }
}