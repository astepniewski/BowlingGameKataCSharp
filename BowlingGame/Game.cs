using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        public Game()
        {
            Score = 0;
        }

        public int Score { get; set; }

        public void Roll(int pinsHit)
        {
            Score += pinsHit;
        }
    }
}
