using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameKata
{
    public class BowlingGame
    {
        private int _score = 0;

        public void roll(int pin)
        {
            _score += pin;
        }

        public int score()
        {
            return _score;
        }
    }
}
