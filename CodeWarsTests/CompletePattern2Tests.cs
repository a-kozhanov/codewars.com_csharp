using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CompletePattern2Tests
    {
        CompletePattern2 k = new CompletePattern2();

        [Test]
        public void SimpleNumbers()
        {
            Assert.AreEqual("1", k.Pattern(1));
            Assert.AreEqual("21\n2", k.Pattern(2));
            Assert.AreEqual("54321\n5432\n543\n54\n5", k.Pattern(5));
        }

        [Test]
        public void ZeroAndNegativeNumbers()
        {
            Assert.AreEqual("", k.Pattern(0));
            Assert.AreEqual("", k.Pattern(-25));
            Assert.AreEqual("", k.Pattern(-99));
        }

        [Test]
        public void RandomGeneratedNumbers()
        {
            Random r = new Random();
            for (var i = 0; i < 20; i++)
            {
                var n = r.Next(100);
                Assert.AreEqual(SPattern(n), k.Pattern(n));
            }
        }

        public string SPattern(int n)
        {
            var output = "";
            for (var i = 0; i < n; i++)
            {
                for (var a = n; a > i; a--)
                {
                    output += a;
                }

                output += "\n";
            }

            return output.TrimEnd('\n');
        }
    }
}