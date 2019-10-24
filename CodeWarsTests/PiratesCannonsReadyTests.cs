using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PiratesCannonsReadyTests
    {
        [Test, Description("should fire the cannons when ready")]
        public void SampleAyeTest()
        {
            Dictionary<string, string> gunners = new Dictionary<string, string>
            {
                {"Mike", "aye"},
                {"Joe", "aye"},
                {"Johnson", "aye"},
                {"Peter", "aye"}
            };

            Assert.AreEqual("Fire!", PiratesCannonsReady.CannonsReady(gunners));
        }

        [Test, Description("should shiver me timbers if not ready")]
        public void SampleNayTest()
        {
            Dictionary<string, string> gunners = new Dictionary<string, string>
            {
                {"Mike", "aye"},
                {"Joe", "nay"},
                {"Johnson", "aye"},
                {"Peter", "aye"}
            };

            Assert.AreEqual("Shiver me timbers!", PiratesCannonsReady.CannonsReady(gunners));
        }
    }
}