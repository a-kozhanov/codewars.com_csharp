using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataAreaOrPerimeterTests
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(KataAreaOrPerimeter.AreaOrPerimeter(4, 4), 16);
            Assert.AreEqual(KataAreaOrPerimeter.AreaOrPerimeter(6, 12), 36);
            Assert.AreEqual(KataAreaOrPerimeter.AreaOrPerimeter(5, 4), 18);
            Assert.AreEqual(KataAreaOrPerimeter.AreaOrPerimeter(72, 100), 344);
        }

        [Test]
        public void RandomTest()
        {
            for (int i = 0; i < 100; i++)
            {
                Random rnd = new Random();
                int A = rnd.Next(i, 130);
                int B = rnd.Next(i, 130);
                Assert.AreEqual(KataAreaOrPerimeter.AreaOrPerimeter(A, B), A == B ? A * B : 2 * (A + B));
            }
        }
    }
}