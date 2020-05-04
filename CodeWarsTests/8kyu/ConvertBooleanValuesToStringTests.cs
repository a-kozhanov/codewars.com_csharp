using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConvertBooleanValuesToStringTests
    {
        [Test]
        public void boolToWordReturned1()
        {
            Assert.AreEqual("Yes", ConvertBooleanValuesToString.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }

        [Test]
        public void boolToWordReturned2()
        {
            Assert.AreEqual("No", ConvertBooleanValuesToString.boolToWord(false));
            Console.WriteLine("Expected No");
        }

        [Test]
        public void boolToWordReturned3()
        {
            Assert.AreEqual("Yes", ConvertBooleanValuesToString.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }
    }
}