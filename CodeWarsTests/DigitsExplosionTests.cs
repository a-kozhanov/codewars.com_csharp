using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DigitsExplosionTests
    {
        [TestCase("312", "333122")]
        [TestCase("102269", "12222666666999999999")]
        public static void ExplodeTests(string s, string result)
        {
            Assert.AreEqual(result, DigitsExplosion.Explode(s));
        }
    }
}