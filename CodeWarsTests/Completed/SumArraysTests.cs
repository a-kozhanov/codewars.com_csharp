using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    class SumArraysTests
    {
        private static object[] testCases = new object[]
{
      new object[] {new double[] {1, 5.2, 4, 0, -1}, 9.2},
      new object[] {new double[] {}, 0},
};

        [Test, TestCaseSource("testCases")]
        public void Test(double[] array, double expected) => Assert.AreEqual(expected, KataSumArrays.SumArray(array));
    }
}
