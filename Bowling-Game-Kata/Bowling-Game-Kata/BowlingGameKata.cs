using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameKata
{
    public class BowlingGameKata
    {
        List<int> balls = new List<int>();

        public void roll(int pins)
        {
            balls.Add(pins);
        }

        public object score()
        {
            int result = 0;
            int totalFrame = 10;
            int currentBall = 0;

            for (int frame = 0; frame < totalFrame; frame++)
            {
                if (IsStrike(currentBall))
                {
                    result += 10 + GetStrikeBonus(currentBall);
                    currentBall++;
                }
                else
                {
                    result += GetFrameScore(currentBall);
                    currentBall += 2;
                }
            }

            return result;
        }

        private bool IsStrike(int currentBall)
        {
            return balls[currentBall] == 10;
        }

        private int GetStrikeBonus(int currentBall)
        {
            return balls[currentBall + 1] + balls[currentBall + 2];
        }

        private int GetFrameScore(int currentBall)
        {
            return balls[currentBall] + balls[currentBall + 1];
        }
    }
}
