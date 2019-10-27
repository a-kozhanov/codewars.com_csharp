using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperGradeBookTests
    {
        [Test]
        [TestCase(95, 90, 93, ExpectedResult = 'A')]
        [TestCase(70, 70, 100, ExpectedResult = 'B')]
        [TestCase(70, 71, 72, ExpectedResult = 'C')]
        [TestCase(65, 66, 60, ExpectedResult = 'D')]
        [TestCase(32, 15, 21, ExpectedResult = 'F')]
        public static char FixedTests(int n1, int n2, int n3)
        {
            return GrasshopperGradeBook.GetGrade(n1, n2, n3);
        }

        [Test]
        [TestCase(100, 100, 100, ExpectedResult = 'A')]
        [TestCase(90, 90, 90, ExpectedResult = 'A')]
        [TestCase(89, 89, 89, ExpectedResult = 'B')]
        [TestCase(80, 80, 80, ExpectedResult = 'B')]
        [TestCase(79, 79, 79, ExpectedResult = 'C')]
        [TestCase(70, 70, 70, ExpectedResult = 'C')]
        [TestCase(69, 69, 69, ExpectedResult = 'D')]
        [TestCase(60, 60, 60, ExpectedResult = 'D')]
        [TestCase(59, 59, 59, ExpectedResult = 'F')]
        [TestCase(0, 0, 0, ExpectedResult = 'F')]
        public static char SpecialTests(int n1, int n2, int n3)
        {
            return GrasshopperGradeBook.GetGrade(n1, n2, n3);
        }

        [Test]
        public static void RandomTests(
            [Random(0, 100, 10)] int n1,
            [Random(0, 100, 10)] int n2,
            [Random(0, 100, 10)] int n3
        )
        {
            Assert.AreEqual(Solution(n1, n2, n3), GrasshopperGradeBook.GetGrade(n1, n2, n3), String.Format("Should work for {0}, {1}, {2}", n1, n2, n3));
        }

        private static char Solution(int s1, int s2, int s3)
        {
            int avg = (s1 + s2 + s3) / 3;
            if (avg < 60) return 'F';
            if (avg < 70) return 'D';
            if (avg < 80) return 'C';
            if (avg < 90) return 'B';
            return 'A';
        }
    }
}