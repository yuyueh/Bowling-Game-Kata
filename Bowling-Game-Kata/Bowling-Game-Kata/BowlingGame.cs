using System.Collections.Generic;

namespace BowlingGameKata
{
    public class BowlingGame
    {
        private List<int> _rolls;

        public BowlingGame()
        {
            _rolls = new List<int>();
        }

        public int Score()
        {
            var score = 0;
            var currentRoll = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (_rolls[currentRoll] + _rolls[currentRoll + 1] == 10)
                {
                    score += 10 + _rolls[currentRoll + 2];
                    currentRoll += 2;
                }
                else
                {
                    score += _rolls[currentRoll] + _rolls[currentRoll + 1];
                    currentRoll += 2;
                }
            }

            return score;
        }

        public void Roll(int pins)
        {
            _rolls.Add(pins);
        }
    }
}
