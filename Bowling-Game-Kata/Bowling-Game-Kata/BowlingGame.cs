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
        private int _totalFrame = 10;

        public void roll(int pins)
        {
            _rolls[_currentIndex] = pins;
            _currentIndex++;
        }

        public int score()
        {
            int _score = 0;

            for (int i = 0; i < _totalFrame; i++)
            {
                if (_rolls[_currentFrame * 2] + _rolls[_currentFrame * 2 + 1] == 10)
                {
                    _score = _score + _rolls[_currentFrame * 2] + _rolls[_currentFrame * 2 + 1] + _rolls[_currentFrame * 2 + 2];
                }
                else
                {
                    _score = _score + _rolls[_currentFrame * 2] + _rolls[_currentFrame * 2 + 1];
                }

                _currentFrame++;
            }

            return _score;
        }
    }
}
