using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperTerminalGameCombatTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(100, 5).Returns(95);
                yield return new TestCaseData(92, 8).Returns(84);
                yield return new TestCaseData(20, 30).Returns(0);
            }
        }

        [Test, TestCaseSource("testCases")]
        public float Test(float health, float damage) =>
            GrasshopperTerminalGameCombat.Combat(health, damage);
    }
}