using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConvertStringToCamelCaseTests
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("theStealthWarrior", ConvertStringToCamelCase.ToCamelCase("the_stealth_warrior"),
                "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");

            Assert.AreEqual("TheStealthWarrior", ConvertStringToCamelCase.ToCamelCase("The-Stealth-Warrior"),
                "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }
    }
}