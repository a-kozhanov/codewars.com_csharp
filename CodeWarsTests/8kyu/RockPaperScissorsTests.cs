using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RockPaperScissorsTests
    {
        RockPaperScissors kata = new RockPaperScissors();

        [Test]
        public void Player1Win()
        {
            Assert.AreEqual("Player 1 won!", kata.Rps("rock", "scissors"));
            Assert.AreEqual("Player 1 won!", kata.Rps("scissors", "paper"));
            Assert.AreEqual("Player 1 won!", kata.Rps("paper", "rock"));
        }

        [Test]
        public void Player2Win()
        {
            Assert.AreEqual("Player 2 won!", kata.Rps("scissors", "rock"));
            Assert.AreEqual("Player 2 won!", kata.Rps("paper", "scissors"));
            Assert.AreEqual("Player 2 won!", kata.Rps("rock", "paper"));
        }

        [Test]
        public void Draw()
        {
            Assert.AreEqual("Draw!", kata.Rps("rock", "rock"));
            Assert.AreEqual("Draw!", kata.Rps("scissors", "scissors"));
            Assert.AreEqual("Draw!", kata.Rps("paper", "paper"));
        }
    }
}