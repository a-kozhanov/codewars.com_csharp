using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CouponCodeTests
    {
        [Test]
        public static void ValidCoupon()
        {
            Assert.AreEqual(true, CouponCode.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
        }

        [Test]
        public static void InvalidCoupon()
        {
            Assert.AreEqual(false, CouponCode.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"));
        }
    }
}