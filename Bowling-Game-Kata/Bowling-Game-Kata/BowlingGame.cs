using System.Collections.Generic;

namespace BowlingGameKata
{
    public class BowlingGame
    {
        private readonly List<int> _rolls;

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
                if (IsStrike(currentRoll))
                {
                    result += 10 + GetStrikeBonus(currentRoll);
                    currentRoll++;
                }
                else if (IsSpare(currentRoll))
                {
                    result += 10 + GetSpareBonus(currentRoll);
                    currentRoll += 2;
                }
                else
                {
                    result += GetNormalScore(currentRoll);
                    currentRoll += 2;
                }
            }

            return result;
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
    }
}