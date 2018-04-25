using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameKata
{
    public class BowlingGameKata
    {
        int _score = 0;

        public void roll(int v)
        {
            _score += v;
        }

        public object score()
        {
            return _score;
        }
    }
}
