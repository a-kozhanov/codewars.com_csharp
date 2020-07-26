using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataArrayDiffTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] {2}, KataArrayDiff.ArrayDiff(new int[] {1, 2}, new int[] {1}));
            Assert.AreEqual(new int[] {2, 2}, KataArrayDiff.ArrayDiff(new int[] {1, 2, 2}, new int[] {1}));
            Assert.AreEqual(new int[] {1}, KataArrayDiff.ArrayDiff(new int[] {1, 2, 2}, new int[] {2}));
            Assert.AreEqual(new int[] {1, 2, 2}, KataArrayDiff.ArrayDiff(new int[] {1, 2, 2}, new int[] { }));
            Assert.AreEqual(new int[] { }, KataArrayDiff.ArrayDiff(new int[] { }, new int[] {1, 2}));
        }
    }
}