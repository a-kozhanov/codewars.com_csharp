using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AreaOfSquareTests
    {
        private static double[][] testCases = new double[][]
        {
            new double[] {2, 1.62},
            new double[] {0, 0},
            new double[] {14.05, 80},
        };

        [Test, TestCaseSource("testCases")]
        public void SampleTest(double A, double expected)
        {
            Assert.AreEqual(expected, AreaOfSquare.SquareArea(A));
        }
    }
}