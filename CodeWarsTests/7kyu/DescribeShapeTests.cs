using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DescribeShapeTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(6).Returns("This shape has 6 sides and each angle measures 120");
                yield return new TestCaseData(3).Returns("This shape has 3 sides and each angle measures 60");
                yield return new TestCaseData(8).Returns("This shape has 8 sides and each angle measures 135");
                yield return new TestCaseData(90).Returns("This shape has 90 sides and each angle measures 176");
                yield return new TestCaseData(2).Returns("this will be a line segment or a dot");
                yield return new TestCaseData(1).Returns("this will be a line segment or a dot");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(int angles) => DescribeShape.DescribeTheShape(angles);
    }
}