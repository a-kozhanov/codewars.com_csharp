using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TakeDerivativeTests
    {

        private static object[] Basic_Test_Cases = new object[]
        {
            new object[] {7, 8, "56x^7"},
            new object[] {5, 9, "45x^8"},
        };

        [Test, TestCaseSource(typeof(TakeDerivativeTests), "Basic_Test_Cases")]
        public void Basic_Test(double coefficient, double exponent, string expected)
        {
            Assert.AreEqual(expected, TakeDerivative.Derive(coefficient, exponent));
        }
    }
}