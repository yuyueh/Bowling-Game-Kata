using System.Collections.Generic;

namespace BowlingGameKata
{
    public class BowlingGame
    {
        private List<int> _rolls;
        private readonly int _totalFrames = 10;

        public BowlingGame()
        {
            _rolls = new List<int>();
        }

        public int Score()
        {
            var score = 0;
            var currentRoll = 0;

            for (int frame = 0; frame < _totalFrames; frame++)
            {
                if (IsStrike(currentRoll))
                {
                    score += 10 + GetStrikeBonus(currentRoll);
                    currentRoll += 1;
                }
                else if (IsSpare(currentRoll))
                {
                    score += 10 + GetSpareBonus(currentRoll);
                    currentRoll += 2;
                }
                else
                {
                    score += GetNormalScore(currentRoll);
                    currentRoll += 2;
                }
            }

            return score;
        }

        private int GetNormalScore(int currentRoll)
        {
            return _rolls[currentRoll] + _rolls[currentRoll + 1];
        }

        private int GetSpareBonus(int currentRoll)
        {
            return _rolls[currentRoll + 2];
        }

        private int GetStrikeBonus(int currentRoll)
        {
            return _rolls[currentRoll + 1] + _rolls[currentRoll + 2];
        }

        private bool IsSpare(int currentRoll)
        {
            return _rolls[currentRoll] + _rolls[currentRoll + 1] == 10;
        }

        private bool IsStrike(int currentRoll)
        {
            return _rolls[currentRoll] == 10;
        }

        public void Roll(int pins)
        {
            _rolls.Add(pins);
        }
    }
}
