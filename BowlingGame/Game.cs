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
        private int _currentRoll = 0;

        public Game()
        {
            for (int i = 0; i < 22; i++)
            {
                _rolls.Add(0);
            }
        }

        public void Roll(int pinsHit)
        {
            _rolls[_currentRoll++] = pinsHit;
        }

        public int Score
        {
            get
            {
                int score = 0;
                int frameIndex = 0;
                for (int frame = 0; frame < 10; frame++)
                {
                    if (IsStrike(frameIndex))
                    {
                        score += 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
                        frameIndex++;
                    }
                    else if (IsSpare(frameIndex))
                    {
                        score += 10 + _rolls[frameIndex + 2];
                        frameIndex += 2;
                    }
                    else
                    {
                        score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                        frameIndex += 2;
                    }
                }
                return score;
            }
        }

        private bool IsStrike(int frameIndex)
        {
            return _rolls[frameIndex] == 10;
        }

        private bool IsSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }
    }
}
