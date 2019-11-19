using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExclusiveOrXorLogicalOperatorTests
    {
        [Test]
        public void BasicTests()
        {
            testing(ExclusiveOrXorLogicalOperator.Xor(false, false), false);
            testing(ExclusiveOrXorLogicalOperator.Xor(true, false), true);
            testing(ExclusiveOrXorLogicalOperator.Xor(false, true), true);
            testing(ExclusiveOrXorLogicalOperator.Xor(true, true), false);
        }

        [Test]
        public void NestedTests()
        {
            testing(ExclusiveOrXorLogicalOperator.Xor(false, ExclusiveOrXorLogicalOperator.Xor(false, false)), false);
            testing(ExclusiveOrXorLogicalOperator.Xor(ExclusiveOrXorLogicalOperator.Xor(true, false), false), true);
            testing(ExclusiveOrXorLogicalOperator.Xor(ExclusiveOrXorLogicalOperator.Xor(true, true), false), false);
            testing(ExclusiveOrXorLogicalOperator.Xor(true, ExclusiveOrXorLogicalOperator.Xor(true, true)), true);
            testing(ExclusiveOrXorLogicalOperator.Xor(ExclusiveOrXorLogicalOperator.Xor(false, false), ExclusiveOrXorLogicalOperator.Xor(false, false)), false);
            testing(ExclusiveOrXorLogicalOperator.Xor(ExclusiveOrXorLogicalOperator.Xor(false, false), ExclusiveOrXorLogicalOperator.Xor(false, true)), true);
            testing(ExclusiveOrXorLogicalOperator.Xor(ExclusiveOrXorLogicalOperator.Xor(true, false), ExclusiveOrXorLogicalOperator.Xor(false, false)), true);
            testing(ExclusiveOrXorLogicalOperator.Xor(ExclusiveOrXorLogicalOperator.Xor(true, false), ExclusiveOrXorLogicalOperator.Xor(true, false)), false);
            testing(ExclusiveOrXorLogicalOperator.Xor(ExclusiveOrXorLogicalOperator.Xor(true, true), ExclusiveOrXorLogicalOperator.Xor(true, false)), true);
            testing(ExclusiveOrXorLogicalOperator.Xor(ExclusiveOrXorLogicalOperator.Xor(true, ExclusiveOrXorLogicalOperator.Xor(true, true)), ExclusiveOrXorLogicalOperator.Xor(ExclusiveOrXorLogicalOperator.Xor(true, true), false)), true);
        }

        private static void testing(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}