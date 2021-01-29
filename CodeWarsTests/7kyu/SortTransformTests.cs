using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SortTransformTests
    {
        [Test]
        [TestCase(new[] {121, 122, 123, 124, 125, 120, 122, 132}, "yzz-xy}-}yx-xy}")]
        [TestCase(new[] {111, 112, 113, 114, 115, 113, 114, 110}, "oprn-nors-sron-nors")]
        [TestCase(new[] {51, 62, 73, 84, 95, 100, 99, 126}, "3>c~-3>d~-~d>3-3>d~")]
        public void BasicTest(int[] arr, string expected)
        {
            Assert.That(KataSortTransform.SortTransform(arr), Is.EqualTo(expected));
        }
    }
}