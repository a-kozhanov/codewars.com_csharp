using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataKnightVsRookTests
    {
        [Test]
        public void KnightTest()
        {
            object[] rookPosition = {4, "C"};
            object[] knightPosition = {6, "D"};
            StringAssert.AreEqualIgnoringCase("Knight", KataKnightVsRook.KnightVsRook(knightPosition, rookPosition));
        }

        [Test]
        public void RookTest()
        {
            object[] rookPosition = {2, "G"};
            object[] knightPosition = {2, "B"};
            StringAssert.AreEqualIgnoringCase("Rook", KataKnightVsRook.KnightVsRook(knightPosition, rookPosition));
        }

        [Test]
        public void NoneTest()
        {
            object[] rookPosition = {2, "F"};
            object[] knightPosition = {7, "B"};
            StringAssert.AreEqualIgnoringCase("None", KataKnightVsRook.KnightVsRook(knightPosition, rookPosition));
        }
    }
}