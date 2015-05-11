using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private List<int> _rolls = new List<int>(21);
        private int currentRoll = 0;

        public void Roll(int pinsHit)
        {
            _rolls.Add(pinsHit);
            currentRoll++;
        }

        public int Score
        {
            get
            {
                int score = 0;
                int i = 0;
                for (int frame = 0; frame < 10; frame++)
                {
                    if (_rolls[i] + _rolls[i + 1] == 10)
                    {
                        //spare
                        score += 10 + _rolls[i + 2];
                        i += 2;
                    }
                    else
                    {
                        score += _rolls[i] + _rolls[i + 1];
                        i += 2;
                    }
                }
                return score;
            }
        }
    }
}
