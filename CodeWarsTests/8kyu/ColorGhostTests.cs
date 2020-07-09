using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ColorGhostTests
    {
        private Dictionary<string, string> GhostColors = new Dictionary<string, string>();

        public ColorGhostTests()
        {
            for (int i = 0; i < 10000; i++)
            {
                string c = new ColorGhost().GetColor();
                if (!GhostColors.ContainsKey(c))
                {
                    GhostColors.Add(c, "");
                }
            }
        }

        private bool GhostColor(Dictionary<string, string> arr, string c)
        {
            return arr.ContainsKey(c);
        }

        [Test]
        public void ShouldSometimesMakeWhiteGhosts()
        {
            Assert.AreEqual(true, GhostColor(GhostColors, "white"));
        }

        [Test]
        public void ShouldSometimesMakeYellowGhosts()
        {
            Assert.AreEqual(true, GhostColor(GhostColors, "yellow"));
        }

        [Test]
        public void ShouldSometimesMakePurpleGhosts()
        {
            Assert.AreEqual(true, GhostColor(GhostColors, "purple"));
        }

        [Test]
        public void ShouldSometimesMakeRedGhosts()
        {
            Assert.AreEqual(true, GhostColor(GhostColors, "red"));
        }
    }
}