using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameKata
{
    public class BowlingGame
    {
        private int[] _rolls = new int[20];
        private int _currentIndex = 0;
        private int _currentFrame = 0;
        private int _maxFrame = 10;

        public void roll(int pins)
        {
            _rolls[_currentIndex] = pins;
            _currentIndex++;
        }

        public int score()
        {
            int _score = 0;

            for (int i = 0; i < _maxFrame; i++)
            {
                if (IsSpare(_currentFrame))
                {
                    _score += GetFramelScoreWithSpareBonus(_currentFrame);
                }
                else
                {
                    _score += GetFrameScore(_currentFrame);
                }

                _currentFrame++;
            }

            return _score;
        }

        private bool IsSpare(int frame)
        {
            return _rolls[frame * 2] + _rolls[frame * 2 + 1] == 10;
        }

        private int GetFrameScore(int frame)
        {
            return _rolls[frame * 2] + _rolls[frame * 2 + 1];
        }

        private int GetFramelScoreWithSpareBonus(int frame)
        {
            return _rolls[frame * 2] + _rolls[frame * 2 + 1] + _rolls[frame * 2 + 2];
        }
    }
}
