using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HarvestFestivalTests
    {
        private static void Act(char seed, int water, int fert, int temp, string expected)
        {
            var msg = $"Invalid answer for input: seed='{seed}', water={water}, fert={fert}, temp={temp}";
            var actual = HarvestFestival.Plant(seed, water, fert, temp);
            Assert.AreEqual(expected, actual, msg);
        }

        [TestCase('@', 4, 3, 23, "----@@@----@@@----@@@----@@@")]
        [TestCase('~', 1, 6, 30, "-~~~~~~")]
        [TestCase('#', 10, 2, 15,
            "----------------------------------------------------------------------------------------------------#")]
        [TestCase('*', 2, 4, 8, "----*")]
        [TestCase('<', 2, 2, 28, "--<<--<<")]
        public void SampleTests(char seed, int water, int fert, int temp, string expected)
        {
            Act(seed, water, fert, temp, expected);
        }
    }
}