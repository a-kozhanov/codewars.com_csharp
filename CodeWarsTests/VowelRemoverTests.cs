using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class VowelRemoverTests
    {
        [Test]
        public void Test1()
        {
            Assert("hello", "hll");
            Assert("how are you today?", "hw r y tdy?");
            Assert("complain", "cmpln");
            Assert("never", "nvr");
        }

        private static void Assert(string input, string expected)
        {
            var result = VowelRemover.Shortcut(input);
            NUnit.Framework.Assert.AreEqual(expected, result, String.Format("Expected \"{0}\" but got \"{1}\"", expected, result));
        }
    }
}