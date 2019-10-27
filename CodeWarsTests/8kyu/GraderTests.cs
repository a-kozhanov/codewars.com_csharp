using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GraderTests
    {
        [Test]
        [TestCase(0.7, ExpectedResult = 'C')]
        [TestCase(0.9, ExpectedResult = 'A')]
        [TestCase(0.6, ExpectedResult = 'D')]
        public static char FixedTest(double score)
        {
            return KataGrader.Grader(score);
        }
    }
}