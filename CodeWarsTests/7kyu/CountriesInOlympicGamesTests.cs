using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CountriesInOlympicGamesTests
    {
        [Test]
        public void FirstTest()
        {
            Dictionary<string, string> list = new Dictionary<string, string>()
            {
                {"China", "54,32,45"},
                {"Korea", "55,32,45"},
                {"Iran", "54,33,45"},
                {"Iraq", "54,32,46"},
                {"Chinb", "54,32,45"},
                {"Ahina", "54,32,45"}
            };
            string result = "Korea-Iran-Iraq-Ahina-China-Chinb";
            StringAssert.AreEqualIgnoringCase(result, CountriesInOlympicGames.OrderCountries(list));
        }

        [Test]
        public void SecondTest()
        {
            Dictionary<string, string> list = new Dictionary<string, string>()
            {
                {"China", "54,32,44"},
                {"Korea", "55,33,45"},
                {"Iraq", "54,33,45"},
                {"Iran", "54,33,45"},
                {"Norway", "56,32,45"},
                {"Finland", "55,34,45"}
            };
            string result = "Norway-Finland-Korea-Iran-Iraq-China";
            StringAssert.AreEqualIgnoringCase(result, CountriesInOlympicGames.OrderCountries(list));
        }

        [Test]
        public void ThirdTest()
        {
            Dictionary<string, string> list = new Dictionary<string, string>()
            {
                {"China", "54,32,44"},
                {"Korea", "550,33,45"},
                {"Iraq", "54,33,45"},
                {"Iran", "54,33,45"},
                {"Norway", "56,32,45"},
                {"Finland", "55,34,45"}
            };
            string result = "Korea-Norway-Finland-Iran-Iraq-China";
            StringAssert.AreEqualIgnoringCase(result, CountriesInOlympicGames.OrderCountries(list));
        }
    }
}