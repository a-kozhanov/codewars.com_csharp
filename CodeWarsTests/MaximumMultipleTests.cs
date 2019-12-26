using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MaximumMultipleTests
    {
        [TestCase(2, 7, 6)]
        [TestCase(3, 10, 9)]
        [TestCase(7, 17, 14)]
        public void SmallNumbers(int divisor, int bound, int ex)
        {
            Assert.That(MaximumMultiple.MaxMultiply(divisor, bound), Is.EqualTo(ex));
        }
        
        [TestCase(10, 50, 50)]
        [TestCase(37, 200, 185)]
        [TestCase(7, 100, 98)]
        public void LargeNumbers(int divisor, int bound, int ex)
        {
            Assert.That(MaximumMultiple.MaxMultiply(divisor, bound), Is.EqualTo(ex));
        }      
    }
}