using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameKata
{
    public class BowlingGame
    {
        private int _score = 0;

        public void roll(int pins)
        {
            _score += pins;
        }

        public int score()
        {
            return _score;
        }
    }
}
