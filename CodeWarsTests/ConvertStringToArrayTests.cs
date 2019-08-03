using CodeWars;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsTests
{
    [TestFixture]
    class ConvertStringToArrayTests
    {
        [Test]
        public void _1_Example()
        {
            Assert.AreEqual(new string[] { "Robin", "Singh" }, ConvertStringToArray.StringToArray("Robin Singh"));
        }

        [Test]
        public void _2_Example()
        {
            Assert.AreEqual(new string[] { "I", "love", "arrays", "they", "are", "my", "favorite" }, ConvertStringToArray.StringToArray("I love arrays they are my favorite"));
        }
    }
}
