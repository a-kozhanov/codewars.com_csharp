using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    public class Debug
    {
        public static string DictionaryToJson(Dictionary<char, int> dict)
        {
            IEnumerable<string> entries = dict.OrderBy(x => (int)x.Key).Select(d =>
                String.Format("\"{0}\": [{1}]", d.Key, string.Join(",", d.Value)));
            return "{" + String.Join(",", entries) + "}";
        }
    }

    [TestFixture]
    public class CharacterFrequencyTests
    {
        [Test]
        public void Test()
        {
            Dictionary<char, int> expected = new Dictionary<char, int> { { 'a', 1 }, { ' ', 2 }, { 'c', 1 }, { 'e', 1 }, { 'I', 1 }, { 'k', 1 }, { 'l', 1 }, { 'i', 1 }, { 's', 1 }, { 't', 1 } };
            Dictionary<char, int> actual = CharacterFrequency.CharFreq("I like cats");

            Assert.AreEqual(expected, actual, String.Format("Expected: {0}\n  Actual: {1}", Debug.DictionaryToJson(expected), Debug.DictionaryToJson(actual)));
        }
    }
}