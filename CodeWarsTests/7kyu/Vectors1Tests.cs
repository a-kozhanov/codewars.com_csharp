using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Vectors1Tests
    {
        [Test]
        [TestCase(0, 2, 0, ExpectedResult = 2)]
        [TestCase(1, 2, 2, ExpectedResult = 3)]
        public static double FixedTest(double x, double y, double z)
        {
            return new Vectors1()
            {
                X = x,
                Y = y,
                Z = z
            }.Length;
        }
    }
}