using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OffloadYourWorkTests
    {
        [Test]
        public void BasicTest1()
        {
            var arr = new int[][] {new[] {1, 0}};
            Assert.That(OffloadYourWork.WorkNeeded(60, arr), Is.EqualTo("Easy Money!"));
        }

        [Test]
        public void BasicTest2()
        {
            var arr = new int[][] {new[] {0, 0}};
            Assert.That(OffloadYourWork.WorkNeeded(60, arr), Is.EqualTo("I need to work 1 hour(s) and 0 minute(s)"));
        }

        [Test]
        public void BasicTest3()
        {
            var arr = new int[][] {new[] {1, 55}, new[] {0, 25}};
            Assert.That(OffloadYourWork.WorkNeeded(141, arr), Is.EqualTo("I need to work 0 hour(s) and 1 minute(s)"));
        }
    }
}