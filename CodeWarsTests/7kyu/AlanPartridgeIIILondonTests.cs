using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AlanPartridgeIIILondonTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Smell my cheese you mother!",
                AlanPartridgeIIILondon.Alan(new string[]
                {
                    "Norwich", "Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway",
                    "London"
                }));

            Assert.AreEqual("No, seriously, run. You will miss it.",
                AlanPartridgeIIILondon.Alan(new string[] {"London", "Norwich"}));

            Assert.AreEqual("Smell my cheese you mother!",
                AlanPartridgeIIILondon.Alan(new string[]
                {
                    "Norwich", "Tooting", "Bank", "Rejection", "Disappointment", "Backstabbing Central", "Exeter",
                    "Shattered Dreams Parkway", "Belgium", "London"
                }));
        }
    }
}