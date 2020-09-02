using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WhereMyAnagramsAtTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new List<string> {"a"},
                WhereMyAnagramsAt.Anagrams("a", new List<string> {"a", "b", "c", "d"}));
            
            Assert.AreEqual(new List<string> {"carer", "arcre", "carre"},
                WhereMyAnagramsAt.Anagrams("racer",
                    new List<string>
                        {"carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr"}));
        }
    }
}