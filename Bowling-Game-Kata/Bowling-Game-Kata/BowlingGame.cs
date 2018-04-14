using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingGameKata
{
    public class BowlingGame
    {
        private int[] _rolls = new int[20];
        private int _currentIndex = 0;
        private int _maxFrame = 10;

        public void roll(int pins)
        {
            _rolls[_currentIndex] = pins;
            _currentIndex++;
        }

        public int score()
        {
            return Enumerable.Range(0, _maxFrame).Select(frame =>
            {
                if (IsSpare(frame))
                {
                    return GetFramelScoreWithSpareBonus(frame);
                }
                else
                {
                    return GetFrameScore(frame);
                }
            }).Sum();
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
