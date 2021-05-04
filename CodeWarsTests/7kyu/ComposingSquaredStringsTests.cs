using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ComposingSquaredStringsTests
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Fixed Tests compose");

            testing(ComposingSquaredStrings.Compose("byGt\nhTts\nRTFF\nCnnI", "jIRl\nViBu\nrWOb\nNkTB"),
                "bNkTB\nhTrWO\nRTFVi\nCnnIj");

            testing(ComposingSquaredStrings.Compose("HXxA\nTGBf\nIPhg\nuUMD", "Hcbj\nqteH\nGbMJ\ngYPW"),
                "HgYPW\nTGGbM\nIPhqt\nuUMDH");

            testing(ComposingSquaredStrings.Compose("tSrJ\nOONy\nsqPF\nxMkB", "hLqw\nEZuh\nmYFl\nzlYf"),
                "tzlYf\nOOmYF\nsqPEZ\nxMkBh");
        }
    }
}