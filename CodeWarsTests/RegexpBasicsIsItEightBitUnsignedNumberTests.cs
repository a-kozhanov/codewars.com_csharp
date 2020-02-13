using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RegexpBasicsIsItEightBitUnsignedNumberTests
    {
        [TestFixture]
        public class Tests
        {
            // Fisher-Yates shuffling algorithm
            private Random _random = new Random();

            private void Shuffle<T>(T[] array)
            {
                int n = array.Length;
                for (int i = 0; i < (n - 1); i++)
                {
                    int r = i + _random.Next(n - i);
                    T t = array[r];
                    array[r] = array[i];
                    array[i] = t;
                }
            }

            [Test]
            public void ExampleTests()
            {
                Assert.AreEqual(false, "".EightBitNumber());
                Assert.AreEqual(true, "0".EightBitNumber());
                Assert.AreEqual(false, "00".EightBitNumber());
                Assert.AreEqual(true, "55".EightBitNumber());
                Assert.AreEqual(false, "042".EightBitNumber());
                Assert.AreEqual(true, "123".EightBitNumber());
                Assert.AreEqual(true, "255".EightBitNumber());
                Assert.AreEqual(false, "256".EightBitNumber());
                Assert.AreEqual(false, "999".EightBitNumber());
                Assert.AreEqual(false, "-1".EightBitNumber());
            }

            [Test]
            public void WhiteSpaceTests()
            {
                Assert.AreEqual(false, "1\n".EightBitNumber());
                Assert.AreEqual(false, "1 ".EightBitNumber());
                Assert.AreEqual(false, " 1".EightBitNumber());
                Assert.AreEqual(false, "1\n2".EightBitNumber());
            }

            [Test]
            public void RandomTests()
            {
                var tests = Enumerable.Range(0, 256).ToArray();
                Shuffle(tests);
                foreach (var i in tests)
                {
                    Assert.AreEqual(false, ("0" + i).EightBitNumber());
                    Assert.AreEqual(false, ("-0" + i).EightBitNumber());
                    Assert.AreEqual(true, ("" + i).EightBitNumber());
                }

            }
        }
    }
}