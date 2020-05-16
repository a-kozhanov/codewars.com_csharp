using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ZeroBalancedArrayTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(false, ZeroBalancedArray.IsZeroBalanced(new List<int> {3}));
            Assert.AreEqual(true, ZeroBalancedArray.IsZeroBalanced(new List<int> {0, 0, 0, 0, 0, 0}));
        }
    }
}