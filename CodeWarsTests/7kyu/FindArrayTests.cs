using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindArrayTests
    {
        [Test, Description("Basic tests")]
        public void BasicTest()
        {
            Assert.AreEqual(new[] {'a', 'a'},
                KataFindArray.FindArray(new object[] {'a', 'a', 'a', 'a', 'a'}, new int[] {2, 4}));
            Assert.AreEqual(new[] {1, 1, 1},
                KataFindArray.FindArray(new object[] {0, 1, 5, 2, 1, 8, 9, 1, 5}, new int[] {1, 4, 7}));
            Assert.AreEqual(new[] {1}, KataFindArray.FindArray(new object[] {1, 2, 3, 4, 5}, new int[] {0}));
            Assert.AreEqual(new[] {"this", "is", "test"},
                KataFindArray.FindArray(new object[] {"this", "is", "test"}, new int[] {0, 1, 2}));
        }

        [Test, Description("Less basic tests")]
        public void EdgeTest()
        {
            Assert.AreEqual(new[] {5, 3, 1}, KataFindArray.FindArray(new object[] {1, 2, 3, 4, 5}, new int[] {4, 2, 0}),
                "Should handle unordered indices");
            Assert.AreEqual(new[] {3, 3, 3}, KataFindArray.FindArray(new object[] {1, 2, 3, 4, 5}, new int[] {2, 2, 2}),
                "Should handle repeated indices");
            Assert.AreEqual(new int[] { }, KataFindArray.FindArray(new object[] {1, 2, 3, 4, 5}, new int[] { }),
                "Should return empty array if no indices");
            Assert.AreEqual(new int[] { }, KataFindArray.FindArray(new object[] { }, new int[] {0, 1, 2}),
                "Should return empty array if arr1 is empty");
            Assert.AreEqual(new int[] { }, KataFindArray.FindArray(new object[] { }, new int[] { }));
        }
    }
}