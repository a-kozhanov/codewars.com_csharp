using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumMixedArrayTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(22, SumMixedArray.SumMix(new object[] { 9, 3, "7", "3" }));
            Assert.AreEqual(42, SumMixedArray.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
            Assert.AreEqual(41, SumMixedArray.SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
        }

        [Test, Description("Basic Tests")]
        public void MyTest()
        {
            Assert.AreEqual(22, SumMixedArray.SumMix(new object[] { 9, 3, "7", "3" }));
            Assert.AreEqual(42, SumMixedArray.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
            Assert.AreEqual(41, SumMixedArray.SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
            Assert.AreEqual(45, SumMixedArray.SumMix(new object[] { "1", "5", "8", 8, 9, 9, 2, "3" }));
            Assert.AreEqual(61, SumMixedArray.SumMix(new object[] { 8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7 }));
        }

        private static Random rnd = new Random();

        private static object[] names = new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private static int Solution(object[] x) =>
            x.Sum(v => (v as string == null) ? (int)v : Int32.Parse((string)v));

        [Test, Description("Random Tests")]
        public void RandomTest()
        {
            for (int i = 0; i < 100; ++i)
            {
                object[] test = new object[rnd.Next(1, 31)];
                for (int j = 0; j < test.Length; ++j)
                {
                    test[j] = names[rnd.Next(0, names.Length)];
                }
                int expected = Solution(test);
                int actual = SumMixedArray.SumMix(test);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}