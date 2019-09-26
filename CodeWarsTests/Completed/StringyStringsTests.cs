using CodeWars;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    class StringyStringsTests
    {
        [Test]
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "10")]
        [TestCase(10, ExpectedResult = "1010101010")]
        public static string FixedTest(int size)
        {
            return StringyStrings.Stringy(size);
        }
    }
}
