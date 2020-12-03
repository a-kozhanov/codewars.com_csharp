using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ScalingSquaredStringsTests
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Fixed Tests scale");
            String a = "abcd\nefgh\nijkl\nmnop";
            String r = "aabbccdd\naabbccdd\naabbccdd\neeffgghh\neeffgghh\neeffgghh\niijjkkll\n"
                       + "iijjkkll\niijjkkll\nmmnnoopp\nmmnnoopp\nmmnnoopp";
            testing(ScalingSquaredStrings.Scale(a, 2, 3), r);
            testing(ScalingSquaredStrings.Scale("", 5, 5), "");
            testing(ScalingSquaredStrings.Scale("Kj\nSH", 1, 2), "Kj\nKj\nSH\nSH");
        }
    }
}