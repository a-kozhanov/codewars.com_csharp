using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AverageScoresTests
    {
        [Test]
        public void BasicTests()
        {
            var scores = new int[] {49, 3, 5, 300, 7};
            Assert.AreEqual(73, AverageScores.Average(scores));

            scores = new int[] {90, 98, 89, 100, 100, 86, 94};
            Assert.AreEqual(94, AverageScores.Average(scores));
        }
    }
}