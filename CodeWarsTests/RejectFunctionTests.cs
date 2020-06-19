using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RejectFunctionTests
    {
        [Test, Description("Sample Test")]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] {1, 3, 5},
                RejectFunction.Reject(new int[] {1, 2, 3, 4, 5, 6}, (n) => n % 2 == 0));
        }
    }
}