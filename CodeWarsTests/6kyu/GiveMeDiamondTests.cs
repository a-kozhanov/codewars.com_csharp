using System;
using System.Collections.Generic;
using System.Text;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    class GiveMeDiamondTests
    {
        [Test]
        public void TestNull()
        {
            Assert.IsNull(GiveMeDiamond.print(0));
            Assert.IsNull(GiveMeDiamond.print(-2));
            Assert.IsNull(GiveMeDiamond.print(2));
        }

        [Test]
        public void TestDiamond1()
        {
            var expected = new StringBuilder();
            expected.Append("*\n");
            Assert.AreEqual(expected.ToString(), GiveMeDiamond.print(1));
        }

        [Test]
        public void TestDiamond3()
        {
            var expected = new StringBuilder();
            expected.Append(" *\n");
            expected.Append("***\n");
            expected.Append(" *\n");

            Assert.AreEqual(expected.ToString(), GiveMeDiamond.print(3));
        }

        [Test]
        public void TestDiamond5()
        {
            var expected = new StringBuilder();
            expected.Append("  *\n");
            expected.Append(" ***\n");
            expected.Append("*****\n");
            expected.Append(" ***\n");
            expected.Append("  *\n");

            Assert.AreEqual(expected.ToString(), GiveMeDiamond.print(5));
        }

    }
}
