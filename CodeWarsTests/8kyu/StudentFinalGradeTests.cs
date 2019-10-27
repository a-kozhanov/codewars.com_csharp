using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StudentFinalGradeTests
    {
        [Test]
        public void Basic()
        {
            Assert.AreEqual(100, StudentFinalGrade.FinalGrade(100, 12));
            Assert.AreEqual(90, StudentFinalGrade.FinalGrade(85, 5));
        }


        private int solution(int a, int b)
        {
            if (a > 90 || b > 10) return 100;
            if (a > 75 && b >= 5) return 90;
            if (a > 50 && b >= 2) return 75;
            return 0;
        }

        [Test]
        public void FinalGradeTest()
        {
            //       Assert.AreEqual(100, Kata.FinalGrade(100, 12));
            //       Assert.AreEqual(90, Kata.FinalGrade(85, 5));
            //       Assert.AreEqual(100, Kata.FinalGrade(99, 0));
            //       Assert.AreEqual(100, Kata.FinalGrade(10, 15));
            //       Assert.AreEqual(90, Kata.FinalGrade(85, 5));
            //       Assert.AreEqual(75, Kata.FinalGrade(55, 3));
            //       Assert.AreEqual(0, Kata.FinalGrade(55, 0));
            //       Assert.AreEqual(0, Kata.FinalGrade(20, 2));
            for (int e = 0; e <= 100; e++)
                for (int p = 0; p <= 11; p++)
                    Assert.AreEqual(solution(e, p), StudentFinalGrade.FinalGrade(e, p),
                        $"exam = {e}, projects = {p}");

            Random rnd = new Random();
            for (var i = 0; i < 100; i++)
            {
                var a = rnd.Next(0, 100);
                var b = rnd.Next(0, 20);
                Assert.AreEqual(solution(a, b), StudentFinalGrade.FinalGrade(a, b));
            }
        }

    }
}