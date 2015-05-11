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

        [TestMethod]
        public void TestOneSpare()
        {
            var game = SetupGame();

            RollSpare(game);
            game.Roll(3);
            RollPins(game, 17, 0);

            Assert.AreEqual(16, game.Score);
        }

        [TestMethod]
        public void TestOneStrike()
        {
            var game = SetupGame();

            RollStrike(game);
            game.Roll(3);
            game.Roll(4);
            RollPins(game, 16, 0);

            Assert.AreEqual(24, game.Score);
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

        private static void RollSpare(Game game)
        {
            game.Roll(5);
            game.Roll(5);
        }

        private void RollStrike(Game game)
        {
            game.Roll(10);
        }

        #endregion
    }
}
