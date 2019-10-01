using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DrinkAboutTests
    {
        [Test]
        [TestCase(22, ExpectedResult = "drink whisky")]
        [TestCase(0, ExpectedResult = "drink toddy")]
        [TestCase(13, ExpectedResult = "drink toddy")]
        [TestCase(14, ExpectedResult = "drink coke")]
        [TestCase(15, ExpectedResult = "drink coke")]
        [TestCase(20, ExpectedResult = "drink beer")]
        [TestCase(21, ExpectedResult = "drink whisky")]
        public static string FixedTest(int old)
        {
            return DrinkAbout.PeopleWithAgeDrink(old);
        }

        [Test]
        public static void RandomTest([Random(0, 30, 100)]int old)
        {
            Assert.AreEqual(Solution(old), DrinkAbout.PeopleWithAgeDrink(old), string.Format("Should work for {0}", old));
        }

        private static string Solution(int old)
        {
            if (old < 14) return "drink toddy";
            if (old < 18) return "drink coke";
            if (old < 21) return "drink beer";
            return "drink whisky";
        }




    }
}