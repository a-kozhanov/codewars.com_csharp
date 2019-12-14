using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindSlopeTests
    {
        [Test]
        public void test1()
        {
            int[] test1 = { 19, 3, 20, 3 };
            int[] test2 = { 7, 2, 7, 4 };
            int[] test3 = { 10, 50, 30, 150 };
            int[] test4 = { 15, 45, 12, 60 };
            int[] test5 = { 10, 20, 20, 80 };
            int[] test6 = { -10, 6, -10, 3 };
            FindSlope s = new FindSlope();
            Assert.AreEqual("0", s.slope(test1));
            Assert.AreEqual("undefined", s.slope(test2));
            Assert.AreEqual("5", s.slope(test3));
            Assert.AreEqual("-5", s.slope(test4));
            Assert.AreEqual("6", s.slope(test5));
            Assert.AreEqual("undefined", s.slope(test6));
        }
    }
}