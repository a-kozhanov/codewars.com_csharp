using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BuildingStringsFromHashTests
    {
        [Test, Description("Basic Tests")]
        public void Test()
        {
            Assert.AreEqual("a = 1,b = 2",
                BuildingStringsFromHash.StringifyDict(new Dictionary<char, int> {{'a', 1}, {'b', 2}}));

            Assert.AreEqual("b = 1,c = 2,e = 3",
                BuildingStringsFromHash.StringifyDict(new Dictionary<char, int> {{'b', 1}, {'c', 2}, {'e', 3}}));

            Assert.AreEqual("", BuildingStringsFromHash.StringifyDict(new Dictionary<char, int>()));
        }
    }
}