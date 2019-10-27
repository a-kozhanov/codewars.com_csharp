using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IsThereVowelTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(
                new object[] { 118, "u", 120, 121, "u", 98, 122, "a", 120, 106, 104, 116, 113, 114, 113, 120, 106 },
                IsThereVowel.IsVow(new object[]
                    {118, 117, 120, 121, 117, 98, 122, 97, 120, 106, 104, 116, 113, 114, 113, 120, 106}));
            Assert.AreEqual(new object[] { "e", 121, 110, 113, 113, 103, 121, 121, "e", 107, 103 },
                IsThereVowel.IsVow(new object[] { 101, 121, 110, 113, 113, 103, 121, 121, 101, 107, 103 }));
            Assert.AreEqual(new object[] { 118, 103, 110, 109, 104, 106 },
                IsThereVowel.IsVow(new object[] { 118, 103, 110, 109, 104, 106 }));
            Assert.AreEqual(new object[] { 107, 99, 110, 107, 118, 106, 112, 102 },
                IsThereVowel.IsVow(new object[] { 107, 99, 110, 107, 118, 106, 112, 102 }));
            Assert.AreEqual(new object[] { 100, 100, 116, "i", "u", 121 },
                IsThereVowel.IsVow(new object[] { 100, 100, 116, 105, 117, 121 }));
        }

        [Test]
        public void RandomTests()
        {
            var rand = new Random();
            Func<object[], object[]> myIsVow = delegate (object[] a)
            {
                return a.Select(b =>
                    (int)b == 101 ? "e" :
                    (int)b == 97 ? "a" :
                    (int)b == 117 ? "u" :
                    (int)b == 111 ? "o" :
                    (int)b == 105 ? "i" : b).ToArray();
            };

            for (var i = 0; i < 40; i++)
            {
                var len = rand.Next(1, 20);

                var s = Enumerable.Range(0, len).Select(a => rand.Next(97, 123)).Cast<object>().ToArray();

                Assert.AreEqual(myIsVow(s), IsThereVowel.IsVow(s), "It should work for random inputs too");
            }
        }
    }
}