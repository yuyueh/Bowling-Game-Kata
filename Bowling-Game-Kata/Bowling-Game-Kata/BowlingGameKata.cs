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
                if (balls[currentBall] == 10)
                {
                    result += 10 + balls[currentBall + 1] + balls[currentBall + 2];
                    currentBall++;
                }
                else
                {
                    result += balls[currentBall] + balls[currentBall + 1];
                    currentBall += 2;
                }
            }

            return result;
        }
    }
}
