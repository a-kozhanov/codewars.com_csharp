using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataExampleTwistTests
    {
        [Test]
        public static void Tests()
        {
            Assert.AreEqual(KataExampleTwist.Websites.Length, 1000);
            Assert.AreEqual(KataExampleTwist.Websites.GetType().GetElementType(), typeof(System.String));
            Assert.That(Array.TrueForAll(KataExampleTwist.Websites, (v) => v == "codewars"));
        }
    }
}