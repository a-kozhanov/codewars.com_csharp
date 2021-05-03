using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CollisionDetectionTests
    {
        [Test, Description("Sample Tests")]
        public void Sample_Tests()
        {
            Assert.AreEqual(true, CollisionDetection.Collision(1, 1, 1, 1.1, 1.1, 0.1));
            Assert.AreEqual(true, CollisionDetection.Collision(1.1, 3.3, 0.9, 1.6, 1.9, 4.35));
            Assert.AreEqual(true, CollisionDetection.Collision(0, 0, 1, 2, 2, 2 * Math.Sqrt(2) - 1));
            Assert.AreEqual(false, CollisionDetection.Collision(0, 1.7, 0.36, 2.1, 2, 0.8));
            Assert.AreEqual(false, CollisionDetection.Collision(-4.7, -2.6, 1.4, -9.6, -7.5, 0.4));
            Assert.AreEqual(false, CollisionDetection.Collision(-5, 5, 5.0001, 5, -5, 4 * Math.Sqrt(5)));
        }
    }
}