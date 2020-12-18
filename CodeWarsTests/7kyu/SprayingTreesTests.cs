using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SprayingTreesTests
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[]
            {
                "Wednesday", 10, 2,
                "It is Wednesday today, Robert, you have to work, you must spray 10 trees and you need 20 dollars to buy liquid"
            },
            new object[]
            {
                "Monday", 4, 3,
                "It is Monday today, James, you have to work, you must spray 4 trees and you need 12 dollars to buy liquid"
            },
            new object[]
            {
                "Friday", 5, 4,
                "It is Friday today, William, you have to work, you must spray 5 trees and you need 20 dollars to buy liquid"
            },
            new object[]
            {
                "Tuesday", 6, 1,
                "It is Tuesday today, John, you have to work, you must spray 6 trees and you need 6 dollars to buy liquid"
            },
            new object[]
            {
                "Thursday", 5, 3,
                "It is Thursday today, Michael, you have to work, you must spray 5 trees and you need 15 dollars to buy liquid"
            },
        };

        [Test, TestCaseSource(typeof(SprayingTreesTests), "Basic_Test_Cases")]
        public void Basic_Test(string w, int n, int c, string expected)
        {
            Assert.AreEqual(expected, SprayingTrees.Task(w, n, c));
        }
    }
}