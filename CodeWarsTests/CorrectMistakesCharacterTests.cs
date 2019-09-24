using CodeWars;
using NUnit.Framework;
using System;
using System.Text;

namespace CodeWarsTests
{
    [TestFixture]
    class CorrectMistakesCharacterTests
    {
        [Test]
        public void CorrectTests()
        {
            Assert.AreEqual("LONDON", CorrectMistakesCharacter.Correct("L0ND0N"));
            Assert.AreEqual("DUBLIN", CorrectMistakesCharacter.Correct("DUBL1N"));
            Assert.AreEqual("SINGAPORE", CorrectMistakesCharacter.Correct("51NGAP0RE"));
            Assert.AreEqual("BUDAPEST", CorrectMistakesCharacter.Correct("BUDAPE5T"));
            Assert.AreEqual("PARIS", CorrectMistakesCharacter.Correct("PAR15"));
        }

        [Test]
        public void MoreTestCases()
        {
            Assert.AreEqual("IF-RUDYARD KIPLING", CorrectMistakesCharacter.Correct("1F-RUDYARD K1PL1NG"));
            Assert.AreEqual("ROBERT MERLE - THE DAY OF THE DOLPHIN", CorrectMistakesCharacter.Correct("R0BERT MERLE - THE DAY 0F THE D0LPH1N"));
            Assert.AreEqual("RICHARD P. FEYNMAN - THE FEYNMAN LECTURES ON PHYSICS", CorrectMistakesCharacter.Correct("R1CHARD P. FEYNMAN - THE FEYNMAN LECTURE5 0N PHY51C5"));
            Assert.AreEqual("RICHARD P. FEYNMAN - STATISTICAL MECHANICS", CorrectMistakesCharacter.Correct("R1CHARD P. FEYNMAN - 5TAT15T1CAL MECHAN1C5"));
            Assert.AreEqual("STEPHEN HAWKING - A BRIEF HISTORY OF TIME", CorrectMistakesCharacter.Correct("5TEPHEN HAWK1NG - A BR1EF H15T0RY 0F T1ME"));
            Assert.AreEqual("STEPHEN HAWKING - THE UNIVERSE IN A NUTSHELL", CorrectMistakesCharacter.Correct("5TEPHEN HAWK1NG - THE UN1VER5E 1N A NUT5HELL"));
            Assert.AreEqual("ERNEST HEMINGWAY - A FARWELL TO ARMS", CorrectMistakesCharacter.Correct("ERNE5T HEM1NGWAY - A FARWELL T0 ARM5"));
            Assert.AreEqual("ERNEST HEMINGWAY - FOR WHOM THE BELL TOLLS", CorrectMistakesCharacter.Correct("ERNE5T HEM1NGWAY - F0R WH0M THE BELL T0LL5"));
            Assert.AreEqual("ERNEST HEMINGWAY - THE OLD MAN AND THE SEA", CorrectMistakesCharacter.Correct("ERNE5T HEM1NGWAY - THE 0LD MAN AND THE 5EA"));
            Assert.AreEqual("J. R. R. TOLKIEN - THE LORD OF THE RINGS", CorrectMistakesCharacter.Correct("J. R. R. T0LK1EN - THE L0RD 0F THE R1NG5"));
            Assert.AreEqual("J. D. SALINGER - THE CATCHER IN THE RYE", CorrectMistakesCharacter.Correct("J. D. 5AL1NGER - THE CATCHER 1N THE RYE"));
            Assert.AreEqual("J. K. ROWLING - HARRY POTTER AND THE PHILOSOPHER'S STONE", CorrectMistakesCharacter.Correct("J. K. R0WL1NG - HARRY P0TTER AND THE PH1L050PHER'5 5T0NE"));
            Assert.AreEqual("J. K. ROWLING - HARRY POTTER AND THE CHAMBER OF SECRETS", CorrectMistakesCharacter.Correct("J. K. R0WL1NG - HARRY P0TTER AND THE CHAMBER 0F 5ECRET5"));
            Assert.AreEqual("J. K. ROWLING - HARRY POTTER AND THE PRISONER OF Azkaban", CorrectMistakesCharacter.Correct("J. K. R0WL1NG - HARRY P0TTER AND THE PR150NER 0F Azkaban"));
            Assert.AreEqual("J. K. ROWLING - HARRY POTTER AND THE GOBLET OF FIRE", CorrectMistakesCharacter.Correct("J. K. R0WL1NG - HARRY P0TTER AND THE G0BLET 0F F1RE"));
            Assert.AreEqual("J. K. ROWLING - HARRY POTTER AND THE ORDER OF PHOENIX", CorrectMistakesCharacter.Correct("J. K. R0WL1NG - HARRY P0TTER AND THE 0RDER 0F PH0EN1X"));
            Assert.AreEqual("J. K. ROWLING - HARRY POTTER AND THE HALF-BLOOD PRINCE", CorrectMistakesCharacter.Correct("J. K. R0WL1NG - HARRY P0TTER AND THE HALF-BL00D PR1NCE"));
            Assert.AreEqual("J. K. ROWLING - HARRY POTTER AND THE DEATHLY HALLOWS", CorrectMistakesCharacter.Correct("J. K. R0WL1NG - HARRY P0TTER AND THE DEATHLY HALL0W5"));
            Assert.AreEqual("URSULA K. LE GUIN - A WIZARD OF EARTHSEA", CorrectMistakesCharacter.Correct("UR5ULA K. LE GU1N - A W1ZARD 0F EARTH5EA"));
            Assert.AreEqual("URSULA K. LE GUIN - THE TOMBS OF ATUAN", CorrectMistakesCharacter.Correct("UR5ULA K. LE GU1N - THE T0MB5 0F ATUAN"));
            Assert.AreEqual("URSULA K. LE GUIN - THE FARTHEST SHORE", CorrectMistakesCharacter.Correct("UR5ULA K. LE GU1N - THE FARTHE5T 5H0RE"));
            Assert.AreEqual("URSULA K. LE GUIN - TALES FROM EARTHSEA", CorrectMistakesCharacter.Correct("UR5ULA K. LE GU1N - TALE5 FR0M EARTH5EA"));
        }

        [Test]
        public void RandomTests()
        {
            Random rand = new Random();
            var length = rand.Next(5, 31);
            var possibleChars = "ABCDEFGHJKLMNPQRTUVWXYZ015";
            for (var run = 0; run < 20; run++)
            {
                var sb = new StringBuilder();

                for (var i = 0; i < length; i++)
                {
                    sb.Append(possibleChars[rand.Next(0, possibleChars.Length)]);
                }
                var text = sb.ToString();

                Assert.AreEqual(text.Replace("5", "S").Replace("1", "I").Replace("0", "O"), CorrectMistakesCharacter.Correct(text));
            }

        }
    }
}
