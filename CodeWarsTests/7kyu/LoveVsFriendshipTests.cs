using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LoveVsFriendshipTests
    {
        public static TestCaseData[] testCases = new TestCaseData[]
        {
            new TestCaseData("attitude").Returns(100).SetDescription("Input: \"attitude\"\n      Expected: 100"),
            new TestCaseData("friends").Returns(75).SetDescription("Input: \"friends\"\n      Expected: 75"),
            new TestCaseData("family").Returns(66).SetDescription("Input: \"family\"\n      Expected: 66"),
            new TestCaseData("selfness").Returns(99).SetDescription("Input: \"selfness\"\n      Expected: 99"),
            new TestCaseData("knowledge").Returns(96).SetDescription("Input: \"knowledge\"\n      Expected: 96"),
        };

        [Test, TestCaseSource("testCases")]
        public int Test(string str) => LoveVsFriendship.WordsToMarks(str);
    }
}