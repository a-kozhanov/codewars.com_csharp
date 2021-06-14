using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataKnightVsKingTests
    {
        [Test]
        public void KnightTest()
        {
            object[] kingPosition = {4, "C"};
            object[] knightPosition = {6, "D"};
            StringAssert.AreEqualIgnoringCase("Knight", KataKnightVsKing.KnightVsKing(knightPosition, kingPosition));
        }

        [Test]
        public void KingTest()
        {
            object[] kingPosition = {7, "B"};
            object[] knightPosition = {6, "C"};
            StringAssert.AreEqualIgnoringCase("King", KataKnightVsKing.KnightVsKing(knightPosition, kingPosition));
        }

        [Test]
        public void NoneTest()
        {
            object[] kingPosition = {2, "F"};
            object[] knightPosition = {6, "B"};
            StringAssert.AreEqualIgnoringCase("None", KataKnightVsKing.KnightVsKing(knightPosition, kingPosition));
        }
    }
}