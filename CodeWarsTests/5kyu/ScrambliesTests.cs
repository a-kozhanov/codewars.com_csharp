using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataScrambliesTests
    {
        private static void testing(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            testing(KataScramblies.Scramble("rkqodlw", "world"), true);
            testing(KataScramblies.Scramble("cedewaraaossoqqyt", "codewars"), true);
            testing(KataScramblies.Scramble("katas", "steak"), false);
            testing(KataScramblies.Scramble("scriptjavx", "javascript"), false);
            testing(KataScramblies.Scramble("scriptingjava", "javascript"), true);
            testing(KataScramblies.Scramble("scriptsjava", "javascripts"), true);
            testing(KataScramblies.Scramble("javscripts", "javascript"), false);
            testing(KataScramblies.Scramble("aabbcamaomsccdd", "commas"), true);
            testing(KataScramblies.Scramble("commas", "commas"), true);
            testing(KataScramblies.Scramble("sammoc", "commas"), true);
        }
    }
}