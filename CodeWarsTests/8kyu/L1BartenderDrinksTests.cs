using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class L1BartenderDrinksTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Patron Tequila", L1BartenderDrinks.GetDrinkByProfession("jabrOni"), "'Jabroni' should map to 'Patron Tequila'");
            Assert.AreEqual("Anything with Alcohol", L1BartenderDrinks.GetDrinkByProfession("scHOOl counselor"), "'School Counselor' should map to 'Anything with alcohol'");
            Assert.AreEqual("Hipster Craft Beer", L1BartenderDrinks.GetDrinkByProfession("prOgramMer"), "'Programmer' should map to 'Hipster Craft Beer'");
            Assert.AreEqual("Moonshine", L1BartenderDrinks.GetDrinkByProfession("bike ganG member"), "'Bike Gang Member' should map to 'Moonshine'");
            Assert.AreEqual("Your tax dollars", L1BartenderDrinks.GetDrinkByProfession("poLiTiCian"), "'Politician' should map to 'Your tax dollars'");
            Assert.AreEqual("Cristal", L1BartenderDrinks.GetDrinkByProfession("rapper"), "'Rapper' should map to 'Cristal'");
            Assert.AreEqual("Beer", L1BartenderDrinks.GetDrinkByProfession("pundit"), "'Pundit' should map to 'Beer'");
            Assert.AreEqual("Beer", L1BartenderDrinks.GetDrinkByProfession("Pug"), "'Pug' should map to 'Beer'");
        }
    }
}