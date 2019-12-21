using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PointsOfReflectionTests
    {
        [Test, Description("Your solution should work for some fixed tests")]
        public void FixedTest()
        {
            Assert.AreEqual(new int[] { 2, 2 }, PointsOfReflection.SymmetricPoint(new int[] { 0, 0 }, new int[] { 1, 1 }));
            Assert.AreEqual(new int[] { -6, -18 }, PointsOfReflection.SymmetricPoint(new int[] { 2, 6 }, new int[] { -2, -6 }));
            Assert.AreEqual(new int[] { -30, 30 }, PointsOfReflection.SymmetricPoint(new int[] { 10, -10 }, new int[] { -10, 10 }));
            Assert.AreEqual(new int[] { -25, 37 }, PointsOfReflection.SymmetricPoint(new int[] { 1, -35 }, new int[] { -12, 1 }));
            Assert.AreEqual(new int[] { -1014, -443 }, PointsOfReflection.SymmetricPoint(new int[] { 1000, 15 }, new int[] { -7, -214 }));
            Assert.AreEqual(new int[] { 0, 0 }, PointsOfReflection.SymmetricPoint(new int[] { 0, 0 }, new int[] { 0, 0 }));
        }
    }
}
