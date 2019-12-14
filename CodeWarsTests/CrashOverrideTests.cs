using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CrashOverrideTests
    {
        [Test]
        public void BasicTest()
        {
            Dictionary<string[], string> bisics = new Dictionary<string[], string>()
            {
                {new []{"Mike", "Millington"},  "Malware Mike"},
                {new []{"Fahima", "Tash"},"Function T-Rex"},
                {new []{"Daisy", "Petrovic"},"Data Payload"},
                {new []{"Barny", "White"},"Beta Worm"},
                {new []{"Hank", "Kutz"},"Half-life Killer"},
                {new []{"123abc", "Pinkman"},"Your name must start with a letter from A - Z."}
            };
            foreach (KeyValuePair<string[], string> keyValuePair in bisics)
            {
                StringAssert.AreEqualIgnoringCase(keyValuePair.Value, CrashOverride.AliasGen(keyValuePair.Key[0], keyValuePair.Key[1]));
            }
        }
    }
}