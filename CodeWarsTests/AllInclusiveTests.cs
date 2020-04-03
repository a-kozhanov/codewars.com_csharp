using System;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AllInclusiveTests
    {
        private static void testing(Boolean actual, Boolean expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests ContainAllRots");

            List<string> a = new List<string>() {"bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs"};
            testing(AllInclusive.ContainAllRots("bsjq", a), true);

            a = new List<string>() { };
            testing(AllInclusive.ContainAllRots("", a), true);

            a = new List<string>() {"bsjq", "qbsj"};
            testing(AllInclusive.ContainAllRots("", a), true);

            a = new List<string>()
                {"TzYxlgfnhf", "yqVAuoLjMLy", "BhRXjYA", "YABhRXj", "hRXjYAB", "jYABhRX", "XjYABhR", "ABhRXjY"};
            testing(AllInclusive.ContainAllRots("XjYABhR", a), false);
        }
    }
}