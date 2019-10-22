using System;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DecibelScaleTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1e-12).Returns(0);
                yield return new TestCaseData(1e-9).Returns(30);
                yield return new TestCaseData(1e-5).Returns(70);
                yield return new TestCaseData(10).Returns(130);
                yield return new TestCaseData(100).Returns(140);
                yield return new TestCaseData(10000).Returns(160);
                yield return new TestCaseData(2.48794569 * 1e+173).Returns(1854);
            }
        }

        [Test, TestCaseSource("testCases")]
        public double Test(double intensity) =>
            Math.Round(DecibelScale.DbScale(intensity), MidpointRounding.AwayFromZero);
    }
}
