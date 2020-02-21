using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Testing123Tests
    {
        [TestCase]
        public void basicTests()
        {
            Assert.AreEqual(new List<string>(), Testing123.Number(new List<string>()));

            Assert.AreEqual(new List<string> {"1: a", "2: b", "3: c"},
                Testing123.Number(new List<string> {"a", "b", "c"}));

            Assert.AreEqual(new List<string> {"1: ", "2: ", "3: ", "4: ", "5: "},
                Testing123.Number(new List<string> {"", "", "", "", ""}));
        }
    }
}