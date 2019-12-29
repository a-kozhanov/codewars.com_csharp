using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataGetNamesTests
    {
        private static KataGetNames.Person[] testCase = new KataGetNames.Person[]
        {
            new KataGetNames.Person("Joe", 20),
            new KataGetNames.Person("Bill", 30),
            new KataGetNames.Person("Kate", 23)
        };

        [Test, Description("Sample Test")]
        public void Test()
        {
            Assert.AreEqual(new string[] {"Joe", "Bill", "Kate"}, KataGetNames.GetNames(testCase));
        }
    }
}