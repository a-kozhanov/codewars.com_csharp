using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SwitchCaseBugFixing6Tests
    {
        [Test]
        public static void FixedTest()
        {
            Assert.AreEqual(2, SwitchCaseBugFixing6.EvalObject(1, 1, '+'));
            Assert.AreEqual(0, SwitchCaseBugFixing6.EvalObject(1, 1, '-'));
            Assert.AreEqual(1, SwitchCaseBugFixing6.EvalObject(1, 1, '/'));
            Assert.AreEqual(1, SwitchCaseBugFixing6.EvalObject(1, 1, '*'));
            Assert.AreEqual(0, SwitchCaseBugFixing6.EvalObject(1, 1, '%'));
            Assert.AreEqual(1, SwitchCaseBugFixing6.EvalObject(1, 1, '^'));
        }
    }
}