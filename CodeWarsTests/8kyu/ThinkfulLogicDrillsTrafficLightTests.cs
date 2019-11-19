using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkfulLogicDrillsTrafficLightTests
    {
        [TestCase("green", "yellow")]
        [TestCase("yellow", "red")]
        [TestCase("red", "green")]
        public void BasicTests(string s, string expected)
        {
            Assert.That(ThinkfulLogicDrillsTrafficLight.UpdateLight(s), Is.EqualTo(expected));
        }
    }
}