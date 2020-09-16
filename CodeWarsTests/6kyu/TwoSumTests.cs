using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataTwoSumTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new[] {0, 2}, KataTwoSum.TwoSum(new[] {1, 2, 3}, 4).OrderBy(a => a).ToArray());
            Assert.AreEqual(new[] {1, 2}, KataTwoSum.TwoSum(new[] {1234, 5678, 9012}, 14690).OrderBy(a => a).ToArray());
            Assert.AreEqual(new[] {0, 1}, KataTwoSum.TwoSum(new[] {2, 2, 3}, 4).OrderBy(a => a).ToArray());
        }
    }
}