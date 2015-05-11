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
            var game = new Game();

            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            Assert.AreEqual(0, game.Score);
        }
    }
}
