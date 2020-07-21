using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StopGninnipSMySdroWTests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", StopGninnipSMySdroW.SpinWords("Welcome"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", StopGninnipSMySdroW.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", StopGninnipSMySdroW.SpinWords("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", StopGninnipSMySdroW.SpinWords("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test",
                StopGninnipSMySdroW.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more",
                StopGninnipSMySdroW.SpinWords("Just kidding there is still one more"));
        }
    }
}