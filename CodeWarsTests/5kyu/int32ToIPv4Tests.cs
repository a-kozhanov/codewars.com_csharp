using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class int32ToIPv4Tests
    {
        [TestFixture]
        public class Sample_Test
        {
            [Test, Description("Sample Tests")]
            public void Test()
            {
                Assert.AreEqual("128.114.17.104", int32ToIPv4.UInt32ToIP(2154959208));
                Assert.AreEqual("0.0.0.0", int32ToIPv4.UInt32ToIP(0));
                Assert.AreEqual("128.32.10.1", int32ToIPv4.UInt32ToIP(2149583361));
            }
        }
    }
}