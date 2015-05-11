using System;
using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    [TestClass]
    public class BowlingGameTests
    {
        [TestMethod]
        public void TestGutterGame()
        {
            var game = SetupGame();

            RollPins(game, 20, 0);

            Assert.AreEqual(0, game.Score);
        }

        [TestMethod]
        public void TestHittingOnePinPerRole()
        {
            var game = SetupGame();

            RollPins(game, 20, 1);

            Assert.AreEqual(20, game.Score);
        }

        #region Private Methods

        private Game SetupGame()
        {
            return new Game();
        }

        private void RollPins(Game game, int numberOfRolls, int pinsHitPerRole)
        {
            for (int i = 0; i < numberOfRolls; i++)
            {
                game.Roll(pinsHitPerRole);
            }
        }

        #endregion
    }
}
