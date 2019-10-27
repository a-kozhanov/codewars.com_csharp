using System;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConvertNumberToStringTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(67).Returns("67");
                yield return new TestCaseData(79585).Returns("79585");
                yield return new TestCaseData(1 + 2).Returns("3");
                yield return new TestCaseData(1 - 2).Returns("-1");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(int num) => ConvertNumberToString.NumberToString(num);

        private static Random rnd = new Random();

        [Test]
        public void RandomTests()
        {
            for (int i = 0; i < 100; ++i)
            {
                int num = rnd.Next(-1000, 1001);
                Assert.AreEqual("" + num, ConvertNumberToString.NumberToString(num));
            }
        }
    }
}