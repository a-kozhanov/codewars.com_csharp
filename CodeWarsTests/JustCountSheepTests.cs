using CodeWars;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    class JustCountSheepTests
    {
        [Test, Description("Example Tests")]
        public void ExampleTests()
        {
            Assert.That(JustCountSheep.CountSheep(1), Is.EqualTo("1 sheep..."));
            Assert.That(JustCountSheep.CountSheep(2), Is.EqualTo("1 sheep...2 sheep..."));
            Assert.That(JustCountSheep.CountSheep(3), Is.EqualTo("1 sheep...2 sheep...3 sheep..."));
        }
    }
}
