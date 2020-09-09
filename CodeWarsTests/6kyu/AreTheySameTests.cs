using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AreTheySameTests
    {
        [Test]
        public void TestSum1()
        {
            int[] a = new int[] {1, 3, 1};
            int[] b = new int[] {1, 4, 4};
            bool r = AreTheySame.comp(a, b); // false
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test1()
        {
            int[] a = new int[] {121, 144, 19, 161, 19, 144, 19, 11};
            int[] b = new int[] {11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19};
            bool r = AreTheySame.comp(a, b); // True
            Assert.AreEqual(true, r);
        }

        [Test]
        public void Test1a()
        {
            int[] a = new int[] {2, 2, 3};
            int[] b = new int[] {4, 9, 9};
            bool r = AreTheySame.comp(a, b); // false
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test2a()
        {
            int[] a = new int[] {4, 4};
            int[] b = new int[] {1, 31};
            bool r = AreTheySame.comp(a, b); // false
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test2()
        {
            int[] a = new int[] {121, 144, 19, 161, 19, 144, 19, 11};
            int[] b = new int[] {11 * 11, 121 * 121, 144 * 144, 190 * 190, 161 * 161, 19 * 19, 144 * 144, 19 * 19};
            bool r = AreTheySame.comp(a, b); // False
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test3()
        {
            int[] a = new int[0];
            int[] b = new int[] {1};
            bool r = AreTheySame.comp(a, b); // False
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test4()
        {
            int[] a = new int[0];
            int[] b = null;
            bool r = AreTheySame.comp(a, b); // False
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test5()
        {
            int[] a = new int[0];
            int[] b = new int[0];
            bool r = AreTheySame.comp(a, b); // True
            Assert.AreEqual(true, r);
        }

        [Test]
        public void Test6()
        {
            int[] a = new int[] {121, 144, 19, 161, 19, 144, 19, 11, 1008};
            int[] b = new int[] {11 * 11, 121 * 121, 144 * 144, 190 * 190, 161 * 161, 19 * 19, 144 * 144, 19 * 19};
            bool r = AreTheySame.comp(a, b); // False
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test7()
        {
            int[] a = new int[] {121, 1440, 191, 161, 19, 144, 195, 11};
            int[] b = new int[] {11 * 11, 121 * 121, 1440 * 1440, 191 * 191, 161 * 161, 19 * 19, 144 * 144, 195 * 195};
            bool r = AreTheySame.comp(a, b); // True
            Assert.AreEqual(true, r);
        }

        [Test]
        public void Test8()
        {
            int[] a = new int[] {0, 14, 191, 161, 19, 144, 195, 1};
            int[] b = new int[] {1, 0, 14 * 14, 191 * 191, 161 * 161, 19 * 19, 144 * 144, 195 * 195};
            bool r = AreTheySame.comp(a, b); // True
            Assert.AreEqual(true, r);
        }

        [Test]
        public void Test9()
        {
            int[] a = new int[] {0, 14, 191, 161, 19, 144, 195, 1, 2};
            int[] b = new int[] {1, 0, 14 * 14, 191 * 191, 161 * 161, 19 * 19, 144 * 144, 195 * 195, 3};
            bool r = AreTheySame.comp(a, b); // True
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test1b()
        {
            int[] a = new int[] {2, 2, 3};
            int[] b = new int[] {4, 4, 9};
            bool r = AreTheySame.comp(a, b); // false
            Assert.AreEqual(true, r);
        }

        [Test]
        public void Test2b()
        {
            int[] a = new int[] {3, 4};
            int[] b = new int[] {0, 25};
            bool r = AreTheySame.comp(a, b); // false
            Assert.AreEqual(false, r);
        }
    }
}