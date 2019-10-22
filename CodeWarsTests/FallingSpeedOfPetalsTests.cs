using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FallingSpeedOfPetalsTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(5).Returns(80);
            }
        }

        [Test, TestCaseSource("testCases")]
        public double Test(double v) => FallingSpeedOfPetals.SakuraFall(v);
    }
}