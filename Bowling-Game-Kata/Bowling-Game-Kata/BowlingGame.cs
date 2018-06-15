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

        public void Roll(int pins)
        {
            _rolls.Add(pins);
        }

        public int Score()
        {
            var result = 0;
            var currentRoll = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (_rolls[currentRoll] == 10)
                {
                    result += 10 + _rolls[currentRoll + 1] + _rolls[currentRoll + 2];
                    currentRoll++;
                }
                else if (_rolls[currentRoll] + _rolls[currentRoll + 1] == 10)
                {
                    result += 10 + _rolls[currentRoll + 2];
                    currentRoll += 2;
                }
                else
                {
                    result += _rolls[currentRoll] + _rolls[currentRoll + 1];
                    currentRoll += 2;
                }
            }

            return result;
        }
    }
}