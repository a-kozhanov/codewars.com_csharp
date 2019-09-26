using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    class GenerateRangeIntegersTests
    {
        [Test]
        [TestCase(2, 10, 2, ExpectedResult = new int[] { 2, 4, 6, 8, 10 })] //1, 3, 5, 7, 9
        public static int[] FixedTest(int min, int max, int step)
        {
            return GenerateRangeIntegers.GenerateRange(min, max, step);
        }
    }
}
